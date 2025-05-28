using ITS.DAL.Data.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ITS.Api.Configuration
{
	public static class JwtGenerator
	{
		public static string GenerateToken(ApplicationUser user, IList<string> roles, IConfiguration configuration, bool rememberMe)
		{
			var claims = new List<Claim>()
			{
				new (JwtRegisteredClaimNames.Sub, user.Id.ToString()),
				new (JwtRegisteredClaimNames.Name, user.FirstName + " " + user.LastName),
				new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			foreach (var role in roles)
			{
				claims.Add(new Claim(ClaimTypes.Role, role));
			}

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			var tokenExpiration = rememberMe ? DateTime.UtcNow.AddDays(7) : DateTime.UtcNow.AddHours(1);

			var token = new JwtSecurityToken(
				issuer: configuration["Jwt:Issuer"],
				audience: configuration["Jwt:Audience"],
				claims: claims,
				expires: tokenExpiration,
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
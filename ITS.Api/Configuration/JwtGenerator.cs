using ITS.DAL.Data.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ITS.Api.Configuration
{
	public static class JwtGenerator
	{
		public static string GenerateToken(ApplicationUser user, IList<string> roles, IConfiguration configuration)
		{
			var claims = new List<Claim>()
			{
				new (ClaimTypes.NameIdentifier, user.Id.ToString()),
				new (JwtRegisteredClaimNames.Name, user.FirstName + " " + user.LastName),
				new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
			};

			foreach (var role in roles)
			{
				claims.Add(new Claim(ClaimTypes.Role, role));
			}

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				issuer: configuration["Jwt:Issuer"],
				audience: configuration["Jwt:Audience"],
				claims: claims,
				expires: DateTime.Now.AddHours(1),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
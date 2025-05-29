using ITS.Core.Services;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities.Contracts;
using ITS.DAL.Data.Utilities;
using ITS.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

			services.AddScoped<IRepository, Repository>();

			return services;
		}

		public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
			{
				options.User.RequireUniqueEmail = true;
				options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

				options.SignIn.RequireConfirmedAccount = false;

				options.Password.RequiredLength = 6;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
			})
				.AddEntityFrameworkStores<AppDbContext>()
				.AddDefaultTokenProviders();

			return services;
		}

		public static IServiceCollection AddApplicationAuthentication(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = configuration["Jwt:Issuer"],
					ValidAudience = configuration["Jwt:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(
						Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
				};
			});

			return services;
		}
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<ITicketService, TicketService>();

			return services;
		}
	}
}
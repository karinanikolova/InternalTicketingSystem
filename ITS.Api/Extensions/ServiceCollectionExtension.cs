using ITS.Core.Services;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities;
using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using static ITS.DAL.Constants.CustomRolesAndClaims;

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
					NameClaimType = CustomSubjectClaimType,
					RoleClaimType = CustomRoleClaimType,
					
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = configuration["Jwt:Issuer"],
					ValidAudience = configuration["Jwt:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(
						Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
				};

				options.Events = new JwtBearerEvents
				{
					OnTokenValidated = context =>
					{
						var identity = context.Principal?.Identity as ClaimsIdentity;

						if (identity != null && identity.IsAuthenticated)
						{
							// Creating a new identity with the desired claim type mappings
							var newIdentity = new ClaimsIdentity(
								identity.Claims,
								identity.AuthenticationType,
								nameType: CustomSubjectClaimType,
								roleType: CustomRoleClaimType
							);

							context.Principal = new ClaimsPrincipal(newIdentity);
						}

						return Task.CompletedTask;
					}
				};
			});

			return services;
		}

		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<ITicketService, TicketService>();
			services.AddScoped<ICommentService, CommentService>();

			return services;
		}
	}
}
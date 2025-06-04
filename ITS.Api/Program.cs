using System.IdentityModel.Tokens.Jwt;

namespace ITSApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Disabling automatic claim type mapping before DI/config is built
			JwtSecurityTokenHandler.DefaultMapInboundClaims = false;

			var builder = WebApplication.CreateBuilder(args);

			// Configuring services
			builder.Services.AddApplicationDbContext(builder.Configuration);
			builder.Services.AddApplicationIdentity(builder.Configuration);
			builder.Services.AddApplicationAuthentication(builder.Configuration);
			builder.Services.AddAuthorization();

			builder.Services.AddApplicationServices();

			builder.Services.AddControllers();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}
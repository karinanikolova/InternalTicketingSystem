using ITS.Api.Configuration;
using ITS.Core.Models.Authentication;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITS.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthenticationController : BaseApiController
	{
		private readonly IAuthenticationService _authService;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly IConfiguration _configuration;

		public AuthenticationController(IAuthenticationService authService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
		{
			_authService = authService;
			_userManager = userManager;
			_signInManager = signInManager;
			_configuration = configuration;
		}

		[Authorize(Roles = "Admin")]
		[HttpPost("register")]
		public async Task<IActionResult> Register(RegisterDto registerDto)
		{
			try
			{
				var departmentId = await _authService.GetDepartmentIdByNameAsync(registerDto.DepartmentName);

				if (departmentId == null || departmentId == Guid.Empty)
				{
					return BadRequest($"Department '{registerDto.DepartmentName}' does not exist.");
				}

				var user = new ApplicationUser()
				{
					UserName = registerDto.UserName,
					FirstName = registerDto.FirstName,
					LastName = registerDto.LastName,
					Email = registerDto.Email,
					DepartmentId = departmentId.Value
				};

				var identityResult = await _userManager.CreateAsync(user, registerDto.Password);

				if (!identityResult.Succeeded)
				{
					return BadRequest(identityResult.Errors.Select(e => e.Description));
				}

				await _userManager.AddToRoleAsync(user, "Employee");

				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(500, "An error occurred while registering the user.");
			}
		}

		[AllowAnonymous]
		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginDto loginDto)
		{
			var user = await _userManager.FindByEmailAsync(loginDto.UserNameOrEmail) ?? await _userManager.FindByNameAsync(loginDto.UserNameOrEmail);

			if (user == null)
			{
				return Unauthorized("Invalid credentials");
			}

			var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

			if (!result.Succeeded)
			{
				return Unauthorized("Invalid credentials");
			}

			var roles = await _userManager.GetRolesAsync(user);
			var token = JwtGenerator.GenerateToken(user, roles, _configuration, loginDto.RememberMe);

			return Ok(new { token });
		}
	}
}
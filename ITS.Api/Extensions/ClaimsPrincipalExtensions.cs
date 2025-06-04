using static ITS.DAL.Constants.CustomClaims;
using static ITS.DAL.Constants.CustomRoles;

namespace System.Security.Claims
{
	public static class ClaimsPrincipalExtensions
	{
		public static Guid? UserId(this ClaimsPrincipal user)
		{
			var userIdClaim = user.FindFirstValue(ClaimTypes.NameIdentifier) ?? user.FindFirstValue("sub");

			return Guid.TryParse(userIdClaim, out Guid result) ? result : null;
		}

		public static string FindUserRole(this ClaimsPrincipal user)
			=> user.FindFirstValue(ClaimTypes.Role) ?? user.FindFirstValue("role");

		public static bool IsAdmin(this ClaimsPrincipal user)
			=> user.IsInRole(AdminRole);

		public static bool IsSupportAgent(this ClaimsPrincipal user)
			=> user.HasClaim(c => c.Type == UserSupportAgentClaim && c.Value == "true");
	}
}
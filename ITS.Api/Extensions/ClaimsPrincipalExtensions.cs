using static ITS.DAL.Constants.CustomClaims;
using static ITS.DAL.Constants.CustomRoles;

namespace System.Security.Claims
{
	public static class ClaimsPrincipalExtensions
	{
		public static string UserId(this ClaimsPrincipal user)
			=> user.FindFirstValue(ClaimTypes.NameIdentifier)!;

		public static string FindUserRole(this ClaimsPrincipal user)
			=> user.FindFirstValue(ClaimTypes.Role)!;

		public static bool IsAdmin(this ClaimsPrincipal user)
			=> user.IsInRole(AdminRole);

		public static bool IsSupportAgent(this ClaimsPrincipal user)
			=> user.HasClaim(c => c.Type == UserSupportAgentClaim && c.Value == "true");
	}
}
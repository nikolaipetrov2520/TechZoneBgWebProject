namespace TechZoneBgWebProject.Web.Infrastructure.Extensions
{
    using System.Security.Claims;

    using TechZoneBgWebProject.Common;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);

        public static bool IsAdministrator(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.IsInRole(GlobalConstants.Admin.AdministratorRoleName);

        public static bool IsModerator(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.IsInRole(GlobalConstants.Moderator.ModeratorRoleName);

        public static bool IsTechzoneBgEmployee(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.IsInRole(GlobalConstants.TechzoneBgEmployee.EmployeeRoleName);

        public static bool IsSwipegEmployee(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.IsInRole(GlobalConstants.SwypeEmployee.EmployeeRoleName);
    }
}

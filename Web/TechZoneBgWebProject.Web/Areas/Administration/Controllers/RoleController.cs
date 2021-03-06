namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Roles;
    using TechZoneBgWebProject.Web.ViewModels.Roles;

    public class RoleController : AdministrationController
    {
        private const int UserPerPage = 18;

        private readonly IRolesService rolesService;

        public RoleController(IRolesService rolesService)
        {
            this.rolesService = rolesService;
        }

        public async Task<IActionResult> All(int page = 1, string search = null)
        {
            var skip = (page - 1) * UserPerPage;
            var count = await this.rolesService.GetCountAsync(search);
            var users = await this.rolesService.GetAllAsync<RolesAllViewModel>(count, search, skip, UserPerPage, page);

            return this.View(users);
        }

    }
}

namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Roles;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.ViewModels.Users;

    public class UsersController : AdministrationController
    {
        private readonly IUsersService usersService;
        private readonly IRolesService rolesService;

        public UsersController(IUsersService usersService, IRolesService rolesService)
        {
            this.usersService = usersService;
            this.rolesService = rolesService;
        }

        public async Task<IActionResult> All(string search = null)
        {
            var users = await this.usersService.GetAllSearchAsync<UsersRolesViewModel>(search);

            foreach (var user in users)
            {
                user.Roles = await this.rolesService.GetAllByUserIdAsync(user.Id);
            }

            return this.View(users);
        }
    }
}

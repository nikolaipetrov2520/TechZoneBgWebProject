namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;

    internal class AdminSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetService<RoleManager<ApplicationRole>>();

            var isExisting = await userManager.Users.AnyAsync(u => u.UserName == GlobalConstants.AdministratorUserName);
            if (!isExisting)
            {
                var admin = new ApplicationUser
                {
                    UserName = GlobalConstants.AdministratorUserName,
                    Email = GlobalConstants.AdministratorEmail,
                    ProfilePicture = GlobalConstants.AdministratorProfilePicture,
                    EmailConfirmed = false,
                    PhoneNumber = GlobalConstants.AdministratorPhoneNumber,
                    IsModified = true,
                    FirstName = GlobalConstants.AdministratorFirstName,
                    LastName = GlobalConstants.AdministratorLastName,
                };

                var result = await userManager.CreateAsync(admin, GlobalConstants.AdministratorPassword);
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }

                var isRoleExists = await roleManager.RoleExistsAsync(GlobalConstants.AdministratorRoleName);
                if (isRoleExists)
                {
                    await userManager.AddToRoleAsync(admin, GlobalConstants.AdministratorRoleName);
                }
            }
        }
    }
}

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

    internal class UserSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            var isExisting = await userManager.Users.AnyAsync(u => u.UserName == GlobalConstants.User.UserUserName);
            if (!isExisting)
            {
                var testUser = new ApplicationUser
                {
                    UserName = GlobalConstants.User.UserUserName,
                    Email = GlobalConstants.User.UserEmail,
                    ProfilePicture = GlobalConstants.User.UserProfilePicture,
                    EmailConfirmed = false,
                    PhoneNumber = GlobalConstants.User.UserPhoneNumber,
                    IsModified = true,
                    FirstName = GlobalConstants.User.UserFirstName,
                    LastName = GlobalConstants.User.UserLastName,
                };

                var result = await userManager.CreateAsync(testUser, GlobalConstants.User.UserPassword);
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}

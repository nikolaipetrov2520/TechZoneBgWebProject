namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Categories.AnyAsync())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category { Name = "Sports", CreatedOn = DateTime.Now },
                new Category { Name = "Programming", CreatedOn = DateTime.Now },
                new Category { Name = "News", CreatedOn = DateTime.Now },
                new Category { Name = "Gaming", CreatedOn = DateTime.Now },
                new Category { Name = "HiTech", CreatedOn = DateTime.Now },
                new Category { Name = "SmartPhones", CreatedOn = DateTime.Now },
            };

            await dbContext.AddRangeAsync(categories);
        }
    }
}

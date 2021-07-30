namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class TagsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Tags.AnyAsync())
            {
                return;
            }

            var tags = new List<Tag>
            {
                new Tag { Name = "C#", CreatedOn = DateTime.Now },
                new Tag { Name = "Python", CreatedOn = DateTime.Now },
                new Tag { Name = "Java", CreatedOn = DateTime.Now },
                new Tag { Name = "SQL", CreatedOn = DateTime.Now },
                new Tag { Name = "Football", CreatedOn = DateTime.Now },
                new Tag { Name = "Basketball", CreatedOn = DateTime.Now },
                new Tag { Name = "Microsoft", CreatedOn = DateTime.Now },
                new Tag { Name = "iPhone", CreatedOn = DateTime.Now },
                new Tag { Name = "Xiaomi", CreatedOn = DateTime.Now },
                new Tag { Name = "Laptop", CreatedOn = DateTime.Now },
                new Tag { Name = "Samsung", CreatedOn = DateTime.Now },
            };

            await dbContext.AddRangeAsync(tags);
        }
    }
}

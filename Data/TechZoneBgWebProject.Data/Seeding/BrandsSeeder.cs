namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class BrandsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Brands.AnyAsync())
            {
                return;
            }

            var brand = new List<Brand>
            {
                new Brand { Name = "Apple" },
                new Brand { Name = "Samsung" },
                new Brand { Name = "Huawei" },
                new Brand { Name = "Xiaomi" },
            };

            await dbContext.AddRangeAsync(brand);
        }
    }
}

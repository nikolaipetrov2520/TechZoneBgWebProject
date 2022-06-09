namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class StatusSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Status.AnyAsync())
            {
                return;
            }

            var status = new List<Status>
            {
                new Status { Name = "Проверен" },
                new Status { Name = "За проверка" },
                new Status { Name = "За продажба" },
                new Status { Name = "Незакупен" },
                new Status { Name = "Рекламация" },
                new Status { Name = "В ремонт" },
                new Status { Name = "Архив" },
                new Status { Name = "Outlet" },
            };

            await dbContext.AddRangeAsync(status);
        }
    }
}

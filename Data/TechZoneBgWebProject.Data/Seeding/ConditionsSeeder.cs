namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class ConditionsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Conditions.AnyAsync())
            {
                return;
            }

            var conditions = new List<Condition>
            {
                new Condition { Name = "Като нов" },
                new Condition { Name = "Отличен" },
                new Condition { Name = "Много добър" },
                new Condition { Name = "Добър" },
                new Condition { Name = "Преглежда се" },
            };

            await dbContext.AddRangeAsync(conditions);
        }
    }
}

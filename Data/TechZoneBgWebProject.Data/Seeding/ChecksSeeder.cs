namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    internal class ChecksSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Checks.AnyAsync())
            {
                return;
            }

            var check = new List<Check>
            {
                new Check { Name = "Премахнат акаунт и е върнат към фабрични настройки" },
                new Check { Name = "Проверен IMEI код и не обявен за откраднат или изгубен" },
                new Check { Name = "Работи с трите български мобилни оператора" },
                new Check { Name = "Тест на дисплеят" },
                new Check { Name = "Тест на батерията" },
                new Check { Name = "Проверка на всички видове свързаност (WiFi, Celluar, Bluetooth, GSM сигнал и GPS навигация)" },
                new Check { Name = "Проверка за изправни: портове за сим, карта памет, зареждане и слушалки" },
                new Check { Name = "Тест на функциите на устройствата" },
                new Check { Name = "Тест на бутоните и тяхната функционалност" },
                new Check { Name = "Проверка на пръстов отпечатък или лицево разпознаване" },
                new Check { Name = "Игла за SIM слот" },
            };

            await dbContext.AddRangeAsync(check);
        }
    }
}

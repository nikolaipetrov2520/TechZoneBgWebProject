namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data.Models;

    public class DevicesModelsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.DevicesModels.AnyAsync())
            {
                return;
            }

            var brand = new List<DeviceModel>
            {
                new DeviceModel { BrandId = 1, Name = "iPhone 6s" },
                new DeviceModel { BrandId = 1, Name = "iPhone 6s Plus" },
                new DeviceModel { BrandId = 1, Name = "iPhone 7" },
                new DeviceModel { BrandId = 1, Name = "iPhone 7 Plus" },
                new DeviceModel { BrandId = 1, Name = "iPhone 8" },
                new DeviceModel { BrandId = 1, Name = "iPhone 8 Plus" },
                new DeviceModel { BrandId = 1, Name = "iPhone X" },
                new DeviceModel { BrandId = 1, Name = "iPhone XR" },
                new DeviceModel { BrandId = 1, Name = "iPhone XS" },
                new DeviceModel { BrandId = 1, Name = "iPhone XS Max" },
                new DeviceModel { BrandId = 1, Name = "iPhone SE 2020" },
                new DeviceModel { BrandId = 1, Name = "iPhone 11" },
                new DeviceModel { BrandId = 1, Name = "iPhone 11 Pro" },
                new DeviceModel { BrandId = 1, Name = "iPhone 11 Pro Max" },
                new DeviceModel { BrandId = 1, Name = "iPhone 12" },
                new DeviceModel { BrandId = 1, Name = "iPhone 12 Mini" },
                new DeviceModel { BrandId = 1, Name = "iPhone 12 Pro" },
                new DeviceModel { BrandId = 1, Name = "iPhone 12 Pro Max" },
                new DeviceModel { BrandId = 1, Name = "iPhone 13" },
                new DeviceModel { BrandId = 1, Name = "iPhone 13 Mini" },
                new DeviceModel { BrandId = 1, Name = "iPhone 13 Pro" },
                new DeviceModel { BrandId = 1, Name = "iPhone 13 Pro Max" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A12" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A20e" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A20s" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A21" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A21s" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A30s" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A31" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A32" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A32 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A40" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A41" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A42 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A50" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A51" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A52" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A52 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A70" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A71" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A71 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A72" },
                new DeviceModel { BrandId = 2, Name = "Galaxy A72 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S10" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S10 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S10e" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S10 Lite" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S10 Plus" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 FE" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 FE 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S21 FE 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 Plus" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 Plus 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 Ultra" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S20 Ultra 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S21" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S21 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S21 Plus 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy S21 Ultra 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 9" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 10" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 10 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 10 Plus" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 10 Lite" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 20" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 20 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 20 Ultra" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Note 20 Ultra 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Z Flip" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Z Flip 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Z Flip3 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Z Fold2 5G" },
                new DeviceModel { BrandId = 2, Name = "Galaxy Z Fold3 5G" },
                new DeviceModel { BrandId = 3, Name = "P20" },
                new DeviceModel { BrandId = 3, Name = "P20 Lite" },
                new DeviceModel { BrandId = 3, Name = "P20 Pro" },
                new DeviceModel { BrandId = 3, Name = "P30" },
                new DeviceModel { BrandId = 3, Name = "P30 Lite" },
                new DeviceModel { BrandId = 3, Name = "P30 Pro" },
                new DeviceModel { BrandId = 3, Name = "P40" },
                new DeviceModel { BrandId = 3, Name = "P40 Lite" },
                new DeviceModel { BrandId = 3, Name = "P40 Lite 5G" },
                new DeviceModel { BrandId = 3, Name = "P40 Pro 5G" },
                new DeviceModel { BrandId = 3, Name = "P40 Pro Plus" },
                new DeviceModel { BrandId = 3, Name = "Mate 20" },
                new DeviceModel { BrandId = 3, Name = "Mate 20 Lite" },
                new DeviceModel { BrandId = 3, Name = "Mate 20 Pro" },
                new DeviceModel { BrandId = 3, Name = "Mate 30 Pro" },
                new DeviceModel { BrandId = 3, Name = "Mate 30 Pro" },
                new DeviceModel { BrandId = 3, Name = "P Smart Z" },
                new DeviceModel { BrandId = 3, Name = "P Smart (2018)" },
                new DeviceModel { BrandId = 3, Name = "P Smart (2019)" },
                new DeviceModel { BrandId = 3, Name = "P Smart (2020)" },
                new DeviceModel { BrandId = 3, Name = "P Smart (2021)" },
                new DeviceModel { BrandId = 4, Name = "Poco X3" },
                new DeviceModel { BrandId = 4, Name = "Poco X3 GT" },
                new DeviceModel { BrandId = 4, Name = "Poco X3 Pro" },
                new DeviceModel { BrandId = 4, Name = "Poco F3 5G" },
                new DeviceModel { BrandId = 4, Name = "Pocophone F1" },
                new DeviceModel { BrandId = 4, Name = "Redmi 9T" },
                new DeviceModel { BrandId = 4, Name = "Redmi Note 9 Pro" },
                new DeviceModel { BrandId = 4, Name = "Redmi 10" },
                new DeviceModel { BrandId = 4, Name = "Redmi Note 10" },
                new DeviceModel { BrandId = 4, Name = "Redmi Note 10 5G" },
                new DeviceModel { BrandId = 4, Name = "Redmi Note 10s" },
                new DeviceModel { BrandId = 4, Name = "Redmi Note 10 Pro" },
                new DeviceModel { BrandId = 4, Name = "Mi 9T" },
                new DeviceModel { BrandId = 4, Name = "Mi 10 5G" },
                new DeviceModel { BrandId = 4, Name = "Mi 10T Lite 5G" },
                new DeviceModel { BrandId = 4, Name = "Mi 10T Pro 5G" },
                new DeviceModel { BrandId = 4, Name = "Mi 10T 5G" },
                new DeviceModel { BrandId = 4, Name = "Mi Note 10" },
                new DeviceModel { BrandId = 4, Name = "Mi Note 10 Pro" },
                new DeviceModel { BrandId = 4, Name = "Mi 11" },
                new DeviceModel { BrandId = 4, Name = "Mi 11i" },
                new DeviceModel { BrandId = 4, Name = "Mi 11 Lite" },
                new DeviceModel { BrandId = 4, Name = "Mi 11 Lite 5G" },
                new DeviceModel { BrandId = 4, Name = "Mi 11T" },
                new DeviceModel { BrandId = 4, Name = "Mi 11T Pro" },

            };

            await dbContext.AddRangeAsync(brand);
        }
    }
}

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

            var apple = dbContext.Brands.FirstOrDefault(b => b.Name == "Apple").Id;
            var samsung = dbContext.Brands.FirstOrDefault(b => b.Name == "Samsung").Id;
            var huawei = dbContext.Brands.FirstOrDefault(b => b.Name == "Huawei").Id;
            var xiaomi = dbContext.Brands.FirstOrDefault(b => b.Name == "Xiaomi").Id;

            var deviceModel = new List<DeviceModel>
            {
                new DeviceModel { BrandId = apple, Name = "iPhone 6s" },
                new DeviceModel { BrandId = apple, Name = "iPhone 6s Plus" },
                new DeviceModel { BrandId = apple, Name = "iPhone 7" },
                new DeviceModel { BrandId = apple, Name = "iPhone 7 Plus" },
                new DeviceModel { BrandId = apple, Name = "iPhone 8" },
                new DeviceModel { BrandId = apple, Name = "iPhone 8 Plus" },
                new DeviceModel { BrandId = apple, Name = "iPhone X" },
                new DeviceModel { BrandId = apple, Name = "iPhone XR" },
                new DeviceModel { BrandId = apple, Name = "iPhone XS" },
                new DeviceModel { BrandId = apple, Name = "iPhone XS Max" },
                new DeviceModel { BrandId = apple, Name = "iPhone SE 2020" },
                new DeviceModel { BrandId = apple, Name = "iPhone 11" },
                new DeviceModel { BrandId = apple, Name = "iPhone 11 Pro" },
                new DeviceModel { BrandId = apple, Name = "iPhone 11 Pro Max" },
                new DeviceModel { BrandId = apple, Name = "iPhone 12" },
                new DeviceModel { BrandId = apple, Name = "iPhone 12 Mini" },
                new DeviceModel { BrandId = apple, Name = "iPhone 12 Pro" },
                new DeviceModel { BrandId = apple, Name = "iPhone 12 Pro Max" },
                new DeviceModel { BrandId = apple, Name = "iPhone 13" },
                new DeviceModel { BrandId = apple, Name = "iPhone 13 Mini" },
                new DeviceModel { BrandId = apple, Name = "iPhone 13 Pro" },
                new DeviceModel { BrandId = apple, Name = "iPhone 13 Pro Max" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A12" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A20e" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A20s" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A21" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A21s" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A30s" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A31" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A32" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A32 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A40" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A41" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A42 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A50" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A51" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A52" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A52 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A70" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A71" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A71 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A72" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy A72 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S10" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S10 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S10e" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S10 Lite" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S10 Plus" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 FE" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 FE 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S21 FE 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 Plus" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 Plus 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 Ultra" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S20 Ultra 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S21" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S21 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S21 Plus 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy S21 Ultra 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 9" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 10" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 10 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 10 Plus" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 10 Lite" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 20" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 20 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 20 Ultra" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Note 20 Ultra 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Z Flip" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Z Flip 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Z Flip3 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Z Fold2 5G" },
                new DeviceModel { BrandId = samsung, Name = "Galaxy Z Fold3 5G" },
                new DeviceModel { BrandId = huawei, Name = "P20" },
                new DeviceModel { BrandId = huawei, Name = "P20 Lite" },
                new DeviceModel { BrandId = huawei, Name = "P20 Pro" },
                new DeviceModel { BrandId = huawei, Name = "P30" },
                new DeviceModel { BrandId = huawei, Name = "P30 Lite" },
                new DeviceModel { BrandId = huawei, Name = "P30 Pro" },
                new DeviceModel { BrandId = huawei, Name = "P40" },
                new DeviceModel { BrandId = huawei, Name = "P40 Lite" },
                new DeviceModel { BrandId = huawei, Name = "P40 Lite 5G" },
                new DeviceModel { BrandId = huawei, Name = "P40 Pro 5G" },
                new DeviceModel { BrandId = huawei, Name = "P40 Pro Plus" },
                new DeviceModel { BrandId = huawei, Name = "Mate 20" },
                new DeviceModel { BrandId = huawei, Name = "Mate 20 Lite" },
                new DeviceModel { BrandId = huawei, Name = "Mate 20 Pro" },
                new DeviceModel { BrandId = huawei, Name = "Mate 30 Pro" },
                new DeviceModel { BrandId = huawei, Name = "Mate 30 Pro" },
                new DeviceModel { BrandId = huawei, Name = "P Smart Z" },
                new DeviceModel { BrandId = huawei, Name = "P Smart (2018)" },
                new DeviceModel { BrandId = huawei, Name = "P Smart (2019)" },
                new DeviceModel { BrandId = huawei, Name = "P Smart (2020)" },
                new DeviceModel { BrandId = huawei, Name = "P Smart (2021)" },
                new DeviceModel { BrandId = xiaomi, Name = "Poco X3" },
                new DeviceModel { BrandId = xiaomi, Name = "Poco X3 GT" },
                new DeviceModel { BrandId = xiaomi, Name = "Poco X3 Pro" },
                new DeviceModel { BrandId = xiaomi, Name = "Poco F3 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Pocophone F1" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi 9T" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi Note 9 Pro" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi 10" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi Note 10" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi Note 10 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi Note 10s" },
                new DeviceModel { BrandId = xiaomi, Name = "Redmi Note 10 Pro" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 9T" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 10 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 10T Lite 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 10T Pro 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 10T 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi Note 10" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi Note 10 Pro" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11i" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11 Lite" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11 Lite 5G" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11T" },
                new DeviceModel { BrandId = xiaomi, Name = "Mi 11T Pro" },

            };

            await dbContext.AddRangeAsync(deviceModel);
        }
    }
}

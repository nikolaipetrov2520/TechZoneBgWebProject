namespace TechZoneBgWebProject.Services.Devices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DevicesService : IDevicesService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public DevicesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<List<DevicesListingViewModel>> GetAllAsync()
        {
            var querable = await this.db.Devices
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted)
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Imei = item.Imei,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Color = item.Color,
                    Memory = item.Memory,
                    Status = item.Status.Name,
                    Seller = item.Seller,
                };
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllInspectingAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "За проверка")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.CreatedOn,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<DeviceNotInspectedImputModel> GetNotInspectedByIdAsync(int id)
        {
            var queryable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .Where(p => p.Id == id && !p.IsDeleted)
                .FirstOrDefaultAsync();

            var device = new DeviceNotInspectedImputModel
            {
                Id = queryable.Id,
                DeviceModel = $"{queryable.DeviceModel.Brand.Name} {queryable.DeviceModel.Name}",
                Color = queryable.Color,
                Memory = queryable.Memory,
                Seller = queryable.Seller,
            };

            return device;
        }
    }
}

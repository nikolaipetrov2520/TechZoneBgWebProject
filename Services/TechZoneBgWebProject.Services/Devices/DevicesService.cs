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
    using TechZoneBgWebProject.Data.Models;
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

        public async Task<List<DevicesListingViewModel>> GetAllAsync(string search = null)
        {
            var queryable = this.db.Devices
                .Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .Include(d => d.Status)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                var filters = search.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var filter in filters)
                {
                    queryable = queryable
                    .Where(t => t.Imei.Contains(filter)
                    || t.DeviceModel.Name.Contains(filter)
                    || t.DeviceModel.Brand.Name.Contains(filter)
                    || t.Color.Contains(filter)
                    || t.Seller.Contains(filter));
                }
            }

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in queryable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Imei = item.Imei,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                    Status = item.Status.Name,
                };

                devices.Add(device);
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
            var queryable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand).Include(c => c.Condition)
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
                Condition = queryable.Condition.Id,
                ConditionName = queryable.Condition.Name,
                Repairs = queryable.Repair,
                Imei = queryable.Imei,
                Description = queryable.Description,
            };

            return device;
        }

        public async Task<DeviceNotInspectedImputModel> GetNotInspectedWithNotWalidEmaiByIdAsync(int id)
        {
            var queryable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand).Include(c => c.Condition)
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
                Condition = queryable.Condition.Id,
                ConditionName = queryable.Condition.Name,
                Repairs = queryable.Repair,
                Imei = queryable.Imei,
                Description = queryable.Description,
            };

            return device;
        }

        public async Task<DeviceDetailsViewModel> GetByIdAsync(int id)
        {
            var queryable = await this.db.Devices
                .Include(d => d.DeviceModel)
                .ThenInclude(dm => dm.Brand)
                .Include(c => c.Condition)
                .Include(a => a.Author)
                .AsNoTracking()
                .Where(p => p.Id == id && !p.IsDeleted)
                .FirstOrDefaultAsync();

            var device = new DeviceDetailsViewModel
            {
                Id = queryable.Id,
                DeviceModel = $"{queryable.DeviceModel.Brand.Name} {queryable.DeviceModel.Name}",
                Color = queryable.Color,
                Memory = queryable.Memory,
                Seller = queryable.Seller,
                Condition = queryable.Condition.Name,
                Repairs = queryable.Repair,
                Imei = queryable.Imei,
                Description = queryable.Description,
                Author = $"{queryable.Author.FirstName} {queryable.Author.LastName}",
                StatusId = queryable.StatusId,
            };

            return device;
        }

        public async Task InspectAsync(DeviceNotInspectedImputModel input, string userId)
        {
            var device = await this.db.Devices
                .Include(d => d.CheckList)
                .FirstOrDefaultAsync(d => d.Id == input.Id);

            int status = this.db.Status.FirstOrDefault(s => s.Name == "Проверен").Id;

            if (device.Imei == null)
            {
                device.Imei = input.Imei;
            }

            if (device.ModifiedOn == null)
            {
                device.ModifiedOn = DateTime.Now;
            }

            if (device.Description == null && input.Description != null)
            {
                device.Description = input.Description;
            }

            device.ConditionId = input.ConditionId;

            if (device.AuthorId == null)
            {
                device.AuthorId = userId;
            }

            device.Repair = input.Repairs;

            bool isAllChecked = true;

            foreach (var inputcheck in input.InputChecks)
            {
                var check = await this.db.CheckListsChecks.FirstOrDefaultAsync(clc => clc.CheckId == inputcheck.Id && clc.CheckListId == device.CheckList.Id);

                check.Condition = inputcheck.Condition;

                if (check.Condition == null)
                {
                    isAllChecked = false;
                }

                if (check.Description == null && inputcheck.Description != null)
                {
                    check.Description = inputcheck.Description;
                }
            }

            if (isAllChecked == true)
            {
                device.StatusId = status;
            }

            await this.db.SaveChangesAsync();
        }

        public async Task CreateAsync(DeviceCreateInputModel input)
        {
            var condition = await this.db.Conditions.FirstOrDefaultAsync(c => !c.IsDeleted && c.Name == "Преглежда се");
            var status = await this.db.Status.FirstOrDefaultAsync(c => !c.IsDeleted && c.Name == "За проверка");
            var checksCount = this.db.Checks.Count();

            var device = new Device
            {
                CreatedOn = DateTime.Now,
                DeviceModelId = input.DeviceModelId,
                Color = input.Color,
                Memory = input.Memory,
                Seller = input.Seller,
                ConditionId = condition.Id,
                StatusId = status.Id,

            };

            var checkList = new CheckList
            {
                Devices = device,
            };

            var checkListChecks = new List<CheckListsChecks>();

            for (int i = 1; i <= checksCount; i++)
            {
                var checkListCheck = new CheckListsChecks { CheckList = checkList, CheckId = i };
                checkListChecks.Add(checkListCheck);
            }

            await this.db.Devices.AddAsync(device);
            await this.db.CheckList.AddAsync(checkList);
            await this.db.CheckListsChecks.AddRangeAsync(checkListChecks);
            await this.db.SaveChangesAsync();
        }

        public async Task<List<DevicesListingViewModel>> GetAllInspectedAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "Проверен")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task ChangeStatusByIdAsync(int id, int statusId)
        {
            var queryable = await this.db.Devices
                .Where(p => p.Id == id && !p.IsDeleted)
                .FirstOrDefaultAsync();

            if (queryable.StatusId != statusId)
            {
                queryable.ModifiedOn = DateTime.Now;
            }

            queryable.StatusId = statusId;


            await this.db.SaveChangesAsync();
        }

        public async Task<List<DevicesListingViewModel>> GetAllInSaleAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "За продажба")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllNotBayedAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "Незакупен")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllComplaintAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "Рекламация")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllInRepairAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "В ремонт")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllArchiveAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "Архив")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }

        public async Task<List<DevicesListingViewModel>> GetAllOutletAsync()
        {
            var querable = await this.db.Devices.Include(d => d.DeviceModel).ThenInclude(dm => dm.Brand)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(d => !d.IsDeleted && d.Status.Name == "Outlet")
                .ToListAsync();

            var devices = new List<DevicesListingViewModel>();

            foreach (var item in querable)
            {
                var device = new DevicesListingViewModel
                {
                    Id = item.Id,
                    Brand = item.DeviceModel.Brand.Name,
                    DeviceModel = item.DeviceModel.Name,
                    Imei = item.Imei,
                    Color = item.Color,
                    Memory = item.Memory,
                    Seller = item.Seller,
                    CreatedOn = item.ModifiedOn ?? DateTime.Now,
                };

                devices.Add(device);
            }

            return devices;
        }
    }
}

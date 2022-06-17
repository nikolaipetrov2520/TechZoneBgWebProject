namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Brands;
    using TechZoneBgWebProject.Services.Checks;
    using TechZoneBgWebProject.Services.Conditions;
    using TechZoneBgWebProject.Services.Devices;
    using TechZoneBgWebProject.Services.DevicesModels;
    using TechZoneBgWebProject.Services.Statuses;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DevicesController : BaseController
    {
        private readonly IDevicesService devicesService;
        private readonly IBrandsService brandsService;
        private readonly IConditionsService conditionsService;
        private readonly IChecksService checksService;
        private readonly IStatusesService statusesService;
        private readonly IDevicesModelsService devicesModelsService;

        public DevicesController(
            IDevicesService devicesService,
            IBrandsService brandsService,
            IConditionsService conditionsService,
            IChecksService checksService,
            IStatusesService statusesService,
            IDevicesModelsService devicesModelsService)
        {
            this.devicesService = devicesService;
            this.brandsService = brandsService;
            this.conditionsService = conditionsService;
            this.checksService = checksService;
            this.statusesService = statusesService;
            this.devicesModelsService = devicesModelsService;
        }

        public async Task<IActionResult> All()
        {
            var devices = await this.devicesService.GetAllAsync();

            if (devices == null)
            {
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new DeviceCreateInputModel
            {
                Brands = await this.brandsService.GetAllAsync<DevicesBrandsDetailsViewModel>(),
                DeviceModels = await this.devicesModelsService.GetAllAsync<DevicesModelsDetailsViewModel>(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DeviceCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Brands = await this.brandsService.GetAllAsync<DevicesBrandsDetailsViewModel>();
                input.DeviceModels = await this.devicesModelsService.GetAllAsync<DevicesModelsDetailsViewModel>();

                return this.View(input);
            }

            await this.devicesService.CreateAsync(input);

            return this.RedirectToAction("Inspecting");
        }

        public async Task<IActionResult> Inspecting()
        {
            var devices = await this.devicesService.GetAllInspectingAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Inspect(int id)
        {
            var device = await this.devicesService.GetNotInspectedByIdAsync(id);

            if (device == null)
            {
                return this.NotFound();
            }

            device.Conditions = await this.conditionsService.GetAllAsync<DevicesConditionsDetailsViewModel>();
            device.Status = await this.statusesService.GetAllAsync<DevicesStatusDetailsViewModel>();
            device.Checks = await this.checksService.GetAllAsync<DevicesChecksDetailsViewModel>(id);

            return this.View(device);
        }

        [HttpPost]
        public async Task<IActionResult> Inspect(DeviceNotInspectedImputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                var checks = input.InputChecks;
                input = await this.devicesService.GetNotInspectedByIdAsync(input.Id);
                input.Conditions = await this.conditionsService.GetAllAsync<DevicesConditionsDetailsViewModel>();
                input.Status = await this.statusesService.GetAllAsync<DevicesStatusDetailsViewModel>();
                input.Checks = checks;

                return this.View(input);
            }

            await this.devicesService.InspectAsync(input, this.User.GetId());

            return this.RedirectToAction("Inspecting");
        }

        public async Task<IActionResult> Inspected()
        {
            var devices = await this.devicesService.GetAllInspectedAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Details(int id)
        {
            var device = await this.devicesService.GetByIdAsync(id);

            if (device == null)
            {
                return this.NotFound();
            }

            device.Status = await this.statusesService.GetAllAsync<DevicesStatusDetailsViewModel>();
            device.Checks = await this.checksService.GetAllAsync<DevicesChecksDetailsViewModel>(id);

            return this.View(device);
        }

        [HttpPost]
        public async Task<IActionResult> Details(DeviceDetailsViewModel input)
        {
            await this.devicesService.ChangeStatusByIdAsync(input.Id, input.StatusId);

            return this.RedirectToAction("Inspected");
        }

        public async Task<IActionResult> InSale()
        {
            var devices = await this.devicesService.GetAllInSaleAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> NotBayed()
        {
            var devices = await this.devicesService.GetAllNotBayedAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Complaint()
        {
            var devices = await this.devicesService.GetAllComplaintAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> InRepair()
        {
            var devices = await this.devicesService.GetAllInRepairAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Archive()
        {
            var devices = await this.devicesService.GetAllArchiveAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> Outlet()
        {
            var devices = await this.devicesService.GetAllOutletAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }
    }
}

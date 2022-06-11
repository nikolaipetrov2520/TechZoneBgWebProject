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
    using TechZoneBgWebProject.Services.Statuses;
    using TechZoneBgWebProject.Web.InputModels.Devices;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DevicesController : BaseController
    {
        private readonly IDevicesService devicesService;
        private readonly IBrandsService brandsService;
        private readonly IConditionsService conditionsService;
        private readonly IChecksService checksService;
        private readonly IStatusesService statusesService;

        public DevicesController(
            IDevicesService devicesService,
            IBrandsService brandsService,
            IConditionsService conditionsService,
            IChecksService checksService,
            IStatusesService statusesService)
        {
            this.devicesService = devicesService;
            this.brandsService = brandsService;
            this.conditionsService = conditionsService;
            this.checksService = checksService;
            this.statusesService = statusesService;
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
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DeviceCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Brands = await this.brandsService.GetAllAsync<DevicesBrandsDetailsViewModel>();

                return this.View(input);
            }

            return this.RedirectToAction("All");
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
    }
}

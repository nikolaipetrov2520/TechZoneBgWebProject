namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Brands;
    using TechZoneBgWebProject.Services.Devices;
    using TechZoneBgWebProject.Web.InputModels.Devices;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DevicesController : BaseController
    {
        private readonly IDevicesService devicesService;
        private readonly IBrandsService brandsService;

        public DevicesController(IDevicesService devicesService, IBrandsService brandsService)
        {
            this.devicesService = devicesService;
            this.brandsService = brandsService;
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
    }
}

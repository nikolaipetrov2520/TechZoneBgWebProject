namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Devices;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DevicesController : BaseController
    {
        private readonly IDevicesService devicesService;

        public DevicesController(IDevicesService devicesService)
        {
            this.devicesService = devicesService;
        }

        public async Task<IActionResult> All()
        {
            var devices = await this.devicesService.GetAllAsync();

            if (devices == null)
            {
            }

            return this.View(devices);
        }
    }
}

namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using DinkToPdf;
    using DinkToPdf.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Services.Brands;
    using TechZoneBgWebProject.Services.Checks;
    using TechZoneBgWebProject.Services.Conditions;
    using TechZoneBgWebProject.Services.Devices;
    using TechZoneBgWebProject.Services.DevicesModels;
    using TechZoneBgWebProject.Services.PDF;
    using TechZoneBgWebProject.Services.Statuses;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    [Authorize(Roles = GlobalConstants.Admin.AdministratorRoleName + "," + GlobalConstants.TechzoneBgEmployee.EmployeeRoleName + "," + GlobalConstants.SwypeEmployee.EmployeeRoleName)]
    public class DevicesController : BaseController
    {
        private readonly IDevicesService devicesService;
        private readonly IBrandsService brandsService;
        private readonly IConditionsService conditionsService;
        private readonly IChecksService checksService;
        private readonly IStatusesService statusesService;
        private readonly IDevicesModelsService devicesModelsService;
        private readonly ITemplateGenerator templateGenerator;
        private readonly IConverter converter;

        public DevicesController(
            IDevicesService devicesService,
            IBrandsService brandsService,
            IConditionsService conditionsService,
            IChecksService checksService,
            IStatusesService statusesService,
            IDevicesModelsService devicesModelsService,
            ITemplateGenerator templateGenerator,
            IConverter converter)
        {
            this.devicesService = devicesService;
            this.brandsService = brandsService;
            this.conditionsService = conditionsService;
            this.checksService = checksService;
            this.statusesService = statusesService;
            this.devicesModelsService = devicesModelsService;
            this.templateGenerator = templateGenerator;
            this.converter = converter;
        }

        public async Task<IActionResult> All(string search = null)
        {
            var devices = await this.devicesService.GetAllAsync(search);

            if (devices == null)
            {
                return this.NotFound();
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

        public async Task<IActionResult> Shooting()
        {
            var devices = await this.devicesService.GetAllShootingAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> StatusChanged()
        {
            var devices = await this.devicesService.GetAllStatusChangedAsync();

            if (devices == null)
            {
                return this.NotFound();
            }

            return this.View(devices);
        }

        public async Task<IActionResult> PDF(int id)
        {
            var device = await this.devicesService.GetByIdAsync(id);

            if (device == null)
            {
                return this.NotFound();
            }

            device.Status = await this.statusesService.GetAllAsync<DevicesStatusDetailsViewModel>();
            device.Checks = await this.checksService.GetAllAsync<DevicesChecksDetailsViewModel>(id);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Досие",
                Out = @$"{path}\Downloads\{device.DeviceModel}_{device.Imei}.pdf",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = this.templateGenerator.Generate(device),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\css", "site.min.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" },
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };

            this.converter.Convert(pdf);

            //return this.RedirectToAction($"Details", new { id = device.Id });
            //return this.PartialView(device);

            var stream = new FileStream(@$"{path}\Downloads\{device.DeviceModel}_{device.Imei}.pdf", FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");
        }
    }
}

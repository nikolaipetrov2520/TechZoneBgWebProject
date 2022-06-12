namespace TechZoneBgWebProject.Web.InputModels.Devices
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DeviceCreateInputModel
    {
        [Required]
        public int BrandId { get; set; }

        [Required]
        public int DeviceModelId { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Memory { get; set; }

        [Required]
        public string Seller { get; set; }

        public IEnumerable<DevicesBrandsDetailsViewModel> Brands { get; set; }

        public IEnumerable<DevicesModelsDetailsViewModel> DeviceModels { get; set; }
    }
}

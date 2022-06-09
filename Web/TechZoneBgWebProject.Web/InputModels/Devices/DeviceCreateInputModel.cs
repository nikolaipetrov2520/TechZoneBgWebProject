namespace TechZoneBgWebProject.Web.InputModels.Devices
{
    using System.ComponentModel.DataAnnotations;

    public class DeviceCreateInputModel
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string DeviceModel { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Memory { get; set; }

        [Required]
        public string Seller { get; set; }
    }
}

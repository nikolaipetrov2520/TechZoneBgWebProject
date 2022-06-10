namespace TechZoneBgWebProject.Web.ViewModels.Devices
{
    using System;

    public class DevicesListingViewModel
    {
        public int Id { get; set; }

        public string Imei { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Brand { get; set; }

        public string DeviceModel { get; set; }

        public string Color { get; set; }

        public string Memory { get; set; }

        public string Status { get; set; }

        public string Seller { get; set; }
    }
}

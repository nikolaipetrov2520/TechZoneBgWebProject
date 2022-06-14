namespace TechZoneBgWebProject.Web.ViewModels.Devices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DeviceDetailsViewModel
    {
        public int Id { get; set; }

        public string Condition { get; set; }

        public int StatusId { get; set; }

        public string Imei { get; set; }

        public string DeviceModel { get; set; }

        public string Color { get; set; }

        public string Memory { get; set; }

        public string Description { get; set; }

        public string Seller { get; set; }

        public string Repairs { get; set; }

        public IEnumerable<DevicesChecksDetailsViewModel> InputChecks { get; set; }

        public IEnumerable<DevicesConditionsDetailsViewModel> Conditions { get; set; }

        public IEnumerable<DevicesStatusDetailsViewModel> Status { get; set; }

        public IEnumerable<DevicesChecksDetailsViewModel> Checks { get; set; }

        public string Author { get; set; }
    }
}

namespace TechZoneBgWebProject.Web.ViewModels.Devices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class DeviceNotInspectedImputModel
    {
        public int Id { get; set; }

        public string Imei { get; set; }

        public string DeviceModel { get; set; }

        public string Color { get; set; }

        public string Memory { get; set; }

        public string Description { get; set; }

        public string Seller { get; set; }

        public IEnumerable<DevicesConditionsDetailsViewModel> Conditions { get; set; }

        public IEnumerable<DevicesStatusDetailsViewModel> Status { get; set; }

        public IEnumerable<DevicesChecksDetailsViewModel> Checks { get; set; }

        public ApplicationUser Author { get; set; }
    }
}

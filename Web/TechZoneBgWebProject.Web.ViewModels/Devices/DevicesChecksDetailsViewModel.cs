namespace TechZoneBgWebProject.Web.ViewModels.Devices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DevicesChecksDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool? Condition { get; set; }

        public string Description { get; set; }
    }
}

namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class DeviceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public ICollection<Device> Devices { get; set; } = new HashSet<Device>();
    }
}

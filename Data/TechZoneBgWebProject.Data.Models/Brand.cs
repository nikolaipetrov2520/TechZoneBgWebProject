namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<DeviceModel> DevicesModels { get; set; } = new HashSet<DeviceModel>();
    }
}

namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class DevicesModels
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BrandId { get; set; }

        public Brands Brand { get; set; }

        public IEnumerable<Devices> Devices { get; set; }
    }
}

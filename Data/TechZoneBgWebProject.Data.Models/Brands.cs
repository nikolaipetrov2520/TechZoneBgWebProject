namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class Brands
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<DevicesModels> DevicesModels { get; set; }
    }
}

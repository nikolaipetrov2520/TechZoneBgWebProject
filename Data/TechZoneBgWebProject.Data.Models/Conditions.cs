namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class Conditions
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Devices> Devices { get; set; }
    }
}

namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class CheckList
    {
        public int Id { get; set; }

        public IEnumerable<Checks> Checks { get; set; }

        public IEnumerable<Devices> Devices { get; set; }
    }
}

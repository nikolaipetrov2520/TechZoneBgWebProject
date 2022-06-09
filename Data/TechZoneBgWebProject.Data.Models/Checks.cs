namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class Checks
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<CheckListsChecks> CheckListChecks { get; set; }
    }
}

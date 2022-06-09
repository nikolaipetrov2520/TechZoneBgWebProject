namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class Check
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CheckListsChecks> CheckListChecks { get; set; } = new HashSet<CheckListsChecks>();
    }
}

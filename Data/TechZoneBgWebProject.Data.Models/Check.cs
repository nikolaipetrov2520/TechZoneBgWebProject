namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Check
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<CheckListsChecks> CheckListChecks { get; set; } = new HashSet<CheckListsChecks>();
    }
}

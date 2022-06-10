namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class CheckList
    {
        public int Id { get; set; }

        public ICollection<CheckListsChecks> CheckListChecks { get; set; } = new HashSet<CheckListsChecks>();

        public int DeviceId { get; set; }

        public Device Devices { get; set; }
    }
}

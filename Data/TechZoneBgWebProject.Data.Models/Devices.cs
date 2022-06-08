namespace TechZoneBgWebProject.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Devices
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string Imei { get; set; }

        public int DeviceModelId { get; set; }

        public DevicesModels DeviceModel { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public int ConditionId { get; set; }

        public Conditions Condition { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }

        public string CreatedFrom { get; set; }

        public IEnumerable<CheckList> CheckLists { get; set; }

        public ApplicationUser Author { get; set; }

    }
}

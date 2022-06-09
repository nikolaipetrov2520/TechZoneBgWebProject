using System;
using System.Collections.Generic;
using System.Text;

namespace TechZoneBgWebProject.Data.Models
{
    public class CheckListsChecks
    {
        public CheckList CheckList { get; set; }

        public int CheckListId { get; set; }

        public Check Check { get; set; }

        public int CheckId { get; set; }

        public bool? Condition { get; set; }

        public string Description { get; set; }
    }
}

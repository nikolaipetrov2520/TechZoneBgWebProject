namespace TechZoneBgWebProject.Data.Models
{
    public class Checks
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Condition { get; set; }

        public string Description { get; set; }

        public int CheckListId { get; set; }

        public CheckList CheckList { get; set; }
    }
}

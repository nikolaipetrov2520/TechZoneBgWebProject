namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System.Collections.Generic;

    public class UsersThreadsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Likes { get; set; }

        public int RepliesCount { get; set; }

        public int Views { get; set; }

        public string Activity { get; set; }

        public bool IsPinned { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<UsersThreadsTagsViewModel> Tags { get; set; }
    }
}

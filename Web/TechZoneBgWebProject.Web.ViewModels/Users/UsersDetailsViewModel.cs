namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System.Collections.Generic;

    public class UsersDetailsViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicture { get; set; }

        public int Points { get; set; }

        public bool IsFollowed { get; set; }

        public int FollowersCount { get; set; }

        public int FollowingCount { get; set; }

        public IEnumerable<UsersThreadsViewModel> Threads { get; set; }

        public IEnumerable<UsersRepliesViewModel> Replies { get; set; }

        public IEnumerable<UsersViewModel> Followers { get; set; }

        public IEnumerable<UsersViewModel> Following { get; set; }
    }
}

namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsersOrdersViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicture { get; set; }

        public int ExecutingCount { get; set; }

        public IEnumerable<UsersExecutedViewModel> Executed { get; set; }

        public IEnumerable<UsersExecutedViewModel> Executing { get; set; }
    }
}

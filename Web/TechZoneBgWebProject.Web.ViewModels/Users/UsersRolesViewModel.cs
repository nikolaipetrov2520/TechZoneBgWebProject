namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TechZoneBgWebProject.Web.ViewModels.Roles;

    public class UsersRolesViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public ICollection<RolesUsersViewModel> Roles { get; set; }
    }
}

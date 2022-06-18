namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsersRolesInfoViewModel
    {
        public string Search { get; set; }

        public IEnumerable<UsersRolesViewModel> Users { get; set; }
    }
}

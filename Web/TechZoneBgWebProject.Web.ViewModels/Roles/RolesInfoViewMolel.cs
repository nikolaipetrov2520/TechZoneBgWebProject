namespace TechZoneBgWebProject.Web.ViewModels.Roles
{
    using System.Collections.Generic;

    public class RolesInfoViewMolel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public IEnumerable<RolesViewModel> Roles { get; set; }
    }
}

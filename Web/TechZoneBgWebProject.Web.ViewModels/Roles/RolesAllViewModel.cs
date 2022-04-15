namespace TechZoneBgWebProject.Web.ViewModels.Roles
{
    using System.Collections.Generic;

    public class RolesAllViewModel
    {
        public string Search { get; set; }

        public string Id { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public IEnumerable<RolesViewModel> Roles { get; set; }

        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public int NextPage
        {
            get
            {
                if (this.PageIndex >= this.TotalPages)
                {
                    return 1;
                }

                return this.PageIndex + 1;
            }
        }

        public int PreviousPage
        {
            get
            {
                if (this.PageIndex <= 1)
                {
                    return this.TotalPages;
                }

                return this.PageIndex - 1;
            }
        }
    }
}
namespace TechZoneBgWebProject.Web.ViewModels.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TechZoneBgWebProject.Web.ViewModels.Carts;

    public class UsersExecutedViewModel
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string Comment { get; set; }

        public decimal Sum { get; set; }

        public string Address { get; set; }

        public string AuthorId { get; set; }

        public IEnumerable<CartProductsViewModel> Products { get; set; }
    }
}

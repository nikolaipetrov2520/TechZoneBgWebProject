namespace TechZoneBgWebProject.Web.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;
    using TechZoneBgWebProject.Web.ViewModels.Carts;

    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Time { get; set; }

        public string Comment { get; set; }

        public decimal Sum { get; set; }

        public string Address { get; set; }

        public IEnumerable<CartProductsViewModel> Products { get; set; }
    }
}

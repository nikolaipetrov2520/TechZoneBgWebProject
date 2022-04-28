namespace TechZoneBgWebProject.Web.ViewModels.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CartsListingViewModel
    {
        public int Id { get; set; }

        public IEnumerable<CartProductsViewModel> Products { get; set; }

    }
}

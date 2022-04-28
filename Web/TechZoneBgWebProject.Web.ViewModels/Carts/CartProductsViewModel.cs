namespace TechZoneBgWebProject.Web.ViewModels.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CartProductsViewModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Barcode { get; set; }

        public string Pic { get; set; }

        public int ProductId { get; set; }
    }
}

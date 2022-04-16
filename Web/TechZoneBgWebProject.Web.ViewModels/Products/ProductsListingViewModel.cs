using System;
using System.Collections.Generic;
using System.Text;

namespace TechZoneBgWebProject.Web.ViewModels.Products
{
    public class ProductsListingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }

        public string Barcode { get; set; }

        public string Pic { get; set; }

        public int ProductId { get; set; }

        public bool InStock { get; set; }


    }
}

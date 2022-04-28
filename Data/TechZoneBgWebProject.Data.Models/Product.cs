namespace TechZoneBgWebProject.Data.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Barcode { get; set; }

        public string Pic { get; set; }

        public int ProductId { get; set; }

        public bool InStock { get; set; }

        public ICollection<CartProduct> Carts { get; set; } = new HashSet<CartProduct>();
    }
}

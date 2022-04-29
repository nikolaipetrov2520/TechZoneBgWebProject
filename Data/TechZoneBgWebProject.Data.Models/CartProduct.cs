namespace TechZoneBgWebProject.Data.Models
{
    public class CartProduct
    {
        public int CartId { get; set; }

        public Cart Cart { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public bool IsDeleted { get; set; }
    }
}

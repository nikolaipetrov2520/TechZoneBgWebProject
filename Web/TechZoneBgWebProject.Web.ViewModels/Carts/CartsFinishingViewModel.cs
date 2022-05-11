namespace TechZoneBgWebProject.Web.ViewModels.Carts
{
    using System.Collections.Generic;

    public class CartsFinishingViewModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public IEnumerable<CartProductsViewModel> Products { get; set; }
    }
}

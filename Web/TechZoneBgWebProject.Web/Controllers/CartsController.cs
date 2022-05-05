namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Carts;

    public class CartsController : BaseController
    {

        private const int PostsPerPage = 36;

        private readonly ICartsService cartsService;
        private readonly IProductsService productsService;

        public CartsController(ICartsService cartsService, IProductsService productsService)
        {
            this.cartsService = cartsService;
            this.productsService = productsService;
        }

        public async Task<IActionResult> Cart()
        {
            var cart = await this.cartsService.GetUnfinishedCartAsync<CartsListingViewModel>(this.User.GetId());

            if (cart == null)
            {
                cart = new CartsListingViewModel
                {
                    Id = 0,
                };
            }

            cart.Products = await this.productsService.GetProductsBiCartIdAsync<CartProductsViewModel>(cart.Id);

            return this.View(cart);
        }

        public async Task<IActionResult> Remove(int productId, int cartId)
        {
            await this.cartsService.RemoveProductById(productId, cartId);
            return this.Redirect(nameof(this.Cart));
        }
    }
}

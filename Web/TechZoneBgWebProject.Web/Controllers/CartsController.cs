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

            return this.View(cart);
        }
    }
}

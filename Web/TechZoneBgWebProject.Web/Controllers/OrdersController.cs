namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Web.ViewModels.Carts;
    using TechZoneBgWebProject.Web.ViewModels.Orders;

    [Authorize(Roles = GlobalConstants.Admin.AdministratorRoleName + "," + GlobalConstants.TechzoneBgEmployee.EmployeeRoleName)]
    public class OrdersController : BaseController
    {
        private const int CartsPerPage = 10;

        private readonly ICartsService cartsService;
        private readonly IProductsService productsService;

        public OrdersController(ICartsService cartsService, IProductsService productsService)
        {
            this.cartsService = cartsService;
            this.productsService = productsService;
        }

        public async Task<IActionResult> All(int page = 1)
        {
            var skip = (page - 1) * CartsPerPage;
            var count = await this.cartsService.GetCountAsync();
            var carts = await this.cartsService.GetAllAsync(skip, CartsPerPage);

            var viewModel = new OrdersAllViewModel
            {
                Carts = carts,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling(count / (decimal)CartsPerPage),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var cart = await this.cartsService.GetFinishedCartByIdAsync(id);

            if (cart == null)
            {
                cart = new OrderDetailsViewModel
                {
                    Id = 0,
                };
            }

            cart.Products = await this.productsService.GetProductsBiCartIdAsync<CartProductsViewModel>(cart.Id);

            return this.View(cart);
        }

        public async Task<IActionResult> Order(int id)
        {
            await this.cartsService.OrderByIdAsync(id);
            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Send(int id)
        {
            await this.cartsService.SendByIdAsync(id);
            return this.RedirectToAction("All");
        }
    }
}

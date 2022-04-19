namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Web.ViewModels.Products;

    public class ProductsController : BaseController
    {
        private const int PostsPerPage = 18;

        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All(int page = 1, string search = null)
        {
            var skip = (page - 1) * PostsPerPage;
            var count = await this.productsService.GetCountAsync(search);
            var products = await this.productsService.GetAllAsync<ProductsListingViewModel>(search, skip, PostsPerPage);

            var viewModel = new ProductAllViewModel
            {
                Products = products,
                Search = search,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling(count / (decimal)PostsPerPage),
            };

            return this.View(viewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var product = await this.productsService.GetByIdAsync<ProductDetailsViewModel>(id);
            if (product == null)
            {
                return this.NotFound();
            }

            return this.View(product);
        }
    }
}

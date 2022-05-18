namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Web.ViewModels.Products;

    [Route("api/products")]
    public class SwipeApi : ApiController
    {
        private readonly IProductsService productsService;

        public SwipeApi(IProductsService productsService)
            => this.productsService = productsService;

        [HttpGet("swipe")]
        public async Task<IEnumerable<ProductsListModel>> GetProducts()
        {
            var result = await this.productsService.GetAllProductsAsync<ProductsListModel>();

            return result;
        }
    }
}

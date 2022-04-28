namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Carts;

    public class CartsController : BaseController
    {

        private const int PostsPerPage = 36;

        private readonly ICartsService cartsService;

        public CartsController(ICartsService cartsService)
        {
            this.cartsService = cartsService;
        }

        //public async Task<IActionResult> Cart()
        //{
        //    var carts = await this.cartsService.GetUnfinishedCartAsync(this.User.GetId());

        //    if (carts.Count > 0)
        //    {
        //        var cart = carts[0];
        //        viewModel = new CartsListingViewModel
        //        {
        //            Id = cart.Id,
                    
        //        };
        //    }

        //    return this.View(viewModel);
        //}
    }
}

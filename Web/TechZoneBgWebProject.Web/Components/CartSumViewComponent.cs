namespace TechZoneBgWebProject.Web.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Carts;

    [ViewComponent(Name = "CartSum")]
    public class CartSumViewComponent : ViewComponent
    {
        private readonly ICartsService cartsService;
        private readonly IUsersService usersService;

        public CartSumViewComponent(ICartsService cartsService, IUsersService usersService)
        {
            this.cartsService = cartsService;
            this.usersService = usersService;
        }

        public IViewComponentResult Invoke()
        {
            var id = this.UserClaimsPrincipal.GetId();
            var sum = this.cartsService.GetSum(id);
            var viewModel = new CartsSumViewModel
            {
                Sum = sum,
            };

            return this.View(viewModel);
        }
    }
}

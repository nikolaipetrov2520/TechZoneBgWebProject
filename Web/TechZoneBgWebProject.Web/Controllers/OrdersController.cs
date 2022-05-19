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
    using TechZoneBgWebProject.Web.ViewModels.Orders;

    [Authorize(Roles = GlobalConstants.Admin.AdministratorRoleName + "," + GlobalConstants.TechzoneBgEmployee.EmployeeRoleName)]
    public class OrdersController : BaseController
    {
        private const int CartsPerPage = 10;

        private readonly ICartsService cartsService;

        public OrdersController(ICartsService cartsService)
        {
            this.cartsService = cartsService;
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
    }
}

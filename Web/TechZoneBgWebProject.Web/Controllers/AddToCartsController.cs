namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.InputModels.Cart;
    using TechZoneBgWebProject.Web.ViewModels.Carts;

    [Route("api/addCart")]
    public class AddToCartsController : ApiController
    {
        private readonly ICartsService cartsService;

        public AddToCartsController(ICartsService cartsService)
            => this.cartsService = cartsService;

        [HttpPost("add")]
        public async Task<ActionResult<CartAddModel>> AddToCart(InputCartModel input)
        {
            int id = input.Id;
            int quantity = input.Quantity;
            string userId = this.User.GetId();

            string result = await this.cartsService.AddCartAsync(id, quantity, userId);

            var model = new CartAddModel
            {
                Sum = result,
            };

            return model;
        }

        [HttpPost("update")]
        public async Task<ActionResult<CartAddModel>> UpdateCart(InputCartModel input)
        {
            int id = input.Id;
            int quantity = input.Quantity;
            string userId = this.User.GetId();

            string result = await this.cartsService.UpdateCartAsync(id, quantity, userId);

            var model = new CartAddModel
            {
                Sum = result,
            };

            return model;
        }
    }
}

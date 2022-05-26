namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Services.Replies;
    using TechZoneBgWebProject.Services.Tags;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels.Carts;
    using TechZoneBgWebProject.Web.ViewModels.Messages;
    using TechZoneBgWebProject.Web.ViewModels.Users;

    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly IPostsService postsService;
        private readonly ITagsService tagsService;
        private readonly IRepliesService repliesService;
        private readonly ICartsService cartsService;
        private readonly IProductsService productsService;

        public UsersController(
            IRepliesService repliesService,
            ITagsService tagsService,
            IPostsService postsService,
            IUsersService usersService,
            ICartsService cartsService,
            IProductsService productsService)
        {
            this.repliesService = repliesService;
            this.tagsService = tagsService;
            this.postsService = postsService;
            this.usersService = usersService;
            this.cartsService = cartsService;
            this.productsService = productsService;
        }

        public async Task<IActionResult> Executing(string id)
        {
            var user = await this.usersService.GetOrdersByIdAsync<UsersOrdersViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Executing = await this.cartsService.GetExecutingCartAsync(id);

            return this.View(user);
        }

        public async Task<IActionResult> Executed(string id)
        {
            var user = await this.usersService.GetOrdersByIdAsync<UsersOrdersViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Executed = await this.cartsService.GetExecutedCartAsync(id);

            return this.View(user);
        }

        public async Task<IActionResult> Details(int id)
        {
            var cart = await this.cartsService.GetCartDetailsByIdAsync(id);

            if (cart == null)
            {
                cart = new UsersExecutedViewModel
                {
                    Id = 0,
                };
            }

            cart.Products = await this.productsService.GetProductsBiCartIdAsync<CartProductsViewModel>(cart.Id);

            return this.View(cart);
        }
    }
}

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

        public async Task<IActionResult> Threads(string id)
        {
            var user = await this.usersService.GetByIdAsync<UsersDetailsViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Threads = await this.postsService.GetAllByUserIdAsync<UsersThreadsViewModel>(id);
            foreach (var thread in user.Threads)
            {
                thread.Activity = await this.postsService.GetLatestActivityByIdAsync(thread.Id);
                thread.Tags = await this.tagsService.GetAllByPostIdAsync<UsersThreadsTagsViewModel>(thread.Id);
            }

            return this.View(user);
        }

        public async Task<IActionResult> Executing(string id)
        {
            var user = await this.usersService.GetOrdersByIdAsync<UsersOrdersViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Executing = await this.cartsService.GetExecutingCartAsync(id);

            foreach (var item in user.Executing)
            {
                item.Products = await this.productsService.GetProductsBiCartIdAsync<CartProductsViewModel>(item.Id);
            }

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

            foreach (var item in user.Executed)
            {
                item.Products = await this.productsService.GetProductsBiCartIdAsync<CartProductsViewModel>(item.Id);
            }

            return this.View(user);
        }

        public async Task<IActionResult> Following(string id)
        {
            var user = await this.usersService.GetByIdAsync<UsersDetailsViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Following = await this.usersService.GetFollowingAsync<UsersViewModel>(id);

            return this.View(user);
        }

        public async Task<IActionResult> Followers(string id)
        {
            var user = await this.usersService.GetByIdAsync<UsersDetailsViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Followers = await this.usersService.GetFollowersAsync<UsersViewModel>(id);

            return this.View(user);
        }

        public async Task<IActionResult> Follow(string id)
        {
            var followerId = this.User.GetId();
            if (followerId == id)
            {
                return this.BadRequest();
            }

            var isFollowed = await this.usersService.FollowAsync(id, followerId);

            return this.Ok(isFollowed);
        }

        public async Task<IActionResult> Replies(string id)
        {
            var user = await this.usersService.GetByIdAsync<UsersDetailsViewModel>(id);
            if (user == null)
            {
                return this.NotFound();
            }

            user.Replies = await this.repliesService.GetAllByUserIdAsync<UsersRepliesViewModel>(id);

            return this.View(user);
        }
    }
}

namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Categories;
    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Tags;
    using TechZoneBgWebProject.Web.ViewModels.Categories;
    using TechZoneBgWebProject.Web.ViewModels.Posts;

    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly IPostsService postsService;
        private readonly ITagsService tagsService;

        public CategoriesController(
            ITagsService tagsService,
            IPostsService postsService,
            ICategoriesService categoriesService)
        {
            this.tagsService = tagsService;
            this.postsService = postsService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> All(string search = null)
        {
            var categories = await this.categoriesService.GetAllAsync<CategoriesInfoViewModel>(search);
            var viewModel = new CategoriesAllViewModel
            {
                Search = search,
                Categories = categories,
            };

            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id, string search = null)
        {
            var category = await this.categoriesService.GetByIdAsync<CategoriesInfoViewModel>(id);
            if (category == null)
            {
                return this.NotFound();
            }

            var posts = await this.postsService.GetAllByCategoryIdAsync<PostsListingViewModel>(id, search);
            foreach (var post in posts)
            {
                post.Activity = await this.postsService.GetLatestActivityByIdAsync(post.Id);
                post.Tags = await this.tagsService.GetAllByPostIdAsync<PostsTagsViewModel>(post.Id);
            }

            var viewModel = new CategoriesDetailsViewModel
            {
                Search = search,
                Category = category,
                Posts = posts,
            };

            return this.View(viewModel);
        }
    }
}

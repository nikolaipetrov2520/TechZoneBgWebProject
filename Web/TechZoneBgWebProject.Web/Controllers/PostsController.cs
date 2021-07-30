namespace TechZoneBgWebProject.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Tags;
    using TechZoneBgWebProject.Web.ViewModels.Posts;

    public class PostsController : BaseController
    {
        private const int PostsPerPage = 6;

        private readonly ITagsService tagsService;
        private readonly IPostsService postsService;

        public PostsController(IPostsService postsService, ITagsService tagsService)
        {
            this.postsService = postsService;
            this.tagsService = tagsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Trending(int page = 1, string search = null)
        {
            var skip = (page - 1) * PostsPerPage;
            var count = await this.postsService.GetCountAsync(search);
            var posts = await this.postsService.GetAllAsync<PostsListingViewModel>(search, skip, PostsPerPage);
            foreach (var post in posts)
            {
                post.Activity = await this.postsService.GetLatestActivityByIdAsync(post.Id);
                post.Tags = await this.tagsService.GetAllByPostIdAsync<PostsTagsViewModel>(post.Id);
            }

            var viewModel = new PostsAllViewModel
            {
                Posts = posts,
                Search = search,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling(count / (decimal)PostsPerPage),
            };

            return this.View(viewModel);
        }
    }
}

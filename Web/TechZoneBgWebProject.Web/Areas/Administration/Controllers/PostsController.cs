namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Posts;

    public class PostsController : AdministrationController
    {
        private readonly IPostsService postsService;

        public PostsController(IPostsService postsService)
        {
            this.postsService = postsService;
        }

        public async Task<IActionResult> Pin(int id)
        {
            var isExisting = await this.postsService.IsExistingAsync(id);
            if (!isExisting)
            {
                return this.NotFound();
            }

            var isPinned = await this.postsService.PinAsync(id);

            return this.Ok(isPinned);
        }
    }
}

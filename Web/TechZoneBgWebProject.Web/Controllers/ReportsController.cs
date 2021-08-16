namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Reports;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.InputModels.Reports;

    [Authorize]
    public class ReportsController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IReportsService reportsService;

        public ReportsController(
            IPostsService postsService,
            IReportsService reportsService)
        {
            this.postsService = postsService;
            this.reportsService = reportsService;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = await this.postsService.GetByIdAsync<ReportsInputModel>(id);
            if (post == null)
            {
                return this.NotFound();
            }

            post.Description = string.Empty;
            return this.View(post);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReportsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.reportsService.CreateAsync(input.Description, input.Id, this.User.GetId());

            return this.RedirectToAction("Details", "Posts", new { id = input.Id });
        }
    }
}

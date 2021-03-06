namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Tags;
    using TechZoneBgWebProject.Web.InputModels.Tags;
    using TechZoneBgWebProject.Web.ViewModels.Tags;

    public class TagsController : AdministrationController
    {
        private const int TagsPerPage = 12;

        private readonly ITagsService tagsService;

        public TagsController(ITagsService tagsService)
        {
            this.tagsService = tagsService;
        }

        public async Task<IActionResult> All(int page = 1, string search = null)
        {
            var skip = (page - 1) * TagsPerPage;
            var count = await this.tagsService.GetCountAsync(search);
            var tags = await this.tagsService.GetAllAsync<TagsInfoViewModel>(search, skip, TagsPerPage);
            var viewModel = new TagsAllViewModel
            {
                Tags = tags,
                Search = search,
                PageIndex = page,
                TotalPages = (int)Math.Ceiling(count / (decimal)TagsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult Create() => this.View();

        [HttpPost]
        public async Task<IActionResult> Create(TagsCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.tagsService.CreateAsync(input.Name);

            return this.RedirectToAction(nameof(this.All));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var isExisting = await this.tagsService.IsExistingAsync(id);
            if (!isExisting)
            {
                return this.NotFound();
            }

            await this.tagsService.DeleteAsync(id);

            return this.RedirectToAction(nameof(this.All));
        }
    }
}

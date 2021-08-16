namespace TechZoneBgWebProject.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Reports;
    using TechZoneBgWebProject.Web.ViewModels.Reports;

    public class PostReportsController : AdministrationController
    {
        private readonly IReportsService reportsService;

        public PostReportsController(IReportsService reportsService)
        {
            this.reportsService = reportsService;
        }

        public async Task<IActionResult> All()
        {
            var viewModel = new PostReportAllViewModel
            {
                PostReports = await this.reportsService.GetAllAsync<PostReportsListingViewModel>(),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var postReport = await this.reportsService.GetByIdAsync<PostReportsDetailsViewModel>(id);
            if (postReport == null)
            {
                return this.NotFound();
            }

            return this.View(postReport);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await this.reportsService.DeleteAsync(id);
            if (!deleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(this.All));
        }
    }
}

﻿namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Services.Replies;
    using TechZoneBgWebProject.Services.Reports;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.InputModels.ReplyReports;

    [Authorize]
    public class ReplyReportsController : Controller
    {
        private readonly IRepliesService repliesService;
        private readonly IReplyReportsService replyReportsService;

        public ReplyReportsController(
            IRepliesService repliesService,
            IReplyReportsService replyReportsService)
        {
            this.repliesService = repliesService;
            this.replyReportsService = replyReportsService;
        }

        public async Task<IActionResult> Create(int id)
        {
            var reply = await this.repliesService.GetByIdAsync<ReplyReportsInputModel>(id);
            if (reply == null)
            {
                return this.NotFound();
            }

            reply.Description = string.Empty;
            return this.View(reply);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReplyReportsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.replyReportsService.CreateAsync(input.Description, input.Id, this.User.GetId());

            return this.RedirectToAction("Details", "Replies", new { id = input.Id });
        }
    }
}

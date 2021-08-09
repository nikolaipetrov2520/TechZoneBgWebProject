namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Reactions;
    using TechZoneBgWebProject.Services.Reactions.Models;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;

    [Route("api/reply-reactions")]
    public class ReplyReactionsController : ApiController
    {
        private readonly IReplyReactionsService replyReactionsService;

        public ReplyReactionsController(IReplyReactionsService replyReactionsService)
            => this.replyReactionsService = replyReactionsService;

        [Route("like/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Like(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Like,
                replyId,
                this.User.GetId());

        [Route("dislike/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Dislike(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Dislike,
                replyId,
                this.User.GetId());
    }
}

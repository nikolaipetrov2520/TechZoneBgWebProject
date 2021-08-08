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

        [Route("love/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Love(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Love,
                replyId,
                this.User.GetId());

        [Route("haha/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Haha(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Haha,
                replyId,
                this.User.GetId());

        [Route("wow/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Wow(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Wow,
                replyId,
                this.User.GetId());

        [Route("sad/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Sad(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Sad,
                replyId,
                this.User.GetId());

        [Route("angry/{replyId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Angry(int replyId)
            => await this.replyReactionsService.ReactAsync(
                ReactionType.Angry,
                replyId,
                this.User.GetId());
    }
}

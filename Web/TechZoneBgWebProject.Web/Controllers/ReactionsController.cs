namespace TechZoneBgWebProject.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Reactions;
    using TechZoneBgWebProject.Services.Reactions.Models;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;

    [Route("api/post-reactions")]
    public class ReactionsController : ApiController
    {
        private readonly IReactionsService reactionsService;

        public ReactionsController(IReactionsService reactionsService)
            => this.reactionsService = reactionsService;

        [Route("like/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Like(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Like,
                postId,
                this.User.GetId());

        [Route("love/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Love(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Love,
                postId,
                this.User.GetId());

        [Route("haha/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Haha(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Haha,
                postId,
                this.User.GetId());

        [Route("wow/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Wow(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Wow,
                postId,
                this.User.GetId());

        [Route("sad/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Sad(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Sad,
                postId,
                this.User.GetId());

        [Route("angry/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Angry(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Angry,
                postId,
                this.User.GetId());
    }
}

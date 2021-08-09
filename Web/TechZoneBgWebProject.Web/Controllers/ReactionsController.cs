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

        [Route("dislike/{postId}")]
        public async Task<ActionResult<ReactionsCountServiceModel>> Dislike(int postId)
            => await this.reactionsService.ReactAsync(
                ReactionType.Dislike,
                postId,
                this.User.GetId());
    }
}

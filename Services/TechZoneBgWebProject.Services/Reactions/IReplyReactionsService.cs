namespace TechZoneBgWebProject.Services.Reactions
{
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Reactions.Models;

    public interface IReplyReactionsService
    {
        Task<ReactionsCountServiceModel> ReactAsync(ReactionType reactionType, int replyId, string authorId);

        Task<int> GetTotalCountAsync();
    }
}

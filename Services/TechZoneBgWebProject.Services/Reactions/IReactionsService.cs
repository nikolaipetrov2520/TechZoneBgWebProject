namespace TechZoneBgWebProject.Services.Reactions
{
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Reactions.Models;

    public interface IReactionsService
    {
        Task<ReactionsCountServiceModel> ReactAsync(ReactionType reactionType, int postId, string authorId);

        Task<int> GetTotalCountAsync();

    }
}

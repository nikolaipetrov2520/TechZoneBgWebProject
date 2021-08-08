﻿namespace TechZoneBgWebProject.Services.Reactions
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Reactions.Models;

    public class ReplyReactionsService : IReplyReactionsService
    {
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly ApplicationDbContext db;

        public ReplyReactionsService(IDateTimeProvider dateTimeProvider, ApplicationDbContext db)
        {
            this.dateTimeProvider = dateTimeProvider;
            this.db = db;
        }

        public async Task<int> GetTotalCountAsync()
            => await this.db.ReplyReactions
                .Where(pr => !pr.Reply.IsDeleted)
                .CountAsync();

        public async Task<ReactionsCountServiceModel> ReactAsync(ReactionType reactionType, int replyId, string authorId)
        {
            var replyReaction = await this.db.ReplyReactions
               .FirstOrDefaultAsync(rr => rr.ReplyId == replyId && rr.AuthorId == authorId);

            if (replyReaction == null)
            {
                replyReaction = new ReplyReaction
                {
                    ReactionType = reactionType,
                    ReplyId = replyId,
                    AuthorId = authorId,
                    CreatedOn = this.dateTimeProvider.Now(),
                };

                await this.db.ReplyReactions.AddAsync(replyReaction);
            }
            else
            {
                replyReaction.ModifiedOn = this.dateTimeProvider.Now();
                replyReaction.ReactionType = replyReaction.ReactionType == reactionType
                    ? ReactionType.Neutral
                    : reactionType;
            }

            await this.db.SaveChangesAsync();

            return await this.GetCountByReplyIdAsync(replyId);
        }

        private async Task<ReactionsCountServiceModel> GetCountByReplyIdAsync(int replyId)
           => new ReactionsCountServiceModel
           {
               Likes = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Like, replyId),
               Loves = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Love, replyId),
               HahaCount = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Haha, replyId),
               WowCount = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Wow, replyId),
               SadCount = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Sad, replyId),
               AngryCount = await this.GetCountByTypeAndReplyIdAsync(ReactionType.Angry, replyId),
           };

        private async Task<int> GetCountByTypeAndReplyIdAsync(ReactionType reactionType, int replyId)
            => await this.db.ReplyReactions
                .Where(pr => !pr.Reply.IsDeleted && pr.ReplyId == replyId)
                .CountAsync(pr => pr.ReactionType == reactionType);
    }
}

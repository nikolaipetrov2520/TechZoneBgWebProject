namespace TechZoneBgWebProject.Services.Messages
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Providers;

    public class MessagesService : IMessagesService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly IDateTimeProvider dateTimeProvider;

        public MessagesService(IDateTimeProvider dateTimeProvider, IMapper mapper, ApplicationDbContext db)
        {
            this.dateTimeProvider = dateTimeProvider;
            this.mapper = mapper;
            this.db = db;
        }

        public async Task CreateAsync(string content, string authorId, string receiverId)
        {
            var message = new Message
            {
                Content = content,
                AuthorId = authorId,
                ReceiverId = receiverId,
                CreatedOn = this.dateTimeProvider.Now(),
            };

            await this.db.Messages.AddAsync(message);
            await this.db.SaveChangesAsync();
        }

        public async Task<string> GetLastActivityAsync(string currentUserId, string userId)
            => await this.db.Messages
                .Where(m => !m.IsDeleted &&
                            ((m.ReceiverId == currentUserId && m.AuthorId == userId) ||
                             (m.ReceiverId == userId && m.AuthorId == currentUserId)))
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => m.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat))
                .FirstOrDefaultAsync();

        public async Task<string> GetLastMessageAsync(string currentUserId, string userId)
            => await this.db.Messages
                .Where(m => !m.IsDeleted &&
                            ((m.ReceiverId == currentUserId && m.AuthorId == userId) ||
                             (m.ReceiverId == userId && m.AuthorId == currentUserId)))
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => m.Content)
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<TModel>> GetAllWithUserAsync<TModel>(string currentUserId, string userId)
            => await this.db.Messages
                .Where(m => !m.IsDeleted &&
                            ((m.ReceiverId == currentUserId && m.AuthorId == userId) ||
                             (m.ReceiverId == userId && m.AuthorId == currentUserId)))
                .OrderBy(m => m.CreatedOn)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string currentUserId)
        {
            var sentMessages = this.db.Messages
                .Where(m => !m.IsDeleted &&
                            (m.AuthorId == currentUserId || m.ReceiverId == currentUserId))
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => m.Author);

            var receivedMessages = this.db.Messages
                .Where(m => !m.IsDeleted &&
                            (m.AuthorId == currentUserId || m.ReceiverId == currentUserId))
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => m.Receiver);

            var concatenatedMessages = await sentMessages
                .Concat(receivedMessages)
                .Where(u => u.Id != currentUserId)
                .Distinct()
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return concatenatedMessages;
        }
    }
}

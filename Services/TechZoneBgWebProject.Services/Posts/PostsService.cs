namespace TechZoneBgWebProject.Services.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Providers;

    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext db;
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly IMapper mapper;

        public PostsService(ApplicationDbContext db, IDateTimeProvider dateTimeProvider, IMapper mapper)
        {
            this.db = db;
            this.dateTimeProvider = dateTimeProvider;
            this.mapper = mapper;
        }

        public async Task<string> GetLatestActivityByIdAsync(int id)
        {
            var latestPostReply = await this.db.Posts
                .Where(p => p.Id == id && !p.IsDeleted)
                .SelectMany(p => p.Replies)
                .Where(r => !r.IsDeleted)
                .OrderByDescending(r => r.CreatedOn)
                .FirstOrDefaultAsync(r => r.PostId == id);

            var currentTime = this.dateTimeProvider.Now();

            if (latestPostReply != null)
            {
                var latestPostReplyActivity = this.CalculateLatestActivity(currentTime, latestPostReply.CreatedOn);
                return latestPostReplyActivity;
            }

            var post = await this.GetByIdAsync(id);
            var postLatestActivity = this.CalculateLatestActivity(currentTime, post.CreatedOn);

            return postLatestActivity;
        }

        public async Task<int> GetCountAsync(string searchFilter = null)
        {
            var queryable = this.db.Posts
                .Where(p => !p.IsDeleted);

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                queryable = queryable
                    .Where(t => t.Title.Contains(searchFilter));
            }

            var count = await queryable.CountAsync();

            return count;
        }

        public Task<int> CreateAsync(string title, PostType type, string description, string authorId, int categoryId, IEnumerable<int> tagIds)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int id, string title, string description, int categoryId, IEnumerable<int> tagIds)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task ViewAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PinAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetFollowingCountAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAuthorIdByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetSuggestedAsync<TModel>(int take)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllByTagIdAsync<TModel>(int tagId, string search = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllByCategoryIdAsync<TModel>(int categoryId, string search = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllByUserIdAsync<TModel>(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllFollowingByUserIdAsync<TModel>(string userId, string search = null, int skip = 0, int? take = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TModel> GetByIdAsync<TModel>(int id)
            => await this.db.Posts
                .AsNoTracking()
                .Where(p => p.Id == id && !p.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

        public Task<List<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null)
        {
            var queryable = this.db.Posts
               .AsNoTracking()
               .OrderByDescending(p => p.IsPinned)
               .ThenByDescending(p => p.Reactions
                   .Count(r => r.ReactionType != ReactionType.Neutral))
               .ThenByDescending(p => p.CreatedOn)
               .Where(p => !p.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(p => p.Title.Contains(search));
            }

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value);
            }

            var posts = queryable
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return posts;
        }

        private async Task<Post> GetByIdAsync(int id)
            => await this.db.Posts.FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

        private string CalculateLatestActivity(DateTime currentTime, DateTime latestPostTime)
        {
            const decimal totalDays = 365.25m;
            const char yearsPostfix = 'y';
            const char daysPostfix = 'd';
            const char hoursPostfix = 'h';
            const char minutesPostfix = 'm';

            var activity = currentTime - latestPostTime;
            var daysFromNow = activity.Days;
            var hoursFromNow = activity.Hours;
            var minutesFromNow = activity.Minutes;
            var years = (int)(daysFromNow / totalDays);

            var result = $"{years}{yearsPostfix}";

            if (years > 0)
            {
                return result;
            }

            if (daysFromNow != 0)
            {
                result = $"{daysFromNow}{daysPostfix}";
            }
            else
            {
                result = hoursFromNow == 0 ? $"{minutesFromNow}{minutesPostfix}" : $"{hoursFromNow}{hoursPostfix}";
            }

            return result;
        }
    }
}

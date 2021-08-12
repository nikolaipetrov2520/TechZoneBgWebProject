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
    using TechZoneBgWebProject.Services.Users;

    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext db;
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly IMapper mapper;
        private readonly IUsersService usersService;

        public PostsService(ApplicationDbContext db, IDateTimeProvider dateTimeProvider, IMapper mapper, IUsersService usersService)
        {
            this.db = db;
            this.dateTimeProvider = dateTimeProvider;
            this.mapper = mapper;
            this.usersService = usersService;
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

        public async Task<int> CreateAsync(string title, PostType type, string description, string authorId, int categoryId, IEnumerable<int> tagIds)
        {
            var post = new Post
            {
                Title = title,
                Type = type,
                Description = description,
                CreatedOn = this.dateTimeProvider.Now(),
                AuthorId = authorId,
                CategoryId = categoryId,
            };

            await this.db.Posts.AddAsync(post);
            await this.db.SaveChangesAsync();
            await this.AddTagsAsync(post.Id, tagIds);

            await this.usersService.AddPointsAsync(authorId);

            return post.Id;
        }

        public async Task EditAsync(int id, string title, string description, int categoryId, IEnumerable<int> tagIds)
        {
            var post = await this.GetByIdAsync(id);

            await this.RemoveTagsAsync(id, post);

            post.Title = title;
            post.Description = description;
            post.CategoryId = categoryId;
            post.ModifiedOn = this.dateTimeProvider.Now();

            await this.AddTagsAsync(id, tagIds);
            await this.db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var post = await this.GetByIdAsync(id);

            post.IsDeleted = true;
            post.DeletedOn = this.dateTimeProvider.Now();

            await this.db.SaveChangesAsync();
        }

        public async Task ViewAsync(int id)
        {
            var post = await this.GetByIdAsync(id);

            post.Views++;

            await this.db.SaveChangesAsync();
        }

        public async Task<int> GetFollowingCountAsync(string userId)
         => await this.db.Posts
                .Where(p => !p.IsDeleted && p.Author.Followers
                    .Where(f => !f.IsDeleted)
                    .Select(f => f.FollowerId)
                    .FirstOrDefault() == userId)
                .CountAsync();

        public async Task<string> GetAuthorIdByIdAsync(int id)
        => await this.db.Posts
                .Where(p => p.Id == id && !p.IsDeleted)
                .Select(p => p.AuthorId)
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<TModel>> GetAllFollowingByUserIdAsync<TModel>(string userId, string search = null, int skip = 0, int? take = null)
        {
            var queryable = this.db.Posts
                .AsNoTracking()
                .OrderByDescending(p => p.CreatedOn)
                .ThenByDescending(p => p.Reactions
                    .Count(r => r.ReactionType != ReactionType.Neutral))
                .Where(p => p.Author.Followers
                    .Where(f => !f.IsDeleted && f.FollowerId == userId)
                    .Select(f => f.FollowerId)
                    .FirstOrDefault() == userId);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(p => p.Title.Contains(search));
            }

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value);
            }

            var posts = await queryable
                .Where(p => !p.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return posts;
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

        public async Task<IEnumerable<TModel>> GetAllByCategoryIdAsync<TModel>(int categoryId, string search = null)
        {
            var queryable = this.db.Posts
               .AsNoTracking()
               .OrderByDescending(p => p.CreatedOn)
               .Where(p => p.CategoryId == categoryId && !p.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(p => p.Title.Contains(search));
            }

            var posts = await queryable
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return posts;
        }

        public async Task<IEnumerable<TModel>> GetAllByTagIdAsync<TModel>(int tagId, string search = null)
        {
            var queryable = this.db.Posts
               .AsNoTracking()
               .Where(p => !p.IsDeleted && p.Tags
                   .Select(t => t.TagId).Contains(tagId));

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(p => p.Title.Contains(search));
            }

            var posts = await queryable
                .OrderByDescending(p => p.CreatedOn)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return posts;
        }

        public async Task<bool> PinAsync(int id)
        {
            var post = await this.GetByIdAsync(id);

            post.IsPinned = !post.IsPinned;
            post.ModifiedOn = this.dateTimeProvider.Now();

            await this.db.SaveChangesAsync();

            return post.IsPinned;
        }

        public async Task<bool> IsExistingAsync(int id)
            => await this.db.Posts.AnyAsync(p => p.Id == id && !p.IsDeleted);

        public Task<IEnumerable<TModel>> GetSuggestedAsync<TModel>(int take)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> GetAllByUserIdAsync<TModel>(string userId)
            => await this.db.Posts
                .AsNoTracking()
                .OrderByDescending(p => p.CreatedOn)
                .Where(p => p.AuthorId == userId && !p.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        private async Task<Post> GetByIdAsync(int id)
            => await this.db.Posts.FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

        private string CalculateLatestActivity(DateTime currentTime, DateTime latestPostTime)
        {
            const decimal totalDays = 365.25m;
            const char yearsPostfix = 'г';
            const char daysPostfix = 'д';
            const char hoursPostfix = 'ч';
            const char minutesPostfix = 'м';

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

        private async Task AddTagsAsync(int id, IEnumerable<int> tagIds)
        {
            var post = await this.GetByIdAsync(id);

            foreach (var tagId in tagIds)
            {
                post.Tags.Add(new PostTag
                {
                    PostId = id,
                    TagId = tagId,
                });
            }

            await this.db.SaveChangesAsync();
        }

        private async Task RemoveTagsAsync(int id, Post post)
        {
            var postTags = await this.db.PostsTags.Where(pt => pt.PostId == id).ToListAsync();
            foreach (var tag in postTags)
            {
                post.Tags.Remove(tag);
            }

            await this.db.SaveChangesAsync();
        }
    }
}

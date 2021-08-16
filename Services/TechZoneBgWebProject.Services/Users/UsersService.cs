namespace TechZoneBgWebProject.Services.Users
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Providers;

    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly IDateTimeProvider dateTime;

        public UsersService(ApplicationDbContext db, IMapper mapper, IDateTimeProvider dateTime)
        {
            this.db = db;
            this.mapper = mapper;
            this.dateTime = dateTime;
        }

        public async Task<int> AddPointsAsync(string id, int points = 1)
        {
            var user = await this.GetByIdAsync(id);

            user.Points += points;

            await this.db.SaveChangesAsync();

            return user.Points;
        }

        public async Task<TModel> GetByIdAsync<TModel>(string id)
            => await this.db.Users
                .AsNoTracking()
                .Where(u => u.Id == id && !u.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

        public async Task<int> GetFollowersCountAsync(string id)
            => await this.db.UsersFollowers
                .Where(uf => !uf.IsDeleted &&
                             !uf.User.IsDeleted &&
                             !uf.Follower.IsDeleted &&
                             uf.UserId == id)
                .CountAsync();

        public async Task<int> GetFollowingCountAsync(string id)
            => await this.db.UsersFollowers
                .Where(uf => !uf.IsDeleted &&
                             !uf.User.IsDeleted &&
                             !uf.Follower.IsDeleted &&
                             uf.FollowerId == id)
                .CountAsync();

        public async Task<IEnumerable<TModel>> GetFollowingAsync<TModel>(string id)
            => await this.db.UsersFollowers
                .AsNoTracking()
                .Where(uf => uf.FollowerId == id &&
                             !uf.IsDeleted &&
                             !uf.User.IsDeleted)
                .Select(uf => uf.User)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<bool> IsFollowedAlreadyAsync(string id, string followerId)
            => await this.db.UsersFollowers
                .AnyAsync(uf => uf.UserId == id &&
                                uf.FollowerId == followerId &&
                                !uf.IsDeleted);

        public async Task<IEnumerable<TModel>> GetFollowersAsync<TModel>(string id)
            => await this.db.UsersFollowers
                .AsNoTracking()
                .Where(uf => uf.UserId == id &&
                             !uf.IsDeleted &&
                             !uf.Follower.IsDeleted)
                .Select(uf => uf.Follower)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<bool> FollowAsync(string userId, string followerId)
        {
            var isFollowed = false;
            var userFollower = await this.db.UsersFollowers
                .FirstOrDefaultAsync(uf => uf.UserId == userId && uf.FollowerId == followerId);

            if (userFollower == null)
            {
                userFollower = new UserFollower
                {
                    UserId = userId,
                    FollowerId = followerId,
                    CreatedOn = this.dateTime.Now(),
                };

                isFollowed = true;
                await this.db.UsersFollowers.AddAsync(userFollower);
            }
            else
            {
                if (userFollower.IsDeleted)
                {
                    isFollowed = true;
                    userFollower.IsDeleted = false;
                    userFollower.DeletedOn = null;
                    userFollower.CreatedOn = this.dateTime.Now();
                    userFollower.ModifiedOn = this.dateTime.Now();
                }
                else
                {
                    userFollower.IsDeleted = true;
                    userFollower.DeletedOn = this.dateTime.Now();
                }
            }

            await this.db.SaveChangesAsync();

            return isFollowed;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>()
             => await this.db.Users
                .AsNoTracking()
                .Where(u => !u.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        private async Task<ApplicationUser> GetByIdAsync(string id)
            => await this.db.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
    }
}

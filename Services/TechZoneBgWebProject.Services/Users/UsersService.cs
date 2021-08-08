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

    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public UsersService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
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

        public Task<int> GetTotalCountAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetFollowingAsync<TModel>(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsDeletedAsync(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsFollowedAlreadyAsync(string id, string followerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsUsernameUsedAsync(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task ModifyAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetFollowersAsync<TModel>(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> FollowAsync(string userId, string followerId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAdminsAsync<TModel>()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllAsync<TModel>()
        {
            throw new System.NotImplementedException();
        }

        private async Task<ApplicationUser> GetByIdAsync(string id)
            => await this.db.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
    }
}

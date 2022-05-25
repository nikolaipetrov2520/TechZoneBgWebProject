namespace TechZoneBgWebProject.Services.Users
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUsersService
    {

        Task<int> AddPointsAsync(string id, int points = 1);

        Task<bool> FollowAsync(string userId, string followerId);

        Task<bool> IsFollowedAlreadyAsync(string id, string followerId);

        Task<int> GetFollowersCountAsync(string id);

        Task<int> GetFollowingCountAsync(string id);

        Task<TModel> GetByIdAsync<TModel>(string id);

        Task<TModel> GetOrdersByIdAsync<TModel>(string id);

        Task<IEnumerable<TModel>> GetAllAsync<TModel>();

        Task<IEnumerable<TModel>> GetFollowersAsync<TModel>(string id);

        Task<IEnumerable<TModel>> GetFollowingAsync<TModel>(string id);
    }
}

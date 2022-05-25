namespace TechZoneBgWebProject.Services.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Web.ViewModels.Orders;
    using TechZoneBgWebProject.Web.ViewModels.Users;

    public interface ICartsService
    {
        Task<TModel> GetUnfinishedCartAsync<TModel>(string id);

        Task<IEnumerable<UsersExecutedViewModel>> GetExecutedCartAsync(string id);

        Task<IEnumerable<UsersExecutedViewModel>> GetExecutingCartAsync(string id);

        Task<OrderDetailsViewModel> GetFinishedCartByIdAsync(int id);

        Task<string> AddCartAsync(int id, int quantity, string userId);

        Task<string> UpdateCartAsync(int id, int quantity, string userId);

        Task RemoveProductById(int productId, int cartId);

        string GetSum(string id);

        Task<bool> FinishCartAsync(int cartId, string comment, string address);

        Task<int> GetCountAsync();

        Task<List<OrdersListingViewModel>> GetAllAsync(int skip = 0, int? take = null);

        Task OrderByIdAsync(int id);

        Task SendByIdAsync(int id);
    }
}

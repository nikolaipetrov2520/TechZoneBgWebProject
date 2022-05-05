namespace TechZoneBgWebProject.Services.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TechZoneBgWebProject.Data.Models;

    public interface ICartsService
    {
        Task<TModel> GetUnfinishedCartAsync<TModel>(string id);

        Task<string> AddCartAsync(int id, int quantity, string userId);

        Task RemoveProductById(int productId, int cartId);

        string GetSum(string id);
    }
}

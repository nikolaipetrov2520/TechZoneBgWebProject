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
        Task<List<Cart>> GetUnfinishedCartAsync(string id);

        Task<string> AddCartAsync(int id, int quantity, string userId);

        string GetSum(string id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechZoneBgWebProject.Data.Models;

namespace TechZoneBgWebProject.Services.Carts
{
    public interface ICartsService
    {
        Task<List<Cart>> GetUnfinishedCartAsync(string id);

        Task<string> AddCartAsync(int id, int quantity);
    }
}

namespace TechZoneBgWebProject.Services.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;

    public class CartsService : ICartsService
    {
        private readonly ApplicationDbContext db;

        public CartsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<string> AddCartAsync(int id, int quantity)
        {
            var result = "5";
            return result;
        }

        public async Task<List<Cart>> GetUnfinishedCartAsync(string id)
        {
            var carts = this.db.Carts.Where(x => x.AuthorId == id && !x.IsFinished && !x.IsDeleted).ToList();

            return carts;
        }
    }
}

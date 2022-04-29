namespace TechZoneBgWebProject.Services.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Users;
    using Microsoft.EntityFrameworkCore;

    public class CartsService : ICartsService
    {
        private readonly ApplicationDbContext db;

        public CartsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<string> AddCartAsync(int id, int quantity, string userId)
        {
            var cart = this.db.Carts.FirstOrDefault(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend);

            if (cart != null)
            {
                var product = new CartProduct
                {
                    ProductId = id,
                    Quantity = quantity,
                    CartId = cart.Id,
                    IsDeleted = false,
                };

                await this.db.CartProduct.AddAsync(product);
                await this.db.SaveChangesAsync();
            }
            else
            {
                var newcart = new Cart
                {
                    AuthorId = userId,
                    CreatedOn = DateTime.Now,
                    IsFinished = false,
                    IsSend = false,
                    IsDeleted = false,
                };

                await this.db.Carts.AddAsync(newcart);
                await this.db.SaveChangesAsync();

                var product = new CartProduct
                {
                    ProductId = id,
                    Quantity = quantity,
                    CartId = newcart.Id,
                    IsDeleted = false,
                };

                await this.db.CartProduct.AddAsync(product);
                await this.db.SaveChangesAsync();
            }

            var result = 0m;
            var queriable = this.db.Carts.Include(c => c.Products).ThenInclude(p => p.Product).FirstOrDefault(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend);
            if (queriable != null)
            {
                var products = queriable.Products.Where(p => !p.IsDeleted).ToList();
                foreach (var product in products)
                {
                    result += product.Quantity * product.Product.Price;
                }
            }

            var stringResult = result.ToString();

            return stringResult;
        }

        public async Task<List<Cart>> GetUnfinishedCartAsync(string id)
        {
            var carts = this.db.Carts.Where(x => x.AuthorId == id && !x.IsFinished && !x.IsDeleted).ToList();

            return carts;
        }

        public string GetSum(string id)
        {
            var result = 0m;

            var queriable = this.db.Carts.Include(c => c.Products).ThenInclude(p => p.Product).FirstOrDefault(x => x.AuthorId == id && !x.IsDeleted && !x.IsFinished && !x.IsSend);
            if (queriable != null)
            {
                var products = queriable.Products.Where(p => !p.IsDeleted).ToList();
                foreach (var product in products)
                {
                    result += product.Quantity * product.Product.Price;
                }
            }

            var stringResult = result.ToString();

            return stringResult;
        }
    }
}

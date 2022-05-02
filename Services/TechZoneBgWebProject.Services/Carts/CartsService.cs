namespace TechZoneBgWebProject.Services.Carts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;

    public class CartsService : ICartsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CartsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<string> AddCartAsync(int id, int quantity, string userId)
        {
            if (quantity < 1)
            {
                quantity = 1;
            }

            var cart = await this.db.Carts.Include(c => c.Products).FirstOrDefaultAsync(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend);

            if (cart != null)
            {
                var existedProduct = cart.Products.FirstOrDefault(x => x.ProductId == id);

                if (existedProduct != null)
                {
                    if (existedProduct.IsDeleted == true)
                    {
                        existedProduct.IsDeleted = false;
                        existedProduct.Quantity = quantity;

                        await this.db.SaveChangesAsync();
                    }
                    else
                    {
                        existedProduct.Quantity += quantity;
                        await this.db.SaveChangesAsync();
                    }
                }
                else
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
            var queriable = await this.db.Carts.Include(c => c.Products).ThenInclude(p => p.Product).FirstOrDefaultAsync(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend);
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

        public async Task<TModel> GetUnfinishedCartAsync<TModel>(string id)
        {
            var cart = await this.db.Carts
                .AsNoTracking()
                .Where(x => x.AuthorId == id && !x.IsDeleted && !x.IsFinished && !x.IsSend)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

            return cart;
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

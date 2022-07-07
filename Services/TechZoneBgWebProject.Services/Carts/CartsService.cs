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
    using TechZoneBgWebProject.Web.ViewModels.Orders;
    using TechZoneBgWebProject.Web.ViewModels.Users;

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

            var cart = await this.db.Carts.Include(c => c.Products).FirstOrDefaultAsync(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend && !x.IsOrdered);

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
                var lastCart = await this.db.Carts.Where(x => x.AuthorId == userId).OrderByDescending(c => c.Id).ToListAsync();

                string address = null;

                if (lastCart.Count > 0)
                {
                    address = lastCart[0].Address;
                }

                var newcart = new Cart
                {
                    AuthorId = userId,
                    CreatedOn = DateTime.Now,
                    IsFinished = false,
                    IsOrdered = false,
                    IsSend = false,
                    IsDeleted = false,
                    Address = address,
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

        public async Task<string> UpdateCartAsync(int id, int quantity, string userId)
        {
            if (quantity < 1)
            {
                quantity = 1;
            }

            var cart = await this.db.Carts.Include(c => c.Products).FirstOrDefaultAsync(x => x.AuthorId == userId && !x.IsDeleted && !x.IsFinished && !x.IsSend && !x.IsOrdered);

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
                        existedProduct.Quantity = quantity;
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
                .Where(x => x.AuthorId == id && !x.IsDeleted && !x.IsFinished)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

            return cart;
        }

        public async Task<bool> FinishCartAsync(int cartId, string comment, string address)
        {
            var cart = await this.db.Carts.FirstOrDefaultAsync(c => c.Id == cartId);

            if (cart != null)
            {
                cart.Comment = comment;
                if (cart.Address == null || address != cart.Address)
                {
                    cart.Address = address;
                }

                cart.IsFinished = true;
                cart.ModifiedOn = DateTime.Now;

                await this.db.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task RemoveProductById(int productId, int cartId)
        {
            var currentcart = this.db.Carts.FirstOrDefault(c => c.Id == cartId);

            if (currentcart.IsFinished)
            {
                return;
            }

            var cartProduct = await this.db.CartProduct
                .Where(x => x.CartId == cartId && x.ProductId == productId)
                .FirstOrDefaultAsync();

            if (cartProduct != null)
            {
                cartProduct.IsDeleted = true;
            }

            await this.db.SaveChangesAsync();

            var productsCount = await this.db.CartProduct
                .Where(x => x.CartId == cartId && !x.IsDeleted).ToListAsync();

            var cart = await this.db.Carts.FirstOrDefaultAsync(x => x.Id == cartId);

            if (productsCount.Count < 1)
            {
                cart.IsDeleted = true;
                cart.DeletedOn = DateTime.Now;
            }

            await this.db.SaveChangesAsync();
        }

        public string GetSum(string id)
        {
            var result = 0m;

            var queriable = this.db.Carts.Include(c => c.Products).ThenInclude(p => p.Product).FirstOrDefault(x => x.AuthorId == id && !x.IsDeleted && !x.IsFinished && !x.IsSend && !x.IsOrdered);
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

        public async Task<int> GetCountAsync()
        {
            var queryable = this.db.Carts
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend);

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<List<OrdersListingViewModel>> GetAllAsync(int skip = 0, int? take = null)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend).ToListAsync();

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value).ToList();
            }

            var carts = new List<OrdersListingViewModel>();

            foreach (var item in queryable)
            {
                decimal sum = 0m;
                foreach (var product in item.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var cart = new OrdersListingViewModel
                {
                    FirstName = item.Author.FirstName,
                    LastName = item.Author.LastName,
                    PhoneNumber = item.Author.PhoneNumber,
                    Sum = sum,
                    Id = item.Id,
                    Time = item.ModifiedOn ?? DateTime.Now,
                    Comment = item.Comment,
                    IsOrdered = item.IsOrdered,
                };

                carts.Add(cart);
            }

            return carts;
        }

        public async Task<OrderDetailsViewModel> GetFinishedCartByIdAsync(int id)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .FirstOrDefaultAsync(c => c.Id == id);

            decimal sum = 0m;
            foreach (var product in queryable.Products)
            {
                sum += product.Quantity * product.Product.Price;
            }

            var cart = new OrderDetailsViewModel
            {
                FirstName = queryable.Author.FirstName,
                LastName = queryable.Author.LastName,
                PhoneNumber = queryable.Author.PhoneNumber,
                Sum = sum,
                Id = queryable.Id,
                Time = queryable.ModifiedOn ?? DateTime.Now,
                Comment = queryable.Comment,
                Address = queryable.Address,
                IsOrdered = queryable.IsOrdered,
                IsSend = queryable.IsSend,
            };

            return cart;
        }

        public async Task<UsersExecutedViewModel> GetCartDetailsByIdAsync(int id)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .FirstOrDefaultAsync(c => c.Id == id);

            decimal sum = 0m;
            foreach (var product in queryable.Products)
            {
                sum += product.Quantity * product.Product.Price;
            }

            var cart = new UsersExecutedViewModel
            {
                Sum = sum,
                Id = queryable.Id,
                Time = queryable.ModifiedOn ?? DateTime.Now,
                Comment = queryable.Comment,
                Address = queryable.Address,
                AuthorId = queryable.AuthorId,
            };

            return cart;
        }

        public async Task OrderByIdAsync(int id)
        {
            var queryable = await this.db.Carts
                .FirstOrDefaultAsync(c => c.Id == id);
            if (queryable != null)
            {
                queryable.IsOrdered = true;
                await this.db.SaveChangesAsync();
            }
        }

        public async Task SendByIdAsync(int id)
        {
            var queryable = await this.db.Carts
                .FirstOrDefaultAsync(c => c.Id == id);
            if (queryable != null)
            {
                queryable.IsSend = true;
                await this.db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UsersExecutedViewModel>> GetExecutedCartAsync(string id)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderByDescending(c => c.Id)
                .Where(c => c.AuthorId == id && c.IsFinished && !c.IsDeleted && c.IsOrdered && c.IsSend)
                .ToListAsync();

            var carts = new List<UsersExecutedViewModel>();

            foreach (var cart in queryable)
            {
                decimal sum = 0m;
                foreach (var product in cart.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var result = new UsersExecutedViewModel
                {
                    Sum = sum,
                    Id = cart.Id,
                    Time = cart.ModifiedOn ?? DateTime.Now,
                    Comment = cart.Comment,
                    Address = cart.Address,
                };

                carts.Add(result);
            }

            return carts;
        }

        public async Task<IEnumerable<UsersExecutedViewModel>> GetExecutingCartAsync(string id)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderByDescending(c => c.Id)
                .Where(c => c.AuthorId == id && c.IsFinished && !c.IsDeleted && !c.IsSend)
                .ToListAsync();

            var carts = new List<UsersExecutedViewModel>();

            foreach (var cart in queryable)
            {
                decimal sum = 0m;
                foreach (var product in cart.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var result = new UsersExecutedViewModel
                {
                    Sum = sum,
                    Id = cart.Id,
                    Time = cart.ModifiedOn ?? DateTime.Now,
                    Comment = cart.Comment,
                    Address = cart.Address,
                };

                carts.Add(result);
            }

            return carts;
        }

        public async Task<int> GetNewCountAsync()
        {
            var queryable = this.db.Carts
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend && !c.IsOrdered);

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<int> GetExecutingCountAsync()
        {
            var queryable = this.db.Carts
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend && c.IsOrdered);

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<int> GetExecutedCountAsync()
        {
            var queryable = this.db.Carts
                .Where(c => c.IsFinished && !c.IsDeleted && c.IsSend && c.IsOrdered);

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<List<OrdersListingViewModel>> GetNewAsync(int skip = 0, int? take = null)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderByDescending(c => c.Id)
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend && !c.IsOrdered).ToListAsync();

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value).ToList();
            }

            var carts = new List<OrdersListingViewModel>();

            foreach (var item in queryable)
            {
                decimal sum = 0m;
                foreach (var product in item.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var cart = new OrdersListingViewModel
                {
                    FirstName = item.Author.FirstName,
                    LastName = item.Author.LastName,
                    PhoneNumber = item.Author.PhoneNumber,
                    Sum = sum,
                    Id = item.Id,
                    Time = item.ModifiedOn ?? DateTime.Now,
                    Comment = item.Comment,
                    IsOrdered = item.IsOrdered,
                };

                carts.Add(cart);
            }

            return carts;
        }

        public async Task<List<OrdersListingViewModel>> GetExecutingAsync(int skip = 0, int? take = null)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderByDescending(c => c.Id)
                .Where(c => c.IsFinished && !c.IsDeleted && !c.IsSend && c.IsOrdered).ToListAsync();

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value).ToList();
            }

            var carts = new List<OrdersListingViewModel>();

            foreach (var item in queryable)
            {
                decimal sum = 0m;
                foreach (var product in item.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var cart = new OrdersListingViewModel
                {
                    FirstName = item.Author.FirstName,
                    LastName = item.Author.LastName,
                    PhoneNumber = item.Author.PhoneNumber,
                    Sum = sum,
                    Id = item.Id,
                    Time = item.ModifiedOn ?? DateTime.Now,
                    Comment = item.Comment,
                    IsOrdered = item.IsOrdered,
                };

                carts.Add(cart);
            }

            return carts;
        }

        public async Task<List<OrdersListingViewModel>> GetExecutedAsync(int skip = 0, int? take = null)
        {
            var queryable = await this.db.Carts.Include(c => c.Products).ThenInclude(c => c.Product).Include(c => c.Author)
                .AsNoTracking()
                .OrderByDescending(c => c.Id)
                .Where(c => c.IsFinished && !c.IsDeleted && c.IsSend && c.IsOrdered).ToListAsync();

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value).ToList();
            }

            var carts = new List<OrdersListingViewModel>();

            foreach (var item in queryable)
            {
                decimal sum = 0m;
                foreach (var product in item.Products)
                {
                    sum += product.Quantity * product.Product.Price;
                }

                var cart = new OrdersListingViewModel
                {
                    FirstName = item.Author.FirstName,
                    LastName = item.Author.LastName,
                    PhoneNumber = item.Author.PhoneNumber,
                    Sum = sum,
                    Id = item.Id,
                    Time = item.ModifiedOn ?? DateTime.Now,
                    Comment = item.Comment,
                    IsOrdered = item.IsOrdered,
                };

                carts.Add(cart);
            }

            return carts;
        }
    }
}

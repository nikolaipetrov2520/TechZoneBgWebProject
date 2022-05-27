namespace TechZoneBgWebProject.Services.Products
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

    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ProductsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public Task<List<TModel>> GetAllAsync<TModel>(string search = null, string sort = null, int skip = 0, int? take = null)
        {
            var queryable = this.db.Products
                .AsNoTracking()
                .OrderByDescending(p => p.ProductId)
                    .Where(p => p.InStock);

            if (!string.IsNullOrWhiteSpace(search))
            {
                var filters = search.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var filter in filters)
                {
                    queryable = queryable
                    .Where(t => t.Name.Contains(filter));
                }
            }

            if (sort != null)
            {
                if (sort == "id")
                {
                    queryable = queryable.OrderByDescending(p => p.ProductId);
                }

                if (sort == "name")
                {
                    queryable = queryable.OrderBy(p => p.Name);
                }

                if (sort == "price")
                {
                    queryable = queryable.OrderBy(p => p.Price);
                }

                if (sort == "price_desc")
                {
                    queryable = queryable.OrderByDescending(p => p.Price);
                }

            }

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value);
            }

            var products = queryable
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return products;
        }

        public async Task<TModel> GetByIdAsync<TModel>(int id)
            => await this.db.Products
                .AsNoTracking()
                .Where(p => p.Id == id && p.InStock)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

        public async Task<int> GetCountAsync(string searchFilter = null)
        {
            var queryable = this.db.Products
                .Where(p => p.InStock);

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                var filters = searchFilter.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var filter in filters)
                {
                    queryable = queryable
                    .Where(t => t.Name.Contains(filter));
                }
            }

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<IEnumerable<TModel>> GetProductsBiCartIdAsync<TModel>(int id)
            => await this.db.CartProduct
                .Where(cp => cp.CartId == id && !cp.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<IEnumerable<TModel>> GetAllProductsAsync<TModel>()
            => await this.db.Products
                .Where(p => p.InStock)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
    }
}

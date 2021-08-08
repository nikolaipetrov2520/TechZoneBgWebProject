namespace TechZoneBgWebProject.Services.Categories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;

    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CategoriesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public Task CreateAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int id, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null)
        {
            var queryable = this.db.Categories
               .AsNoTracking()
               .Where(c => !c.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(q => q.Name.Contains(search));
            }

            var categories = await queryable
                .OrderByDescending(c => c.Posts.Count)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return categories;
        }

        public Task<TModel> GetByIdAsync<TModel>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistingAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistingAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}

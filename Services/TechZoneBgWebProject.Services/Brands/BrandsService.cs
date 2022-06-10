namespace TechZoneBgWebProject.Services.Brands
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TechZoneBgWebProject.Data;

    public class BrandsService : IBrandsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public BrandsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null)
        {
            var queryable = this.db.Brands
               .AsNoTracking()
               .Where(c => !c.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(q => q.Name.Contains(search));
            }

            var categories = await queryable
                .OrderBy(c => c.Id)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return categories;
        }
    }
}

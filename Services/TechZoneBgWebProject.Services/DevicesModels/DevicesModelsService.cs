namespace TechZoneBgWebProject.Services.DevicesModels
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

    public class DevicesModelsService : IDevicesModelsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public DevicesModelsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null)
        {
            var queryable = this.db.DevicesModels
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

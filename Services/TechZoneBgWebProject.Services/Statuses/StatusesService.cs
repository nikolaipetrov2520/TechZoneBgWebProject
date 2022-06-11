namespace TechZoneBgWebProject.Services.Statuses
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
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class StatusesService : IStatusesService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public StatusesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null)
        {
            var queryable = this.db.Status
               .AsNoTracking()
               .Where(c => !c.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(q => q.Name.Contains(search));
            }

            var statuses = await queryable
                .OrderBy(c => c.Id)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return statuses;
        }
    }
}

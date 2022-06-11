namespace TechZoneBgWebProject.Services.Checks
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

    public class ChecksService : IChecksService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ChecksService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(int id)
        {
            var queryableChecklist = await this.db.CheckList
               .AsNoTracking()
               .Where(c => c.DeviceId == id)
               .FirstOrDefaultAsync();

            var queryableChecklistsCheck = this.db.CheckListsChecks
               .AsNoTracking()
               .OrderBy(clc => clc.CheckId)
               .Where(c => c.CheckListId == queryableChecklist.Id);

            var checks = await queryableChecklistsCheck
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

            return checks;
        }
    }
}

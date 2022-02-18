namespace TechZoneBgWebProject.Services.Roles
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;

    public class RolesService : IRolesService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public RolesService(ApplicationDbContext db, IMapper mapper, UserManager<ApplicationUser> _userManager)
        {
            this.db = db;
            this.mapper = mapper;
            this._userManager = _userManager;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null)
        {
            var queryable = this._userManager.Users
               .AsNoTracking()
               .Where(t => !t.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(t => t.UserName.Contains(search));
            }

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value);
            }

            var users = await queryable
                 .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                 .ToListAsync();

            return users;
        }

        public async Task<int> GetCountAsync(string searchFilter = null)
        {
            var queryable = this._userManager.Users
              .Where(p => !p.IsDeleted);

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                queryable = queryable
                    .Where(t => t.UserName.Contains(searchFilter));
            }

            var count = await queryable.CountAsync();

            return count;
        }

    }
}

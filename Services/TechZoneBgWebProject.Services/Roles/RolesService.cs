namespace TechZoneBgWebProject.Services.Roles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Web.ViewModels.Roles;

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

        public async Task<List<RolesAllViewModel>> GetAllAsync<TModel>(int count, string search = null, int skip = 0, int? take = null, int page = 1)
        {
            var users = this.db.Users.AsNoTracking().Where(t => !t.IsDeleted).Select(x => new RolesAllViewModel
            {
              Id = x.Id,
              Username = x.FirstName + " " + x.LastName,
              Role = x.Roles.ToString(),
              Roles = db.Roles .Select(r => new RolesViewModel
              {
                  Id = r.Id,
                  Role = r.Name,
              }),
              Search = search,
              PageIndex = page,
              TotalPages = (int)Math.Ceiling(count / (decimal)take),
            });
            //if (!string.IsNullOrWhiteSpace(search))
            //{
            //    users = users.Where(t => t.UserName.Contains(search));
            //}

            if (take.HasValue)
            {
                users = users.Skip(skip).Take(take.Value);
            }

            return users.ToList();
        }

        public async Task<List<RolesUsersViewModel>> GetAllByUserIdAsync(string id)
        {
            var userRoles = await this.db.UserRoles
                .Where(ur => ur.UserId == id)
                .ToListAsync();
            var roles = new List<RolesUsersViewModel>();

            foreach (var userRole in userRoles)
            {
                var queryable = this.db.Roles.Where(r => r.Id == userRole.RoleId);
                foreach (var item in queryable)
                {
                    var role = new RolesUsersViewModel
                    {
                        Id = item.Id,
                        Name = item.Name,
                    };

                    roles.Add(role);
                }
            }

            return roles;
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

namespace TechZoneBgWebProject.Services.Tags
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using TechZoneBgWebProject.Data;

    public class TagsService : ITagsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public TagsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null)
        {
            var queryable = this.db.Tags
               .AsNoTracking()
               .OrderByDescending(t => t.Posts
                   .Count(p => !p.Post.IsDeleted))
               .Where(t => !t.IsDeleted);

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(t => t.Name.Contains(search));
            }

            if (take.HasValue)
            {
                queryable = queryable.Skip(skip).Take(take.Value);
            }

            var tags = await queryable
                 .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                 .ToListAsync();

            return tags;
        }

        public async Task<IEnumerable<TModel>> GetAllByPostIdAsync<TModel>(int postId)
            => await this.db.PostsTags
                .AsNoTracking()
                .Where(pt => pt.PostId == postId && !pt.Post.IsDeleted)
                .Select(pt => pt.Tag)
                .Where(t => !t.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();

        public async Task<int> GetCountAsync(string searchFilter = null)
        {
            var queryable = this.db.Tags
              .Where(p => !p.IsDeleted);

            if (!string.IsNullOrWhiteSpace(searchFilter))
            {
                queryable = queryable
                    .Where(t => t.Name.Contains(searchFilter));
            }

            var count = await queryable.CountAsync();

            return count;
        }

        public async Task<TModel> GetByIdAsync<TModel>(int id)
            => await this.db.Tags
                .AsNoTracking()
                .Where(t => t.Id == id && !t.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

        public Task<bool> IsExistingAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsExistingAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AreExistingAsync(IEnumerable<int> ids)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

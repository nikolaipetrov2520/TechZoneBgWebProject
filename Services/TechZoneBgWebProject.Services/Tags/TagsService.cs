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

        public TagsService(ApplicationDbContext db)
        {
            this.db = db;
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

        public Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllByPostIdAsync<TModel>(int postId)
        {
            throw new System.NotImplementedException();
        }

        public Task<TModel> GetByIdAsync<TModel>(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetCountAsync(string searchFilter = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsExistingAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsExistingAsync(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}

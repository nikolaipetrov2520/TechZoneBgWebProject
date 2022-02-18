namespace TechZoneBgWebProject.Services.Roles
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRolesService
    {
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null);

        Task<int> GetCountAsync(string searchFilter = null);
    }
}

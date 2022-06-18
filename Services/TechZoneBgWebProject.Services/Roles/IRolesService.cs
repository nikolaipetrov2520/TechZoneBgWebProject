namespace TechZoneBgWebProject.Services.Roles
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Web.ViewModels.Roles;

    public interface IRolesService
    {
        Task<List<RolesAllViewModel>> GetAllAsync<TModel>(int count, string search = null, int skip = 0, int? take = null, int page = 1);

        Task<List<RolesUsersViewModel>> GetAllByUserIdAsync(string id);

        Task<int> GetCountAsync(string searchFilter = null);
    }
}

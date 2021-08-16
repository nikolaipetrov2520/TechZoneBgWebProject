namespace TechZoneBgWebProject.Services.Reports
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReportsService
    {
        Task CreateAsync(string description, int postId, string authorId);

        Task<bool> DeleteAsync(int id);

        Task<TModel> GetByIdAsync<TModel>(int id);

        Task<IEnumerable<TModel>> GetAllAsync<TModel>();
    }
}

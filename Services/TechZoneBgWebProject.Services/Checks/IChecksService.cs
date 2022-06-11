namespace TechZoneBgWebProject.Services.Checks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public interface IChecksService
    {
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(int id);
    }
}

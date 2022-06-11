namespace TechZoneBgWebProject.Services.Statuses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public interface IStatusesService
    {
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null);
    }
}

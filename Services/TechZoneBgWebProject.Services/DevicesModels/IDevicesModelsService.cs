namespace TechZoneBgWebProject.Services.DevicesModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDevicesModelsService
    {
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null);
    }
}

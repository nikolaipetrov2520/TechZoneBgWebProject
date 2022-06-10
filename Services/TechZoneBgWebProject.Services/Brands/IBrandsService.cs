namespace TechZoneBgWebProject.Services.Brands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBrandsService
    {
        Task<IEnumerable<TModel>> GetAllAsync<TModel>(string search = null);
    }
}

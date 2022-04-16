﻿namespace TechZoneBgWebProject.Services.Products
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductsService
    {
        Task<int> GetCountAsync(string searchFilter = null);

        Task<List<TModel>> GetAllAsync<TModel>(string search = null, int skip = 0, int? take = null);
    }
}
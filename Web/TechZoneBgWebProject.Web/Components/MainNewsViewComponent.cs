﻿namespace TechZoneBgWebProject.Web.Components
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Data.Common.Repositories;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Mapping;
    using TechZoneBgWebProject.Web.ViewModels.MainNews;

    [ViewComponent(Name = "MainNews")]
    public class MainNewsViewComponent : ViewComponent
    {
        private readonly IDeletableEntityRepository<MainNews> mainNewsRepository;

        private readonly IDeletableEntityRepository<MainNewsSource> mainNewsSourcesRepository;

        public MainNewsViewComponent(
            IDeletableEntityRepository<MainNews> mainNewsRepository,
            IDeletableEntityRepository<MainNewsSource> mainNewsSourcesRepository)
        {
            this.mainNewsRepository = mainNewsRepository;
            this.mainNewsSourcesRepository = mainNewsSourcesRepository;
        }

        public IViewComponentResult Invoke()
        {
            if (this.mainNewsRepository.All().Count() == 0)
            {
                return this.View(new MainNewsComponentViewModel { MainNews = new List<MainNewsViewModel>() });
            }

            var news = this.mainNewsSourcesRepository.All()
                .Select(x => x.MainNews.OrderByDescending(x => x.Id).FirstOrDefault())
                .OrderByDescending(x => x.CreatedOn).To<MainNewsViewModel>().ToList();
            var viewModel = new MainNewsComponentViewModel { MainNews = news };
            return this.View(viewModel);
        }
    }
}

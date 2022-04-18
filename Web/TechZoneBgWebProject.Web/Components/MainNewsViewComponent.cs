namespace TechZoneBgWebProject.Web.Components
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

        public MainNewsViewComponent(IDeletableEntityRepository<MainNews> mainNewsRepository)
        {
            this.mainNewsRepository = mainNewsRepository;
        }

        public IViewComponentResult Invoke()
        {
            if (this.mainNewsRepository.All().Count() == 0)
            {
                return this.View(new MainNewsComponentViewModel { MainNews = new List<MainNewsViewModel>() });
            }

            var news = this.mainNewsRepository.All().OrderByDescending(x => x.Id).To<MainNewsViewModel>().ToList().Take(8);

            var viewModel = new MainNewsComponentViewModel { MainNews = news };

            return this.View(viewModel);
        }
    }
}

namespace TechZoneBgWebProject.Web.Tests.Controllers
{
    using MyTested.AspNetCore.Mvc;

    using TechZoneBgWebProject.Web.Areas.Administration.Controllers;
    using TechZoneBgWebProject.Web.ViewModels.Categories;
    using Xunit;

    public class CategoriesControllerTests
    {
        [Fact]
        public void AllShouldReturnCorrectViewModel()
           => MyController<CategoriesController>
               .Instance()
               .WithUser()
               .Calling(c => c.All("recent"))
               .ShouldReturn()
               .View(v => v
                   .WithModelOfType<CategoriesAllViewModel>()
                   .Passing(c => c.Search == "recent"));
    }
}

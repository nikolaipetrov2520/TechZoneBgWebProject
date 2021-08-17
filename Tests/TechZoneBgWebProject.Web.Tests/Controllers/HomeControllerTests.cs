namespace TechZoneBgWebProject.Web.Tests.Controllers
{
    using MyTested.AspNetCore.Mvc;
    using TechZoneBgWebProject.Web.Controllers;
    using TechZoneBgWebProject.Web.ViewModels;
    using Xunit;

    public class HomeControllerTests
    {
        [Fact]
        public void IndexShouldRedirectToPostControllerAllAction()
            => MyController<HomeController>
                .Calling(c => c.Index())
                .ShouldReturn()
                .RedirectToAction("Trending", "Posts");

        [Fact]
        public void NotFound404ShouldReturnViewWithDefaultName()
           => MyController<HomeController>
               .Calling(c => c.NotFound404())
               .ShouldReturn()
               .View(v => v.WithDefaultName());

        [Fact]
        public void ErrorShouldReturnViewWithCorrectViewModel()
            => MyController<HomeController>
                .Calling(c => c.Error())
                .ShouldReturn()
                .View(v => v
                    .WithDefaultName()
                    .WithModelOfType<ErrorViewModel>());
    }
}

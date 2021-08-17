namespace TechZoneBgWebProject.Web.Tests.Controllers
{
    using MyTested.AspNetCore.Mvc;

    using TechZoneBgWebProject.Web.Areas.Administration.Controllers;
    using TechZoneBgWebProject.Web.ViewModels.Tags;
    using Xunit;

    public class TagsControllerTests
    {
        [Fact]
        public void AllShouldReturnCorrectViewModel()
          => MyController<TagsController>
              .Instance()
              .WithUser()
              .Calling(c => c.All(2, "recent"))
              .ShouldReturn()
              .View(v => v
                  .WithModelOfType<TagsAllViewModel>()
                  .Passing(c => c.Search == "recent"));
    }
}

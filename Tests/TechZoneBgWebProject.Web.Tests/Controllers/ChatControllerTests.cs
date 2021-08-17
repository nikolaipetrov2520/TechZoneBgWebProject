namespace TechZoneBgWebProject.Web.Tests.Controllers
{
    using MyTested.AspNetCore.Mvc;
    using TechZoneBgWebProject.Web.Controllers;
    using Xunit;

    public class ChatControllerTests
    {
        [Fact]
        public void AllShouldReturnViewWithDefaultName()
            => MyController<ChatController>
                .Calling(c => c.All())
                .ShouldReturn()
                .View(v => v
                    .WithDefaultName());

        [Fact]
        public void WithUserShouldReturnViewWithDefaultName()
            => MyController<ChatController>
                .Calling(c => c.WithUser("test"))
                .ShouldReturn()
                .View(v => v
                    .WithDefaultName());

        [Fact]
        public void SendMessageShouldReturnViewWithDefaultName()
            => MyController<ChatController>
                .Calling(c => c.SendMessage())
                .ShouldReturn()
                .View(v => v
                    .WithDefaultName());
    }
}

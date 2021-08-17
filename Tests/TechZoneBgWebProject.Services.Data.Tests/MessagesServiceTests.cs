namespace TechZoneBgWebProject.Services.Data.Tests
{
    using System;
    using System.Threading.Tasks;

    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Messages;
    using TechZoneBgWebProject.Services.Providers;
    using Xunit;

    public class MessagesServiceTests
    {
        [Fact]
        public async Task CreateMethodShouldAddMessageInDatabase()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();

            var messagesService = new MessagesService(dateTimeProviderMock.Object, null, db);
            await messagesService.CreateAsync("Test", "123", "321");

            db.Messages.Should().HaveCount(1);
        }

        [Fact]
        public async Task CreateMethodShouldAddRightMessageInDatabase()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 17));

            var messagesService = new MessagesService(dateTimeProvider.Object, null, db);
            await messagesService.CreateAsync("Test", "123", "321");

            var actual = await db.Messages.FirstOrDefaultAsync();

            var expected = new Message
            {
                Id = 1,
                Content = "Test",
                AuthorId = "123",
                ReceiverId = "321",
                ModifiedOn = actual.ModifiedOn,
                CreatedOn = dateTimeProvider.Object.Now(),
            };


            actual.Should().BeEquivalentTo(expected);
        }
    }
}

namespace TechZoneBgWebProject.Services.Data.Tests
{
    using System;
    using System.Threading.Tasks;

    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Moq;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Replies;
    using TechZoneBgWebProject.Services.Users;
    using Xunit;

    public class RepliesServiceTests
    {
        [Theory]
        [InlineData("Test 1", 1, 1)]
        [InlineData("Test 2", null, 1)]
        public async Task CreateMethodShouldAddReplyInDatabase(string description, int? parentId, int postId)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            await repliesService.CreateAsync(description, parentId, postId, guid);

            db.Replies.Should().HaveCount(1);
        }

        [Theory]
        [InlineData("Test 1", 1, 1)]
        [InlineData("Test 2", null, 1)]
        public async Task CreateMethodShouldAddRightReplyInDatabase(string description, int? parentId, int postId)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            await repliesService.CreateAsync(description, parentId, postId, guid);

            var expected = new Reply
            {
                Id = 1,
                Description = description,
                ParentId = parentId,
                PostId = postId,
                AuthorId = guid,
                CreatedOn = dateTimeProviderMock.Object.Now(),
            };

            var actual = await db.Replies.FirstOrDefaultAsync();

            expected.Id.Should().Be(actual.Id);
            expected.Description.Should().Be(actual.Description);
            expected.ParentId.Should().Be(actual.ParentId);
            expected.PostId.Should().Be(actual.PostId);
            expected.AuthorId.Should().Be(actual.AuthorId);
            expected.CreatedOn.Should().BeSameDateAs(actual.CreatedOn);
        }

        [Theory]
        [InlineData("Test 1", "Edit 1")]
        [InlineData("Test 2", "Edit 2")]
        [InlineData("Test 3", "Edit 3")]
        public async Task EditMethodShouldChangeDescriptionAndModifiedOn(string creationDescription, string editedDescription)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            await db.Replies.AddAsync(new Reply
            {
                Description = creationDescription,
                CreatedOn = dateTimeProviderMock.Object.Now(),
            });
            await db.SaveChangesAsync();

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            await repliesService.EditAsync(1, editedDescription);

            var actual = await db.Replies.FirstOrDefaultAsync();

            var expected = new Reply
            {
                Description = editedDescription,
                ModifiedOn = actual.ModifiedOn,
            };

            expected.Description.Should().BeSameAs(actual.Description);
            expected.ModifiedOn.Should().Be(actual.ModifiedOn);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task MakeBestAnswerMethodShouldChangeIsBestAnswer(bool isBestAnswer)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            await db.Replies.AddAsync(new Reply
            {
                Description = "Test",
                IsBestAnswer = isBestAnswer,
                CreatedOn = dateTimeProviderMock.Object.Now(),
            });
            await db.SaveChangesAsync();

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            await repliesService.MakeBestAnswerAsync(1);

            var expected = new Reply
            {
                Id = 1,
                Description = "Test",
                IsBestAnswer = !isBestAnswer,
                CreatedOn = dateTimeProviderMock.Object.Now(),
            };

            var actual = await db.Replies.FirstOrDefaultAsync();

            expected.Id.Should().Be(actual.Id);
            expected.Description.Should().Be(actual.Description);
            expected.IsBestAnswer.Should().Be(actual.IsBestAnswer);
            expected.CreatedOn.Should().BeSameDateAs(actual.CreatedOn);
        }

        [Fact]
        public async Task GetAuthorIdByIdMethodShouldReturnCorrectId()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            await db.Replies.AddAsync(new Reply
            {
                Description = "Test",
                AuthorId = guid,
                CreatedOn = dateTimeProviderMock.Object.Now(),
            });
            await db.SaveChangesAsync();

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            var authorId = await repliesService.GetAuthorIdByIdAsync(1);

            authorId.Should().BeSameAs(guid);
        }

        [Fact]
        public async Task GetAuthorIdByIdMethodShouldReturnNullIfReplyIsNotFound()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var usersServiceMock = new Mock<IUsersService>();
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();

            var repliesService = new RepliesService(null, db, dateTimeProviderMock.Object, usersServiceMock.Object);
            var authorId = await repliesService.GetAuthorIdByIdAsync(1);

            authorId.Should().BeNull();
        }
    }
}

namespace TechZoneBgWebProject.Services.Data.Tests
{
    using System;
    using System.Threading.Tasks;

    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Reactions;
    using TechZoneBgWebProject.Services.Reactions.Models;
    using Xunit;

    public class ReactionsServiceTests
    {
        [Theory]
        [InlineData("Test 1", "Description 1", ReactionType.Like)]
        [InlineData("Test 2", "Description 2", ReactionType.Dislike)]

        public async Task ReactMethodShouldAddReactionInDatabaseIfNotExistsAlready(string title, string description, ReactionType type)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 17));

            var post = new Post
            {
                Id = 1,
                Title = title,
                Description = description,
                CategoryId = 1,
                AuthorId = guid,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postReactionsService = new ReactionsService(dateTimeProvider.Object, db);
            var result = await postReactionsService.ReactAsync(type, 1, guid);

            var actual = await db.PostReactions.FirstOrDefaultAsync();
            var expected = new PostReaction
            {
                Id = 1,
                PostId = 1,
                Post = post,
                AuthorId = guid,
                ReactionType = type,
                ModifiedOn = actual.ModifiedOn,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            actual.Should().BeEquivalentTo(expected);
            result.Should().BeOfType<ReactionsCountServiceModel>();
        }

        [Theory]
        [InlineData(ReactionType.Like)]
        [InlineData(ReactionType.Dislike)]

        public async Task ReactMethodShouldChangeReactionIfAlreadyExistsAndChangeModifiedOn(ReactionType type)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 17));

            var postReaction = new PostReaction
            {
                Id = 1,
                PostId = 1,
                AuthorId = guid,
                ReactionType = ReactionType.Like,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.PostReactions.AddAsync(postReaction);
            await db.SaveChangesAsync();

            var postReactionsService = new ReactionsService(dateTimeProvider.Object, db);
            var result = await postReactionsService.ReactAsync(type, 1, guid);

            var actual = await db.PostReactions.FirstOrDefaultAsync();
            var expected = new PostReaction
            {
                Id = 1,
                PostId = 1,
                AuthorId = guid,
                ReactionType = type,
                CreatedOn = dateTimeProvider.Object.Now(),
                ModifiedOn = actual.ModifiedOn,
            };

            actual.Should().BeEquivalentTo(expected);
            result.Should().BeOfType<ReactionsCountServiceModel>();
        }

        [Theory]
        [InlineData(ReactionType.Like)]
        [InlineData(ReactionType.Dislike)]
        public async Task ReactMethodShouldChangeReactionToNeutralIfReactionIsClickedTwice(ReactionType type)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 17));

            var postReaction = new PostReaction
            {
                Id = 1,
                PostId = 1,
                AuthorId = guid,
                ReactionType = type,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.PostReactions.AddAsync(postReaction);
            await db.SaveChangesAsync();

            var postReactionsService = new ReactionsService(dateTimeProvider.Object, db);
            var result = await postReactionsService.ReactAsync(type, 1, guid);

            var actual = await db.PostReactions.FirstOrDefaultAsync();
            var expected = new PostReaction
            {
                Id = 1,
                PostId = 1,
                AuthorId = guid,
                ReactionType = ReactionType.Neutral,
                CreatedOn = dateTimeProvider.Object.Now(),
                ModifiedOn = dateTimeProvider.Object.Now(),
            };

            actual.Should().BeEquivalentTo(expected);
            result.Should().BeOfType<ReactionsCountServiceModel>();
        }

        [Fact]
        public async Task GetTotalCountMethodShouldReturnAllPostReactionsCount()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 17));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                CategoryId = 1,
                AuthorId = guid,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            var postReaction = new PostReaction
            {
                Id = 1,
                PostId = 1,
                AuthorId = guid,
                ReactionType = ReactionType.Like,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.PostReactions.AddAsync(postReaction);
            await db.SaveChangesAsync();

            var postReactionsService = new ReactionsService(dateTimeProvider.Object, db);
            var count = await postReactionsService.GetTotalCountAsync();

            count.Should().Be(1);
        }
    }
}

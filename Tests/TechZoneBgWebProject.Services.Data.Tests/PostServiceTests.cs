namespace TechZoneBgWebProject.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Moq;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Providers;
    using Xunit;

    public class PostServiceTests
    {
        [Theory]
        [InlineData("Title 1", "Description 1", 1)]
        [InlineData("Title 2", "Description 2", 2)]
        [InlineData("Title 3", "Description 3", 3)]
        public async Task EditMethodShouldWorkCorrectly(string title, string description, int categoryId)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                Type = PostType.Discussion,
                CreatedOn = dateTimeProvider.Object.Now(),
                CategoryId = 1,
                AuthorId = guid,
                Tags = new List<PostTag>
                {
                    new PostTag { TagId = 1 },
                },
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            await postsService.EditAsync(1, title, description, categoryId, new[] { 1, 2, 3 });

            var actual = await db.Posts.FirstOrDefaultAsync();
            var expected = new Post
            {
                Id = 1,
                Title = title,
                Description = description,
                Type = PostType.Discussion,
                CreatedOn = dateTimeProvider.Object.Now(),
                ModifiedOn = actual.ModifiedOn,
                CategoryId = categoryId,
                AuthorId = guid,
                Tags = new List<PostTag>
                {
                    new PostTag { TagId = 1, PostId = 1, Post = post },
                    new PostTag { TagId = 2, PostId = 1, Post = post },
                    new PostTag { TagId = 3, PostId = 1, Post = post },
                },
            };

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("Title 1", PostType.Discussion, "Description 1", 1)]
        [InlineData("Title 2", PostType.Image, "Description 2", 2)]
        [InlineData("Title 3", PostType.Video, "Description 3", 3)]
        public async Task ViewMethodIncreasePostViewsByOne(string title, PostType type, string description, int categoryId)
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = title,
                Description = description,
                Type = type,
                CategoryId = categoryId,
                AuthorId = guid,
                CreatedOn = dateTimeProvider.Object.Now(),
                Tags = new List<PostTag>
                {
                    new PostTag { TagId = 1 },
                },
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            await postsService.ViewAsync(1);

            var actual = await db.Posts.FirstOrDefaultAsync();

            actual.Views.Should().Be(1);
        }

        [Fact]
        public async Task PinMethodShouldSetIsPinnedToTrueIfPostWasNotPinned()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = guid,
                IsPinned = false,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var isPinned = await postsService.PinAsync(1);

            isPinned.Should().BeTrue();
        }

        [Fact]
        public async Task PinMethodShouldSetIsPinnedToFalseIfPostWasPinned()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = guid,
                IsPinned = true,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var isPinned = await postsService.PinAsync(1);

            isPinned.Should().BeFalse();
        }

        [Fact]
        public async Task IsExistingMethodShouldReturnTrueIfPostExists()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = guid,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var isExisting = await postsService.IsExistingAsync(1);

            isExisting.Should().BeTrue();
        }

        [Fact]
        public async Task IsExistingMethodShouldReturnFalseIfPostNotExists()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var isExisting = await postsService.IsExistingAsync(1);

            isExisting.Should().BeFalse();
        }

        [Fact]
        public async Task IsExistingMethodShouldReturnFalseIfPostIsDeleted()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title",
                Description = "Test description",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = guid,
                IsDeleted = true,
                CreatedOn = dateTimeProvider.Object.Now(),
                DeletedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var isExisting = await postsService.IsExistingAsync(1);

            isExisting.Should().BeFalse();
        }

        [Fact]
        public async Task GetCountMethodShouldCountAllNotDeletedPosts()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Test title 1",
                    Description = "Test description 1",
                    Type = PostType.Discussion,
                    CategoryId = 1,
                    AuthorId = guid,
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
                new Post
                {
                    Id = 2,
                    Title = "Test title 2",
                    Description = "Test description 2",
                    Type = PostType.Discussion,
                    CategoryId = 2,
                    AuthorId = guid,
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
                new Post
                {
                    Id = 3,
                    Title = "Test title 3",
                    Description = "Test description 3",
                    Type = PostType.Discussion,
                    CategoryId = 2,
                    AuthorId = guid,
                    IsDeleted = true,
                    CreatedOn = dateTimeProvider.Object.Now(),
                    DeletedOn = dateTimeProvider.Object.Now(),
                },
            };

            await db.Posts.AddRangeAsync(posts);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var count = await postsService.GetCountAsync();

            count.Should().Be(2);
        }

        [Fact]
        public async Task GetFollowingCountMethodShouldCountFollowingUsersPosts()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = guid,
                    UserName = "Test user 1",
                    Email = "user1@test.com",
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
                new ApplicationUser
                {
                    Id = "123",
                    UserName = "Test user 2",
                    Email = "user2@test.com",
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
            };

            var posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Test title 1",
                    Description = "Test description 1",
                    Type = PostType.Discussion,
                    CategoryId = 1,
                    AuthorId = guid,
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
                new Post
                {
                    Id = 2,
                    Title = "Test title 2",
                    Description = "Test description 2",
                    Type = PostType.Discussion,
                    CategoryId = 2,
                    AuthorId = guid,
                    CreatedOn = dateTimeProvider.Object.Now(),
                },
            };

            var userFollower = new UserFollower
            {
                User = users[0],
                Follower = users[1],
            };

            await db.Users.AddRangeAsync(users);
            await db.Posts.AddRangeAsync(posts);
            await db.UsersFollowers.AddAsync(userFollower);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var count = await postsService.GetFollowingCountAsync("123");

            count.Should().Be(posts.Count);
        }

        [Fact]
        public async Task GetAuthorIdByIdMethodShouldReturnPostAuthorId()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title 1",
                Description = "Test description 1",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = "Test author id",
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var authorId = await postsService.GetAuthorIdByIdAsync(1);

            authorId.Should().BeSameAs(post.AuthorId);
        }

        [Fact]
        public async Task GetAuthorIdByIdMethodShouldReturnNullIfPostIsDeleted()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title 1",
                Description = "Test description 1",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = "Test author id",
                IsDeleted = true,
                CreatedOn = dateTimeProvider.Object.Now(),
                DeletedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var authorId = await postsService.GetAuthorIdByIdAsync(1);

            authorId.Should().BeNull();
        }

        [Fact]
        public async Task GetLatestActivityByIdMethodShouldReturnPostLatestActivity()
        {
            var guid = Guid.NewGuid().ToString();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(guid)
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var post = new Post
            {
                Id = 1,
                Title = "Test title 1",
                Description = "Test description 1",
                Type = PostType.Discussion,
                CategoryId = 1,
                AuthorId = guid,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            await db.Posts.AddAsync(post);
            await db.SaveChangesAsync();

            var postsService = new PostsService(db, dateTimeProvider.Object, null, null);

            var latestActivity = await postsService.GetLatestActivityByIdAsync(1);

            latestActivity.Should().Be("0м");
        }
    }
}

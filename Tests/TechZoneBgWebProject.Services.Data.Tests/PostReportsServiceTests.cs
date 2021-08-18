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
    using TechZoneBgWebProject.Services.Reports;
    using Xunit;

    public class PostReportsServiceTests
    {
        [Theory]
        [InlineData("Test 1", 1)]
        [InlineData("Test 2", 2)]
        [InlineData("Test 3", 3)]
        public async Task CreateMethodShouldAddPostReportInDatabase(string description, int postId)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var postReportsService = new ReportsService(dateTimeProvider.Object, null, db);
            await postReportsService.CreateAsync(description, postId, Guid.NewGuid().ToString());

            db.PostReports.Should().HaveCount(1);
        }

        [Theory]
        [InlineData("Test 1", 1)]
        [InlineData("Test 2", 2)]
        [InlineData("Test 3", 3)]
        public async Task CreateMethodShouldAddRightPostReportInDatabase(string description, int postId)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var postReportsService = new ReportsService(dateTimeProvider.Object, null, db);

            var authorId = Guid.NewGuid().ToString();
            await postReportsService.CreateAsync(description, postId, authorId);

            var actual = await db.PostReports.FirstOrDefaultAsync();

            var expected = new PostReport
            {
                Id = 1,
                Description = description,
                PostId = postId,
                AuthorId = authorId,
                ModifiedOn = actual.ModifiedOn,
                CreatedOn = dateTimeProvider.Object.Now(),
            };

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public async Task DeleteMethodShouldReturnFalseIfReportIsNotFound()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            var postReportsService = new ReportsService(dateTimeProvider.Object, null, db);
            var deleted = await postReportsService.DeleteAsync(1);

            deleted.Should().BeFalse();
        }

        [Theory]
        [InlineData("Test 1", 1)]
        [InlineData("Test 2", 2)]
        [InlineData("Test 3", 3)]
        public async Task DeleteMethodShouldReturnTrueIfReportIsDeleted(string description, int postId)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var db = new ApplicationDbContext(options);
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(dtp => dtp.Now()).Returns(new DateTime(2021, 8, 18));

            await db.PostReports.AddAsync(new PostReport
            {
                Description = description,
                PostId = postId,
                AuthorId = Guid.NewGuid().ToString(),
                CreatedOn = dateTimeProvider.Object.Now(),
            });
            await db.SaveChangesAsync();

            var postReportsService = new ReportsService(dateTimeProvider.Object, null, db);
            var deleted = await postReportsService.DeleteAsync(1);

            deleted.Should().BeTrue();
        }
    }
}

namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;

    public class NewsSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var hicommId = dbContext.MainNewsSources.FirstOrDefault(x => x.Name == GlobalConstants.NewsSource.HiComm).Id;
            var itninewsId = dbContext.MainNewsSources.FirstOrDefault(x => x.Name == GlobalConstants.NewsSource.Itninews).Id;
            var kaldataId = dbContext.MainNewsSources.FirstOrDefault(x => x.Name == GlobalConstants.NewsSource.Kaldata).Id;

            if (!dbContext.MainNews.Any() && hicommId != 0 && itninewsId != 0 && kaldataId != 0)
            {
                dbContext.MainNews.AddRange(new[]
                {

                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[0],
                        ImageUrl = GlobalConstants.News.ImageUrl[0],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[0],
                        SourceId = hicommId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[1],
                        ImageUrl = GlobalConstants.News.ImageUrl[1],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[1],
                        SourceId = hicommId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[2],
                        ImageUrl = GlobalConstants.News.ImageUrl[2],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[2],
                        SourceId = itninewsId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[3],
                        ImageUrl = GlobalConstants.News.ImageUrl[3],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[3],
                        SourceId = itninewsId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[4],
                        ImageUrl = GlobalConstants.News.ImageUrl[4],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[4],
                        SourceId = itninewsId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[5],
                        ImageUrl = GlobalConstants.News.ImageUrl[5],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[5],
                        SourceId = kaldataId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[6],
                        ImageUrl = GlobalConstants.News.ImageUrl[6],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[6],
                        SourceId = kaldataId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNews
                    {
                        Title = GlobalConstants.News.Title[7],
                        ImageUrl = GlobalConstants.News.ImageUrl[7],
                        OriginalUrl = GlobalConstants.News.OriginalUrl[7],
                        SourceId = kaldataId,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                });

                dbContext.SaveChanges();
            }

            return Task.CompletedTask;
        }
    }
}

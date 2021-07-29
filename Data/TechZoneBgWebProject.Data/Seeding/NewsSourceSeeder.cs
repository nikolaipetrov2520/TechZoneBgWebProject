namespace TechZoneBgWebProject.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;

    public class NewsSourceSeeder : ISeeder
    {
        public Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.MainNewsSources.Any())
            {
                dbContext.MainNewsSources.AddRange(new[]
                {
                    new MainNewsSource
                    {
                        Name = GlobalConstants.NewsSource.HiComm,
                        Url = GlobalConstants.NewsSource.HiCommUrl,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNewsSource
                    {
                        Name = GlobalConstants.NewsSource.Itninews,
                        Url = GlobalConstants.NewsSource.ItninewsUrl,
                        CreatedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new MainNewsSource
                    {
                        Name = GlobalConstants.NewsSource.Kaldata,
                        Url = GlobalConstants.NewsSource.KaldataUrl,
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

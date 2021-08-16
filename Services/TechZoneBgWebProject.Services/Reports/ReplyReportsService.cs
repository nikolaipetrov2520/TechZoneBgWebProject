namespace TechZoneBgWebProject.Services.Reports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Services.Providers;

    public class ReplyReportsService : IReplyReportsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly IDateTimeProvider dateTimeProvider;

        public ReplyReportsService(IDateTimeProvider dateTimeProvider, IMapper mapper, ApplicationDbContext db)
        {
            this.dateTimeProvider = dateTimeProvider;
            this.mapper = mapper;
            this.db = db;
        }

        public async Task CreateAsync(string description, int replyId, string authorId)
        {
            var replyReport = new ReplyReport
            {
                Description = description,
                ReplyId = replyId,
                AuthorId = authorId,
                CreatedOn = this.dateTimeProvider.Now(),
            };

            await this.db.ReplyReports.AddAsync(replyReport);
            await this.db.SaveChangesAsync();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAllAsync<TModel>()
        {
            throw new NotImplementedException();
        }

        public async Task<TModel> GetByIdAsync<TModel>(int id)
            => await this.db.ReplyReports
                .AsNoTracking()
                .Where(r => r.Id == id && !r.IsDeleted)
                .ProjectTo<TModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
    }
}

namespace TechZoneBgWebProject.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;

    public class ReplyReportConfiguration : IEntityTypeConfiguration<ReplyReport>
    {
        public void Configure(EntityTypeBuilder<ReplyReport> replyReport)
        {
            replyReport
                .Property(rr => rr.Description)
                .HasMaxLength(GlobalConstants.Replies.ReplyReportDescriptionMaxLength)
                .IsRequired();

            replyReport
                .HasOne(rr => rr.Author)
                .WithMany(a => a.ReplyReports)
                .HasForeignKey(rr => rr.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            replyReport
                .HasOne(rr => rr.Reply)
                .WithMany(r => r.Reports)
                .HasForeignKey(rr => rr.ReplyId)
                .OnDelete(DeleteBehavior.Restrict);

            replyReport
                .HasIndex(rr => rr.IsDeleted);
        }
    }
}

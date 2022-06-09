namespace TechZoneBgWebProject.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TechZoneBgWebProject.Data.Models;

    public class CheckListsChecksConfiguration : IEntityTypeConfiguration<CheckListsChecks>
    {
        public void Configure(EntityTypeBuilder<CheckListsChecks> builder)
        {
            builder
                .HasKey(cp => new { cp.CheckListId, cp.CheckId });

            builder
                .HasOne(cp => cp.Check)
                .WithMany(p => p.CheckListChecks)
                .HasForeignKey(cp => cp.CheckId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cp => cp.CheckList)
                .WithMany(t => t.CheckListChecks)
                .HasForeignKey(cp => cp.CheckListId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

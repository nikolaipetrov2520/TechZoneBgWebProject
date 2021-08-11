﻿namespace TechZoneBgWebProject.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> post)
        {
            post
                .Property(p => p.Title)
                .HasMaxLength(GlobalConstants.Post.PostTitleMaxLength)
                .IsRequired();

            post
                .Property(p => p.Description)
                .HasMaxLength(GlobalConstants.Post.PostDescriptionMaxLength)
                .IsRequired();

            post
                .HasOne(p => p.Author)
                .WithMany(a => a.Posts)
                .HasForeignKey(p => p.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            post
                .HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            post
                .HasIndex(p => p.IsDeleted);
        }
    }
}

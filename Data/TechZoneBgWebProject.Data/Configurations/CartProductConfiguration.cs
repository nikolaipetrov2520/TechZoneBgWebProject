namespace TechZoneBgWebProject.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TechZoneBgWebProject.Data.Models;

    public class CartProductConfiguration : IEntityTypeConfiguration<CartProduct>
    {
        public void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            builder
                .HasKey(cp => new { cp.CartId, cp.ProductId });

            builder
                .HasOne(cp => cp.Cart)
                .WithMany(p => p.Products)
                .HasForeignKey(cp => cp.CartId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cp => cp.Product)
                .WithMany(t => t.Carts)
                .HasForeignKey(cp => cp.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ProductMAP : IEntityMappingConfiguration<Product>
    {
        public void Map(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("ProductMaster");
            builder.HasKey(m => m.ProductId);
            builder.Property(m => m.ProductId).IsRequired().HasColumnName("ProductId");
            builder.Property(m => m.ProductName).IsRequired().HasColumnName("(ProductName");
            builder.Property(m => m.ProductDescription).IsRequired().HasColumnName("ProductDescription");
            builder.Property(m => m.ProductSEOId).HasColumnName("ProductSEOId");
            builder.Property(m => m.ProductImageId).HasColumnName("ProductImageId");
            builder.Property(m => m.ProductIsMenu).IsRequired().HasColumnName("ProductIsMenu");
            builder.Property(m => m.ProductIsActive).IsRequired().HasColumnName("ProductIsActive");
            builder.Property(m => m.ProductCreatedDate).HasColumnName("ProductCreatedDate");
            builder.Property(m => m.ProductChangedDate).HasColumnName("ProductChangedDate");
            builder.Property(m => m.ProductChangedBy).HasColumnName("ProductChangedBy");
        }
    }
}

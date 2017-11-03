using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class productMAP : IEntityMappingConfiguration<product>
    {
        public void Map(EntityTypeBuilder<product> builder)
        {
            builder.ToTable("ProductMaster");
            builder.HasKey(m => m.productId);
            builder.Property(m => m.productId).IsRequired().HasColumnName("ProductId");
            builder.Property(m => m.productName).IsRequired().HasColumnName("(ProductName");
            builder.Property(m => m.productDescription).IsRequired().HasColumnName("ProductDescription");
            builder.Property(m => m.productSEOId).HasColumnName("ProductSEOId");
            builder.Property(m => m.productImageId).HasColumnName("ProductImageId");
            builder.Property(m => m.productIsMenu).IsRequired().HasColumnName("ProductIsMenu");
            builder.Property(m => m.productIsActive).IsRequired().HasColumnName("ProductIsActive");
            builder.Property(m => m.productCreatedDate).HasColumnName("ProductCreatedDate");
            builder.Property(m => m.productChangedDate).HasColumnName("ProductChangedDate");
            builder.Property(m => m.productChangedBy).HasColumnName("ProductChangedBy");
        }
    }
}

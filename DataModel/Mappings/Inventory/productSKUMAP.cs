using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ProductSKUMAP : IEntityMappingConfiguration<ProductSKU>
    {
        public void Map(EntityTypeBuilder<ProductSKU> builder)
        {
            builder.ToTable("SKUMaster");
            builder.HasKey(m => m.ProductSKUID);
            builder.Property(m => m.ProductSKUID).HasColumnName("SKUID");
            builder.Property(m => m.ProductSKUCompanyId).IsRequired().HasColumnName("SKUCompanyID ");
            builder.Property(m => m.ProductSKUBrandId).HasColumnName("SKUBrandID");
            builder.Property(m => m.ProductSKUProductId).HasColumnName("SKUProductId");
            builder.Property(m => m.ProductSKUCategoryMappingId).HasColumnName("SKUCategoryMappingID");
            builder.Property(m => m.ProductSKUISActive).HasColumnName("SKUIsActive");
            builder.Property(m => m.ProductSKUCreatedDate).HasColumnName("SKUCreatedOn");
            builder.Property(m => m.ProductSKUChangeDate).HasColumnName("SKUChangedOn");
            builder.Property(m => m.ProductSKUChangeBY).HasColumnName("SKUChangedBy");
        }
    }
}

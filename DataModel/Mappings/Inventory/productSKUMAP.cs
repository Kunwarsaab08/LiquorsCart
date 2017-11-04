using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class ProductSKUMAP : IEntityMappingConfiguration<ProductSKU>
    {
        public void Map(EntityTypeBuilder<ProductSKU> builder)
        {
            builder.ToTable("SKUMaster");
            builder.HasKey(m => m.ProductSKUID);
            builder.Property(m => m.ProductSKUID).HasColumnName("SKUID");
            builder.Property(m => m.ProductSKUCompanyId.CompanyId).IsRequired().HasColumnName("SKUCompanyID ");
            builder.Property(m => m.ProductSKUBrandId.BrandId).HasColumnName("SKUBrandID");
            builder.Property(m => m.ProductSKUProductId.ProductId).HasColumnName("SKUProductId");
            builder.Property(m => m.ProductSKUCategoryMappingId.CategoryMappingId).HasColumnName("SKUCategoryMappingID");
            builder.Property(m => m.ProductSKUISActive).HasColumnName("SKUIsActive");
            builder.Property(m => m.ProductSKUCreatedDate).HasColumnName("SKUCreatedOn");
            builder.Property(m => m.ProductSKUChangeDate).HasColumnName("SKUChangedOn");
            builder.Property(m => m.ProductSKUChangeBY).HasColumnName("SKUChangedBy");
        }
    }
}

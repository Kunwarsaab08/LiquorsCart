using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class productSKUMAP : IEntityMappingConfiguration<productSKU>
    {
        public void Map(EntityTypeBuilder<productSKU> builder)
        {
            builder.ToTable("SKUMaster");
            builder.HasKey(m => m.productSKUID);
            builder.Property(m => m.productSKUID).HasColumnName("SKUID");
            builder.Property(m => m.productSKUCompanyId).IsRequired().HasColumnName("SKUCompanyID ");
            builder.Property(m => m.productSKUBrandId).HasColumnName("SKUBrandID");
            builder.Property(m => m.productSKUProductId).HasColumnName("SKUProductId");
            builder.Property(m => m.productSKUCategoryMappingId).HasColumnName("SKUCategoryMappingID");
            builder.Property(m => m.productSKUISActive).HasColumnName("SKUIsActive");
            builder.Property(m => m.productSKUCreatedDate).HasColumnName("SKUCreatedOn");
            builder.Property(m => m.productSKUChangeDate).HasColumnName("SKUChangedOn");
            builder.Property(m => m.productSKUChangeBY).HasColumnName("SKUChangedBy");
        }
    }
}

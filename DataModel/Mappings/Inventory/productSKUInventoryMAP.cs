using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class productSKUInventoryMAP : IEntityMappingConfiguration<productSKUInventory>
    {
        public void Map(EntityTypeBuilder<productSKUInventory> builder)
        {
            builder.ToTable("SKUInventory");
            builder.HasKey(m => m.productSKUInventoryId);
            builder.Property(m => m.productSKUInventoryId).HasColumnName("SKUInventoryId");
            builder.Property(m => m.productSKUId).IsRequired().HasColumnName("SKUID ");
            builder.Property(m => m.productSKUQty).HasColumnName("SKUQTY");
            builder.Property(m => m.productSKUMinOrderQty).HasColumnName("SKUMInOrderQTY");
            builder.Property(m => m.productSKUMinLevelIndicator).HasColumnName("SKUMinLevelIndicator");
            builder.Property(m => m.productSKUInventoryCreatedDate).HasColumnName("SKUInventoryCreatedOn");
            builder.Property(m => m.productSKUInventoryChangeDate).HasColumnName("SKUInventoryChangedOn");
            builder.Property(m => m.productSKUInventoryChangeBy).HasColumnName("SKUInventoryChangedBy");
        }
    }
}

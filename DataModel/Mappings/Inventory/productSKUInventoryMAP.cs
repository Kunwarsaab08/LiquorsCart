using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ProductSKUInventoryMAP : IEntityMappingConfiguration<ProductSKUInventory>
    {
        public void Map(EntityTypeBuilder<ProductSKUInventory> builder)
        {
            builder.ToTable("SKUInventory");
            builder.HasKey(m => m.ProductSKUInventoryId);
            builder.Property(m => m.ProductSKUInventoryId).HasColumnName("SKUInventoryId");
            builder.Property(m => m.ProductSKUId).IsRequired().HasColumnName("SKUID ");
            builder.Property(m => m.ProductSKUQty).HasColumnName("SKUQTY");
            builder.Property(m => m.ProductSKUMinOrderQty).HasColumnName("SKUMInOrderQTY");
            builder.Property(m => m.ProductSKUMinLevelIndicator).HasColumnName("SKUMinLevelIndicator");
            builder.Property(m => m.ProductSKUInventoryCreatedDate).HasColumnName("SKUInventoryCreatedOn");
            builder.Property(m => m.ProductSKUInventoryChangeDate).HasColumnName("SKUInventoryChangedOn");
            builder.Property(m => m.ProductSKUInventoryChangeBy).HasColumnName("SKUInventoryChangedBy");
        }
    }
}

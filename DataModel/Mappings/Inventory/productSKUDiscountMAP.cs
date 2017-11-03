using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class productSKUDiscountMAP : IEntityMappingConfiguration<productSKUDiscount>
    {
        public void Map(EntityTypeBuilder<productSKUDiscount> builder)
        {
            builder.ToTable("SKUDiscount");
            builder.HasKey(m => m.productSKUDiscountId);
            builder.Property(m => m.productSKUDiscountId).HasColumnName("DiscountId");
            builder.Property(m => m.productSKUID).IsRequired().HasColumnName("SKUID ");
            builder.Property(m => m.productSKUDiscountPercent).HasColumnName("SKUDiscountPercent");
            builder.Property(m => m.productSKUDiscountIsActive).HasColumnName("SKUDiscountIsActive");
            builder.Property(m => m.productSKUDiscountCreatedDate).HasColumnName("SKUDiscountCreatedOn");
            builder.Property(m => m.productSKUDiscountChangeDate).HasColumnName("SKUDiscountChangedOn");
            builder.Property(m => m.productSKUDiscountChangeBy).HasColumnName("SKUDiscountChangedBy");
        }
    }
}

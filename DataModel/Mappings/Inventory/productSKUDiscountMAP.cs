using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ProductSKUDiscountMAP : IEntityMappingConfiguration<ProductSKUDiscount>
    {
        public void Map(EntityTypeBuilder<ProductSKUDiscount> builder)
        {
            builder.ToTable("SKUDiscount");
            builder.HasKey(m => m.ProductSKUDiscountId);
            builder.Property(m => m.ProductSKUDiscountId).HasColumnName("DiscountId");
            builder.Property(m => m.ProductSKUID).IsRequired().HasColumnName("SKUID ");
            builder.Property(m => m.ProductSKUDiscountPercent).HasColumnName("SKUDiscountPercent");
            builder.Property(m => m.ProductSKUDiscountIsActive).HasColumnName("SKUDiscountIsActive");
            builder.Property(m => m.ProductSKUDiscountCreatedDate).HasColumnName("SKUDiscountCreatedOn");
            builder.Property(m => m.ProductSKUDiscountChangeDate).HasColumnName("SKUDiscountChangedOn");
            builder.Property(m => m.ProductSKUDiscountChangeBy).HasColumnName("SKUDiscountChangedBy");
        }
    }
}

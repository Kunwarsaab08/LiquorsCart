using LiquorsCart.ServerSide.DataModel.DataModels.Vendor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Vendor
{
    public class VendorSKUInventoryMAP : IEntityMappingConfiguration<VendorSKU>
    {
        public void Map(EntityTypeBuilder<VendorSKU> builder)
        {
            builder.ToTable("SKUVendor");
            builder.HasKey(m => m.VendorSKUID);
            builder.Property(m => m.VendorSKUID).HasColumnName("SKUVendorId");
            builder.Property(m => m.VendorId).HasColumnName("VendorID ");
            builder.Property(m => m.VendorSKUProductID).HasColumnName("SKUID");
            builder.Property(m => m.VendorSKUProductQty).HasColumnName("SKUVendorQty");
            builder.Property(m => m.VendorSKUIsActive).HasColumnName("SKUVendorIsActive");
            builder.Property(m => m.VendorSKUCreatedDate).HasColumnName("SKUVendorCreatedOn");
            builder.Property(m => m.VendorSKUChangeDate).HasColumnName("SKUVendorChangedOn");
            builder.Property(m => m.VendorSKKUChangeBy).HasColumnName("SKUVendorChangedBy");
        }
    }
}

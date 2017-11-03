using System;
using DataModel.DataModels.Vendor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Vendor
{
    public class vendorSKUInventoryMAP : IEntityMappingConfiguration<vendorSKU>
    {
        public void Map(EntityTypeBuilder<vendorSKU> builder)
        {
            builder.ToTable("SKUVendor");
            builder.HasKey(m => m.vendorSKUID);
            builder.Property(m => m.vendorSKUID).HasColumnName("SKUVendorId");
            builder.Property(m => m.vendorId).IsRequired().HasColumnName("VendorID ");
            builder.Property(m => m.vendorSKUProductID).HasColumnName("SKUID");
            builder.Property(m => m.vendorSKUProductQty).HasColumnName("SKUVendorQty");
            builder.Property(m => m.vendorSKUIsActive).HasColumnName("SKUVendorIsActive");
            builder.Property(m => m.vendorSKUCreatedDate).HasColumnName("SKUVendorCreatedOn");
            builder.Property(m => m.vendorSKUChangeDate).HasColumnName("SKUVendorChangedOn");
            builder.Property(m => m.vendorSKKUChangeBy).HasColumnName("SKUVendorChangedBy");
        }
    }
}

using System;
using DataModel.DataModels.Vendor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Vendor
{
    public class vendorMAP : IEntityMappingConfiguration<vendor>
    {
        public void Map(EntityTypeBuilder<vendor> builder)
        {
            builder.ToTable("VendorMaster");
            builder.HasKey(m => m.vendorID);
            builder.Property(m => m.vendorID).HasColumnName("VendorId");
            builder.Property(m => m.vendorName).IsRequired().HasColumnName("VendorName");
            builder.Property(m => m.vendorAddress1).HasColumnName("VendorAddress1");
            builder.Property(m => m.vemdorAddress2).HasColumnName("VendorAddress2");
            builder.Property(m => m.vendorAddress3).HasColumnName("VendorAddress3");
            builder.Property(m => m.vendorZIPcode).HasColumnName("VendorZipCode");
            builder.Property(m => m.vendorOwnerName).HasColumnName("VendorOwnerName");
            builder.Property(m => m.vendorOwnerPhoneNo).HasColumnName("VendorOwnerPhoneNo");
            builder.Property(m => m.vendorShopPhoneNo).HasColumnName("VendorShopPhoneNo");
            builder.Property(m => m.vendorTINno).HasColumnName("VendorTINNO");
            builder.Property(m => m.vendorPANno).HasColumnName("VendorPANNO");
            builder.Property(m => m.vendorTANno).HasColumnName("VendorTANNO");
            builder.Property(m => m.vendorSALESTAXno).HasColumnName("VendorSalesTaxNo");
            builder.Property(m => m.vendorLicenceno).HasColumnName("VendorLicenceNo");
            builder.Property(m => m.vendorIsActive).HasColumnName("VendorIsActive");
            builder.Property(m => m.vendorCreatedDate).HasColumnName("VendorCreatedOn");
            builder.Property(m => m.vendorChangeDate).HasColumnName("VendorChangedOn");
            builder.Property(m => m.vendorChangeBy).HasColumnName("VendorChangedBy");
        }
    }
}

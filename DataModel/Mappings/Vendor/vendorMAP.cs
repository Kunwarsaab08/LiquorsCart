using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Vendor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Vendor
{
    public class VendorMAP : IEntityMappingConfiguration<DataModel.DataModels.Vendor.Vendor>
    {
        public void Map(EntityTypeBuilder<DataModel.DataModels.Vendor.Vendor> builder)
        {
            builder.ToTable("VendorMaster");
            builder.HasKey(m => m.VendorID);
            builder.Property(m => m.VendorID).HasColumnName("VendorId");
            builder.Property(m => m.VendorName).IsRequired().HasColumnName("VendorName");
            builder.Property(m => m.VendorAddress1).HasColumnName("VendorAddress1");
            builder.Property(m => m.VemdorAddress2).HasColumnName("VendorAddress2");
            builder.Property(m => m.VendorAddress3).HasColumnName("VendorAddress3");
            builder.Property(m => m.VendorZIPcode).HasColumnName("VendorZipCode");
            builder.Property(m => m.VendorOwnerName).HasColumnName("VendorOwnerName");
            builder.Property(m => m.VendorOwnerPhoneNo).HasColumnName("VendorOwnerPhoneNo");
            builder.Property(m => m.VendorShopPhoneNo).HasColumnName("VendorShopPhoneNo");
            builder.Property(m => m.VendorTINno).HasColumnName("VendorTINNO");
            builder.Property(m => m.VendorPANno).HasColumnName("VendorPANNO");
            builder.Property(m => m.VendorTANno).HasColumnName("VendorTANNO");
            builder.Property(m => m.VendorSALESTAXno).HasColumnName("VendorSalesTaxNo");
            builder.Property(m => m.VendorLicenceno).HasColumnName("VendorLicenceNo");
            builder.Property(m => m.VendorIsActive).HasColumnName("VendorIsActive");
            builder.Property(m => m.VendorCreatedDate).HasColumnName("VendorCreatedOn");
            builder.Property(m => m.VendorChangeDate).HasColumnName("VendorChangedOn");
            builder.Property(m => m.VendorChangeBy).HasColumnName("VendorChangedBy");
        }
    }
}

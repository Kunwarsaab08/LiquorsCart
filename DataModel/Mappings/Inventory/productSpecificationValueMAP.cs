using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class productSpecificationValueMAP : IEntityMappingConfiguration<productSpecification>
    {
        public void Map(EntityTypeBuilder<productSpecification> builder)
        {
            builder.ToTable("ProductSpecification");
            builder.HasKey(m => m.productSpecificationID);
            builder.Property(m => m.productSpecificationID).HasColumnName("ProductSpecificationId");
            builder.Property(m => m.productID).IsRequired().HasColumnName("ProductId ");
            builder.Property(m => m.productSpecificationID).HasColumnName("SpecificationId");
            builder.Property(m => m.productSpecificationValuesID).HasColumnName("SpecificationValueId");
            builder.Property(m => m.productSpecificationISActive).HasColumnName("ProductSpecificationIsActive");
            builder.Property(m => m.productSpecificationCreatedDate).HasColumnName("SpecificationValueCreatedOn");
            builder.Property(m => m.productSpecificationChangeDate).HasColumnName("ProductSpecificationChangedOn");
            builder.Property(m => m.productSpecificationChangeBy).HasColumnName("ProductSpecificationChangedBy");
        }
    }
}

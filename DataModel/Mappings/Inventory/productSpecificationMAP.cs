using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ProductSpecificationMAP : IEntityMappingConfiguration<ProductSpecification>
    {
        public void Map(EntityTypeBuilder<ProductSpecification> builder)
        {
            builder.ToTable("ProductSpecification");
            builder.HasKey(m => m.ProductSpecificationID);
            builder.Property(m => m.ProductSpecificationID).HasColumnName("ProductSpecificationId");
            builder.Property(m => m.ProductID).IsRequired().HasColumnName("ProductId ");
            builder.Property(m => m.ProductSpecificationsID).HasColumnName("SpecificationId");
            builder.Property(m => m.ProductSpecificationValuesID).HasColumnName("SpecificationValueId");
            builder.Property(m => m.ProductSpecificationISActive).HasColumnName("ProductSpecificationIsActive");
            builder.Property(m => m.ProductSpecificationCreatedDate).HasColumnName("SpecificationValueCreatedOn");
            builder.Property(m => m.ProductSpecificationChangeDate).HasColumnName("ProductSpecificationChangedOn");
            builder.Property(m => m.ProductSpecificationChangeBy).HasColumnName("ProductSpecificationChangedBy");
        }
    }
}

using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class specificationMAP : IEntityMappingConfiguration<specification>
    {
        public void Map(EntityTypeBuilder<specification> builder)
        {
            builder.ToTable("SpecificationMaster");
            builder.HasKey(m => m.specificationID);
            builder.Property(m => m.specificationID).HasColumnName("SpecificationID");
            builder.Property(m => m.specificationDescription).IsRequired().HasColumnName("SpecificationDescription");
            builder.Property(m => m.specificationIsActive).IsRequired().HasColumnName("SpecificationIsActive");
            builder.Property(m => m.specificationCreatedDate).HasColumnName("SpecificationCreatedOn");
            builder.Property(m => m.specificationChangedDate).HasColumnName("SpecificationChangedOn");
            builder.Property(m => m.specificationChangeBy).HasColumnName("SpecificationChangedBy");
        }
    }
}

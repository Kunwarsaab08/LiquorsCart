using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class specificationValuesMAP : IEntityMappingConfiguration<specificationValue>
    {
        public void Map(EntityTypeBuilder<specificationValue> builder)
        {
            builder.ToTable("SpecificationValuesMaster");
            builder.HasKey(m => m.specificationValueId);
            builder.Property(m => m.specificationValueId).HasColumnName("SpecificationValueID");
            builder.Property(m => m.specificationDesc).IsRequired().HasColumnName("SpecificationValue ");
            builder.Property(m => m.specificationValuesIsActive).IsRequired().HasColumnName("SpecificationValueIsActive");
            builder.Property(m => m.specificationValueCreatedDate).HasColumnName("SpecificationValueCreatedOn");
            builder.Property(m => m.specificationValueChangeDate).HasColumnName("SpecificationValueChangedOn");
            builder.Property(m => m.specificationValueChangeBy).HasColumnName("SpecificationValueChangedBy");
        }
    }
}

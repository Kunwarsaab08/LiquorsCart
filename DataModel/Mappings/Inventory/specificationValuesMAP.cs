using System;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class SpecificationValuesMAP : IEntityMappingConfiguration<SpecificationValue>
    {
        public void Map(EntityTypeBuilder<SpecificationValue> builder)
        {
            builder.ToTable("SpecificationValuesMaster");
            builder.HasKey(m => m.SpecificationValueId);
            builder.Property(m => m.SpecificationValueId).HasColumnName("SpecificationValueID");
            builder.Property(m => m.SpecificationDesc).IsRequired().HasColumnName("SpecificationValue ");
            builder.Property(m => m.SpecificationValuesIsActive).IsRequired().HasColumnName("SpecificationValueIsActive");
            builder.Property(m => m.SpecificationValueCreatedDate).HasColumnName("SpecificationValueCreatedOn");
            builder.Property(m => m.SpecificationValueChangeDate).HasColumnName("SpecificationValueChangedOn");
            builder.Property(m => m.SpecificationValueChangeBy).HasColumnName("SpecificationValueChangedBy");
        }
    }
}

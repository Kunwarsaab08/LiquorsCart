﻿using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class SpecificationMAP : IEntityMappingConfiguration<Specification>
    {
        public void Map(EntityTypeBuilder<Specification> builder)
        {
            builder.ToTable("SpecificationMaster");
            builder.HasKey(m => m.SpecificationID);
            builder.Property(m => m.SpecificationID).HasColumnName("SpecificationID");
            builder.Property(m => m.SpecificationDescription).HasColumnName("SpecificationDescription");
            builder.Property(m => m.SpecificationIsActive).HasColumnName("SpecificationIsActive");
            builder.Property(m => m.SpecificationCreatedDate).HasColumnName("SpecificationCreatedOn");
            builder.Property(m => m.SpecificationChangedDate).HasColumnName("SpecificationChangedOn");
            builder.Property(m => m.SpecificationChangeBy).HasColumnName("SpecificationChangedBy");
        }
    }
}

﻿using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class CategoryMappingMAP : IEntityMappingConfiguration<CategoryMappings>
    {
        public void Map(EntityTypeBuilder<CategoryMappings> builder)
        {
            builder.ToTable("CategoryMappings");
            builder.HasKey(m => m.CategoryMappingId);
            builder.Property(m => m.CategoryMappingId).HasColumnName("CategoryMappingId");
            builder.Property(m => m.MainCategoryId).HasColumnName("CategoryId");
            builder.Property(m => m.SubCategoryId).HasColumnName("SubCategoryId");
            builder.Property(m => m.TypeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.CategoryMappingIsActive).HasColumnName("CategoryMappingIsActive");
            builder.Property(m => m.CategoryMappingCreatedDate).HasColumnName("CategoryMappingCreatedDate ");
            builder.Property(m => m.CategoryMappingChangeDate).HasColumnName("CategoryMappingChangedDate");
            builder.Property(m => m.CategoryChangeBy).HasColumnName("CategoryMappingChangedBy");
        }
    }
}

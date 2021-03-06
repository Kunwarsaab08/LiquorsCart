﻿using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class BrandMAP : IEntityMappingConfiguration<Brand>
    {
        public void Map(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("BrandMaster");
            builder.HasKey(m => m.BrandId);
            builder.Property(m => m.BrandId)
                   .HasColumnName("BrandId");
            builder.Property(m => m.CompanyId).HasColumnName("(BrandCompanyId");            
            builder.Property(m => m.BrandDescription).HasColumnName("BrandDescription");
            builder.Property(m => m.BrandSEOId).HasColumnName("BrandSEOId");
            builder.Property(m => m.BrandImageId).HasColumnName("BrandImageId");
            builder.Property(m => m.BrandIsMenu).HasColumnName("BrandIsMenu");
            builder.Property(m => m.BrandIsActive).HasColumnName("BrandIsActive");
            builder.Property(m => m.BrandCreatedDate).HasColumnName("BrandCreatedDate");
            builder.Property(m => m.BrandChangeDate).HasColumnName("BrandChangedDate");
            builder.Property(m => m.BrandChangeby).HasColumnName("BrandChangedBy");
        }
    }
}

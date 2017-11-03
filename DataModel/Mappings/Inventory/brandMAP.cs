using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class brandMAP : IEntityMappingConfiguration<brand>
    {
        public void Map(EntityTypeBuilder<brand> builder)
        {
            builder.ToTable("BrandMaster");
            builder.HasKey(m => m.brandId);
            builder.Property(m => m.brandId).IsRequired().HasColumnName("BrandId");
            builder.Property(m => m.company).HasColumnName("(BrandCompanyId");            
            builder.Property(m => m.brandDescription).IsRequired().HasColumnName("BrandDescription");
            builder.Property(m => m.brandSEOId).HasColumnName("BrandSEOId");
            builder.Property(m => m.brandImageId).HasColumnName("BrandImageId");
            builder.Property(m => m.brandIsMenu).IsRequired().HasColumnName("BrandIsMenu");
            builder.Property(m => m.brandIsActive).IsRequired().HasColumnName("BrandIsActive");
            builder.Property(m => m.brandCreatedDate).HasColumnName("BrandCreatedDate");
            builder.Property(m => m.brandChangeDate).HasColumnName("BrandChangedDate");
            builder.Property(m => m.brandChangeby).HasColumnName("BrandChangedBy");
        }
    }
}

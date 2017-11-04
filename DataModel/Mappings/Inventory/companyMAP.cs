using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class CompanyMAP : IEntityMappingConfiguration<Company>
    {
        public void Map(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("CompanyMaster");
            builder.HasKey(m => m.CompanyId);
            builder.Property(m => m.CompanyId).HasColumnName("CompanyId");
            builder.Property(m => m.CompanyName).IsRequired().HasColumnName("CompanyName");
            builder.Property(m => m.CompanyDescription).IsRequired().HasColumnName("CompanyDescription");
            builder.Property(m => m.CompanySEOId).HasColumnName("CompanySEOId");
            builder.Property(m => m.CompanyImageId).HasColumnName("CompanyImageId");
            builder.Property(m => m.CompanyIsMenu).IsRequired().HasColumnName("CompanyIsMenu");
            builder.Property(m => m.CompanyIsActive).IsRequired().HasColumnName("CompanyIsActive");
            builder.Property(m => m.CompanyCreatedDate).HasColumnName("CompanyCreatedDate");
            builder.Property(m => m.CompanyChangeDate).HasColumnName("CompanyChangedDate");
            builder.Property(m => m.CompanyChangeBy).HasColumnName("CompanyChangedBy");
        }
    }
}

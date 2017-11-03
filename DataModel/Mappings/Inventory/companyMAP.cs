using System;
using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class companyMAP : IEntityMappingConfiguration<company>
    {
        public void Map(EntityTypeBuilder<company> builder)
        {
            builder.ToTable("CompanyMaster");
            builder.HasKey(m => m.companyId);
            builder.Property(m => m.companyId).HasColumnName("CompanyId");
            builder.Property(m => m.companyName).IsRequired().HasColumnName("CompanyName");
            builder.Property(m => m.companyDescription).IsRequired().HasColumnName("CompanyDescription");
            builder.Property(m => m.companySEOId).HasColumnName("CompanySEOId");
            builder.Property(m => m.companyImageId).HasColumnName("CompanyImageId");
            builder.Property(m => m.companyIsMenu).IsRequired().HasColumnName("CompanyIsMenu");
            builder.Property(m => m.companyIsActive).IsRequired().HasColumnName("CompanyIsActive");
            builder.Property(m => m.companyCreatedDate).HasColumnName("CompanyCreatedDate");
            builder.Property(m => m.companyChangeDate).HasColumnName("CompanyChangedDate");
            builder.Property(m => m.companyChangeBy).HasColumnName("CompanyChangedBy");
        }
    }
}

using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class subCategoryMAP : IEntityMappingConfiguration<subCategory>
    {
        public void Map(EntityTypeBuilder<subCategory> builder)
        {
            builder.ToTable("SubCategoryMaster");
            builder.HasKey(m => m.subCategoryId);
            builder.Property(m => m.subCategoryId).HasColumnName("SubCategoryId");
            builder.Property(m => m.subCategoryName).IsRequired().HasColumnName("SubCategoryName");
            builder.Property(m => m.subCategoryDescription).IsRequired().HasColumnName("SubCategoryDescription");
            builder.Property(m => m.subCategorySEOId).HasColumnName("SubCategorySEOId");
            builder.Property(m => m.subCategoryImageId).HasColumnName("SubCategoryImageId");
            builder.Property(m => m.subCategoryIsParent).IsRequired().HasColumnName("SubCategoryIsParent");
            builder.Property(m => m.subCategoryParentId).HasColumnName("SubCategoryParentId");
            builder.Property(m => m.subCategoryIsMenu).IsRequired().HasColumnName("SubCategoryIsMenu");
            builder.Property(m => m.subCategoryIsActive).IsRequired().HasColumnName("SubCategoryIsActive");
            builder.Property(m => m.subCategoryCreatedDate).HasColumnName("SubCategoryCreatedDate");
            builder.Property(m => m.subCategoryChangeDate).IsRequired().HasColumnName("SubCategoryChangedDate");
            builder.Property(m => m.subCategoryChangeBy).HasColumnName("SubCategoryChangedBy");
        }
    }
}

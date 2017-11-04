using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class CategoryMappingMAP : IEntityMappingConfiguration<CategoryMappings>
    {
        public void Map(EntityTypeBuilder<CategoryMappings> builder)
        {
            builder.ToTable("CategoryMappings");
            builder.HasKey(m => m.CategoryMappingId);
            builder.Property(m => m.CategoryMappingId).HasColumnName("(CategoryMappingId");
            builder.Property(m => m.MainCategoryId.CategoryId).HasColumnName("CategoryId");
            builder.Property(m => m.SubCategoryId.SubCategoryId).HasColumnName("SubCategoryId");
            builder.Property(m => m.TypeCategoryId.TypeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.CategoryMappingIsActive).IsRequired().HasColumnName("CategoryMappingIsActive");
            builder.Property(m => m.CategoryMappingCreatedDate).HasColumnName("CategoryMappingCreatedDate ");
            builder.Property(m => m.CategoryMappingChangeDate).IsRequired().HasColumnName("CategoryMappingChangedDate");
            builder.Property(m => m.CategoryChangeBy).HasColumnName("CategoryMappingChangedBy");
        }
    }
}

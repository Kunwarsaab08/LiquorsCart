using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class categoryMappingMAP : IEntityMappingConfiguration<categoryMappings>
    {
        public void Map(EntityTypeBuilder<categoryMappings> builder)
        {
            builder.ToTable("CategoryMappings");
            builder.HasKey(m => m.categoryMappingId);
            builder.Property(m => m.categoryMappingId).HasColumnName("(CategoryMappingId");
            builder.Property(m => m.mainCategoryId).HasColumnName("CategoryId");
            builder.Property(m => m.subCategoryId).HasColumnName("SubCategoryId");
            builder.Property(m => m.typeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.categoryMappingIsActive).IsRequired().HasColumnName("CategoryMappingIsActive");
            builder.Property(m => m.categoryMappingCreatedDate).HasColumnName("CategoryMappingCreatedDate ");
            builder.Property(m => m.categoryMappingChangeDate).IsRequired().HasColumnName("CategoryMappingChangedDate");
            builder.Property(m => m.categoryChangeBy).HasColumnName("CategoryMappingChangedBy");
        }
    }
}

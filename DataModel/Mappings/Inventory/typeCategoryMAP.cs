using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Mappings.Inventory
{
    public class typeCategoryMAP : IEntityMappingConfiguration<typeCategory>
    {
        public void Map(EntityTypeBuilder<typeCategory> builder)
        {
            builder.ToTable("TypeCategoryMaster");
            builder.HasKey(m => m.typeCategoryId);
            builder.Property(m => m.typeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.typeCategoryName).IsRequired().HasColumnName("TypeCategoryName");
            builder.Property(m => m.typeCategoryDescription).IsRequired().HasColumnName("TypeCategoryDescription");
            builder.Property(m => m.typeCategorySEOId).HasColumnName("TypeCategorySEOId");
            builder.Property(m => m.typeCategoryImageId).HasColumnName("TypeCategoryImageId");
            builder.Property(m => m.typeCategoryIsParent).IsRequired().HasColumnName("TypeCategoryIsParent");
            builder.Property(m => m.typeCategoryParentId).HasColumnName("TypeCategoryParentId");
            builder.Property(m => m.typeCategoryIsMenu).IsRequired().HasColumnName("TypeCategoryIsMenu");
            builder.Property(m => m.typeCategoryIsActive).IsRequired().HasColumnName("TypeCategoryIsActive");
            builder.Property(m => m.typeCategoryCreatedDate).HasColumnName("TypeCategoryCreatedDate");
            builder.Property(m => m.typeCategoryChangeDate).IsRequired().HasColumnName("TypeCategoryChangedDate");
            builder.Property(m => m.typeCategoryChangeBy).HasColumnName("TypeCategoryChangedBy");
        }
    }
}

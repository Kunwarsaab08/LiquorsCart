using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataModel.Mappings.Inventory
{
    public class TypeCategoryMAP : IEntityMappingConfiguration<TypeCategory>
    {
        public void Map(EntityTypeBuilder<TypeCategory> builder)
        {
            builder.ToTable("TypeCategoryMaster");
            builder.HasKey(m => m.TypeCategoryId);
            builder.Property(m => m.TypeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.TypeCategoryName).IsRequired().HasColumnName("TypeCategoryName");
            builder.Property(m => m.TypeCategoryDescription).IsRequired().HasColumnName("TypeCategoryDescription");
            builder.Property(m => m.TypeCategorySEOId.SeoId).HasColumnName("TypeCategorySEOId");
            builder.Property(m => m.TypeCategoryImageId.ImageId).HasColumnName("TypeCategoryImageId");
            builder.Property(m => m.TypeCategoryIsParent).IsRequired().HasColumnName("TypeCategoryIsParent");
            builder.Property(m => m.TypeCategoryParentId).HasColumnName("TypeCategoryParentId");
            builder.Property(m => m.TypeCategoryIsMenu).IsRequired().HasColumnName("TypeCategoryIsMenu");
            builder.Property(m => m.TypeCategoryIsActive).IsRequired().HasColumnName("TypeCategoryIsActive");
            builder.Property(m => m.TypeCategoryCreatedDate).HasColumnName("TypeCategoryCreatedDate");
            builder.Property(m => m.TypeCategoryChangeDate).IsRequired().HasColumnName("TypeCategoryChangedDate");
            builder.Property(m => m.TypeCategoryChangeBy).HasColumnName("TypeCategoryChangedBy");
        }
    }
}

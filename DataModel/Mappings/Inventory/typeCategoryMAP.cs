using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class TypeCategoryMAP : IEntityMappingConfiguration<TypeCategory>
    {
        public void Map(EntityTypeBuilder<TypeCategory> builder)
        {
            builder.ToTable("TypeCategoryMaster");
            builder.HasKey(m => m.TypeCategoryId);
            builder.Property(m => m.TypeCategoryId).HasColumnName("TypeCategoryId");
            builder.Property(m => m.TypeCategoryName).HasColumnName("TypeCategoryName");
            builder.Property(m => m.TypeCategoryDescription).HasColumnName("TypeCategoryDescription");
            builder.Property(m => m.TypeCategorySEOId).HasColumnName("TypeCategorySEOId");
            builder.Property(m => m.TypeCategoryImageId).HasColumnName("TypeCategoryImageId");
            builder.Property(m => m.TypeCategoryIsParent).HasColumnName("TypeCategoryIsParent");
            builder.Property(m => m.TypeCategoryParentId).HasColumnName("TypeCategoryParentId");
            builder.Property(m => m.TypeCategoryIsMenu).HasColumnName("TypeCategoryIsMenu");
            builder.Property(m => m.TypeCategoryIsActive).HasColumnName("TypeCategoryIsActive");
            builder.Property(m => m.TypeCategoryCreatedDate).HasColumnName("TypeCategoryCreatedDate");
            builder.Property(m => m.TypeCategoryChangeDate).HasColumnName("TypeCategoryChangedDate");
            builder.Property(m => m.TypeCategoryChangeBy).HasColumnName("TypeCategoryChangedBy");
        }
    }
}

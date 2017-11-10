using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class SubCategoryMAP : IEntityMappingConfiguration<SubCategory>
    {
        public void Map(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("SubCategoryMaster");
            builder.HasKey(m => m.SubCategoryId);
            builder.Property(m => m.SubCategoryId).HasColumnName("SubCategoryId");
            builder.Property(m => m.SubCategoryName).IsRequired().HasColumnName("SubCategoryName");
            builder.Property(m => m.SubCategoryDescription).IsRequired().HasColumnName("SubCategoryDescription");
            builder.Property(m => m.SubCategorySEOId).HasColumnName("SubCategorySEOId");
            builder.Property(m => m.SubCategoryImageId).HasColumnName("SubCategoryImageId");
            builder.Property(m => m.SubCategoryIsParent).IsRequired().HasColumnName("SubCategoryIsParent");
            builder.Property(m => m.SubCategoryParentId).HasColumnName("SubCategoryParentId");
            builder.Property(m => m.SubCategoryIsMenu).IsRequired().HasColumnName("SubCategoryIsMenu");
            builder.Property(m => m.SubCategoryIsActive).IsRequired().HasColumnName("SubCategoryIsActive");
            builder.Property(m => m.SubCategoryCreatedDate).HasColumnName("SubCategoryCreatedDate");
            builder.Property(m => m.SubCategoryChangeDate).IsRequired().HasColumnName("SubCategoryChangedDate");
            builder.Property(m => m.SubCategoryChangeBy).HasColumnName("SubCategoryChangedBy");
        }
    }
}

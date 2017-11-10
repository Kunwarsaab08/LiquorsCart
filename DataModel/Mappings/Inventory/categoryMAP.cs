using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;                          

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class CategoryMAP : IEntityMappingConfiguration<Category>
    {
        public void Map(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("CategoryMaster");            
            builder.HasKey(m => m.CategoryId);
            builder.Property(m => m.CategoryId).HasColumnName("CategoryId");
            builder.Property(m => m.CategoryName).IsRequired().HasColumnName("CategoryName");
            builder.Property(m => m.CategoryDescription).IsRequired().HasColumnName("CategoryDescription");
            builder.Property(m => m.CategorySEOId).HasColumnName("CategorySEOId");
            builder.Property(m => m.CategoryImageId).HasColumnName("CategoryImageId");
            builder.Property(m => m.CategoryIsParent).IsRequired().HasColumnName("CategoryIsParent");
            builder.Property(m => m.CategoryParentId).HasColumnName("CategoryParentId");
            builder.Property(m => m.CategoryIsMenu).IsRequired().HasColumnName("CategoryIsMenu");
            builder.Property(m => m.CategoryIsActive).IsRequired().HasColumnName("CategoryIsActive");
            builder.Property(m => m.CategoryCreatedDate).HasColumnName("CategoryCreatedDate");
            builder.Property(m => m.CategoryChangeDate).IsRequired().HasColumnName("CategoryChangedDate");
            builder.Property(m => m.CategoryChangeBy).HasColumnName("CategoryChangedBy");
        }
    }
}

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
            builder.Property(m => m.CategoryId)
                   .HasColumnName("CategoryId");
            builder.Property(m => m.CategoryName).HasColumnName("CategoryName");
            builder.Property(m => m.CategoryDescription).HasColumnName("CategoryDescription");
            builder.Property(m => m.CategorySEOId).HasColumnName("CategorySEOId");
            builder.Property(m => m.CategoryImageId).HasColumnName("CategoryImageId");
            builder.Property(m => m.CategoryIsParent).IsRequired().HasColumnName("CategoryIsParent");
            builder.Property(m => m.CategoryParentId).HasColumnName("CategoryParentId");
            builder.Property(m => m.CategoryIsMenu).HasColumnName("CategoryIsMenu");
            builder.Property(m => m.CategoryIsActive).HasColumnName("CategoryIsActive");
            builder.Property(m => m.CategoryCreatedDate).HasColumnName("CategoryCreatedDate");
            builder.Property(m => m.CategoryChangeDate).HasColumnName("CategoryChangedDate");
            builder.Property(m => m.CategoryChangeBy).HasColumnName("CategoryChangedBy");
        }
    }
}

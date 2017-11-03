using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;                          

namespace DataModel.Mappings.Inventory
{
    public class categoryMAP : IEntityMappingConfiguration<category>
    {
        public void Map(EntityTypeBuilder<category> builder)
        {
            builder.ToTable("CategoryMaster");            
            builder.HasKey(m => m.categoryId);
            builder.Property(m => m.categoryId).HasColumnName("CategoryId");
            builder.Property(m => m.categoryName).IsRequired().HasColumnName("CategoryName");
            builder.Property(m => m.categoryDescription).IsRequired().HasColumnName("CategoryDescription");
            builder.Property(m => m.categorySEOId).HasColumnName("CategorySEOId");
            builder.Property(m => m.categoryImageId).HasColumnName("CategoryImageId");
            builder.Property(m => m.categoryIsParent).IsRequired().HasColumnName("CategoryIsParent");
            builder.Property(m => m.categoryParentId).HasColumnName("CategoryParentId");
            builder.Property(m => m.categoryIsMenu).IsRequired().HasColumnName("CategoryIsMenu");
            builder.Property(m => m.categoryIsActive).IsRequired().HasColumnName("CategoryIsActive");
            builder.Property(m => m.categoryCreatedDate).HasColumnName("CategoryCreatedDate");
            builder.Property(m => m.categoryChangeDate).IsRequired().HasColumnName("CategoryChangedDate");
            builder.Property(m => m.categoryChangeBy).HasColumnName("CategoryChangedBy");
        }
    }
}

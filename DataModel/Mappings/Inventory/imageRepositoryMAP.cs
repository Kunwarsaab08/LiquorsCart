using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class imageRepositoryMAP : IEntityMappingConfiguration<imageRepository>
    {
        public void Map(EntityTypeBuilder<imageRepository> builder)
        {
            builder.ToTable("ImageRepository");
            builder.HasKey(m => m.imageId);
            builder.Property(m => m.imageId).HasColumnName("(ImageId");
            builder.Property(m => m.imageLogoIcon).HasColumnName("ImageLogoIconUrl");
            builder.Property(m => m.imageSmallUrl).HasColumnName("ImageSmall");
            builder.Property(m => m.imageLargeUrl).HasColumnName("ImageUrl");
        }
    }
}

using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class ImageRepositoryMAP : IEntityMappingConfiguration<ImageRepository>
    {
        public void Map(EntityTypeBuilder<ImageRepository> builder)
        {
            builder.ToTable("ImageRepository");
            builder.HasKey(m => m.ImageId);
            builder.Property(m => m.ImageId).HasColumnName("ImageId");
            builder.Property(m => m.ImageLogoIcon).HasColumnName("ImageLogoIconUrl");
            builder.Property(m => m.ImageSmallUrl).HasColumnName("ImageSmall");
            builder.Property(m => m.ImageLargeUrl).HasColumnName("ImageUrl");
        }
    }
}

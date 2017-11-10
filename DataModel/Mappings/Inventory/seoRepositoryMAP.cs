using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiquorsCart.ServerSide.DataModel.Mappings.Inventory
{
    public class SeoRepositoryMAP : IEntityMappingConfiguration<SeoRepository>
    {
        public void Map(EntityTypeBuilder<SeoRepository> builder)
        {
            builder.ToTable("SEORepository");
            builder.HasKey(m => m.SeoId);
            builder.Property(m => m.SeoId).HasColumnName("(SEOid");
            builder.Property(m => m.SeoPageTitle).HasColumnName("SEOPageTitle");
            builder.Property(m => m.SeoDescriptionTag).HasColumnName("SEODescriptionTag");
            builder.Property(m => m.SeoMetaTag).HasColumnName("SEOMetaTag");
            builder.Property(m => m.SeoKeywords).HasColumnName("SEOKeywords");
        }
    }
}

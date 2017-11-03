using DataModel.DataModels.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Mappings.Inventory
{
    public class seoRepositoryMAP : IEntityMappingConfiguration<seoRepository>
    {
        public void Map(EntityTypeBuilder<seoRepository> builder)
        {
            builder.ToTable("SEORepository");
            builder.HasKey(m => m.seoId);
            builder.Property(m => m.seoId).HasColumnName("(SEOid");
            builder.Property(m => m.seoPageTitle).HasColumnName("SEOPageTitle");
            builder.Property(m => m.seoDescriptionTag).HasColumnName("SEODescriptionTag");
            builder.Property(m => m.seoMetaTag).HasColumnName("SEOMetaTag");
            builder.Property(m => m.seoKeywords).HasColumnName("SEOKeywords");
        }
    }
}

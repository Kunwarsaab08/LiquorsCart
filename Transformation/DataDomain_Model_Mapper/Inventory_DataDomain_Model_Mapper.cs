using AutoMapper;
using DA = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using DM = LiquorsCart.ServerSide.DomainModel.Inventory;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Inventory_DataDomain_Model_Mapper : Profile
    {
        public Inventory_DataDomain_Model_Mapper()
        {
            //Brand Mapping
            CreateMap<DA.Brand, DM.Brand>()
                .ForMember(destinationMember: d => d.CompanyId.CompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyId))
                .ForMember(destinationMember: d =>d.BrandSEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandSEOId))
                .ForMember(destinationMember: d =>d.BrandImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src =>src.BrandImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.CompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyId.CompanyId))
                .ForPath(destinationMember: s => s.BrandSEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandSEOId.SeoId))
                .ForPath(destinationMember: s => s.BrandImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandImageId.ImageId));

            //Category Mapping
            CreateMap<DA.Category, DM.Category>()
                .ForMember(destinationMember: d => d.CategorySEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CategorySEOId))
                .ForMember(destinationMember: d => d.CategoryImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CategoryImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.CategorySEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CategorySEOId.SeoId))
                .ForPath(destinationMember: s => s.CategoryImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CategoryImageId.ImageId));

            //CategoryMappings Mapping
            CreateMap<DA.CategoryMappings, DM.CategoryMappings>()
                .ForMember(destinationMember: d => d.MainCategoryId.CategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.MainCategoryId))
                .ForMember(destinationMember: d => d.SubCategoryId.SubCategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategoryId))
                .ForMember(destinationMember: d => d.TypeCategoryId.TypeCategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategoryId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.MainCategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.MainCategoryId.CategoryId))
                .ForPath(destinationMember: s => s.SubCategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategoryId.SubCategoryId))
                .ForPath(destinationMember: s => s.TypeCategoryId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategoryId.TypeCategoryId));

            //Company Mapping
            CreateMap<DA.Company, DM.Company>()
                .ForMember(destinationMember: d => d.CompanySEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanySEOId))
                .ForMember(destinationMember: d => d.CompanyImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.CompanySEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanySEOId.SeoId))
                .ForPath(destinationMember: s => s.CompanyImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyImageId.ImageId));

            //ImageRepository Mapping
            CreateMap<DA.ImageRepository, DM.ImageRepository>()
                .ReverseMap();

            //Product Mapping
            CreateMap<DA.Product, DM.Product>()
                .ForMember(destinationMember: d => d.ProductSEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSEOId))
                .ForMember(destinationMember: d => d.ProductImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.ProductSEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSEOId.SeoId))
                .ForPath(destinationMember: s => s.ProductImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductImageId.ImageId));

            //ProductSKU Mapping
            CreateMap<DA.ProductSKU, DM.ProductSKU>()
                .ForMember(destinationMember: d => d.ProductSKUCompanyId.CompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUCompanyId))
                .ForMember(destinationMember: d => d.ProductSKUBrandId.BrandId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUBrandId))
                .ForMember(destinationMember: d => d.ProductSKUProductId.ProductId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUProductId))
                .ForMember(destinationMember: d => d.ProductSKUCategoryMappingId.CategoryMappingId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUCategoryMappingId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.ProductSKUCompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUCompanyId.CompanyId))
                .ForPath(destinationMember: s => s.ProductSKUBrandId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUBrandId.BrandId))
                .ForPath(destinationMember: s => s.ProductSKUProductId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUProductId.ProductId))
                .ForPath(destinationMember: s => s.ProductSKUCategoryMappingId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUCategoryMappingId.CategoryMappingId));

            //ProductSKUDiscount Mapping
            CreateMap<DA.ProductSKUDiscount, DM.ProductSKUDiscount>()
                .ForMember(destinationMember: d => d.ProductSKUID.ProductSKUID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUID))
                .ReverseMap()
                .ForPath(destinationMember: d => d.ProductSKUID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUID.ProductSKUID));

            //ProductSKUInventory Mapping
            CreateMap<DA.ProductSKUInventory, DM.ProductSKUInventory>()
                .ForMember(destinationMember: d => d.ProductSKUId.ProductSKUID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUId))
                .ReverseMap()
                .ForPath(destinationMember: d => d.ProductSKUId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSKUId.ProductSKUID));

            //ProductSpecification Mapping
            CreateMap<DA.ProductSpecification, DM.ProductSpecification>()
                .ForMember(destinationMember: d => d.ProductID.ProductId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductID))
                .ForMember(destinationMember: d => d.ProductSpecificationsID.SpecificationID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSpecificationsID))
                .ForMember(destinationMember: d => d.ProductSpecificationValuesID.SpecificationValueId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSpecificationValuesID))
                .ReverseMap()
                .ForPath(destinationMember: s => s.ProductID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductID.ProductId))
                .ForPath(destinationMember: s => s.ProductSpecificationsID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSpecificationsID.SpecificationID))
                .ForPath(destinationMember: s => s.ProductSpecificationValuesID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.ProductSpecificationValuesID.SpecificationValueId));

            //SEORepository Mapping
            CreateMap<DA.SeoRepository, DM.SeoRepository>()
                .ReverseMap();

            //Specification Mapping
            CreateMap<DA.Specification, DM.Specification>()
                .ReverseMap();

            //SubCategory Mapping
            CreateMap<DA.SubCategory, DM.SubCategory>()
                .ForMember(destinationMember: d => d.SubCategorySEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategorySEOId))
                .ForMember(destinationMember: d => d.SubCategoryImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategoryImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.SubCategorySEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategorySEOId.SeoId))
                .ForPath(destinationMember: s => s.SubCategoryImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.SubCategoryImageId.ImageId));

            //TypeCategory Mapping
            CreateMap<DA.TypeCategory, DM.TypeCategory>()
                .ForMember(destinationMember: d => d.TypeCategorySEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategorySEOId))
                .ForMember(destinationMember: d => d.TypeCategoryImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategoryImageId))
                .ReverseMap()
                .ForPath(destinationMember: s => s.TypeCategorySEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategorySEOId.SeoId))
                .ForPath(destinationMember: s => s.TypeCategoryImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.TypeCategoryImageId.ImageId));
        }
    }
}

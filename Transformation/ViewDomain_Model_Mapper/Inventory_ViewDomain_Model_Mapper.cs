using AutoMapper;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;

namespace LiquorsCart.ServerSide.Transformation.ViewDomain_Model_Mapper
{
    public class Inventory_ViewDomain_Model_Mapper : Profile
    {
        public Inventory_ViewDomain_Model_Mapper()
        {
            //SEORepository Mapping
            CreateMap<DM.SeoRepository, VM.SeoRepository>()
                    .ReverseMap();

            //Brand Mapping
            //CreateMap<DA.Brand, DM.Brand>()
            //    .ForMember(destinationMember: d => d.CompanyId.CompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyId))
            //    .ForMember(destinationMember: d => d.BrandSEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandSEOId))
            //    .ForMember(destinationMember: d => d.BrandImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandImageId))
            //    .ReverseMap()
            //    .ForPath(destinationMember: s => s.CompanyId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyId.CompanyId))
            //    .ForPath(destinationMember: s => s.BrandSEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandSEOId.SeoId))
            //    .ForPath(destinationMember: s => s.BrandImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.BrandImageId.ImageId));

        }
    }
}

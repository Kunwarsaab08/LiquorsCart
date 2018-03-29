using AutoMapper;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using System;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Inventory_ViewDomain_Model_Mapper : Profile
    {
        public Inventory_ViewDomain_Model_Mapper()
        {
            try
            {
                //SEORepository Mapping
                CreateMap<DM.SeoRepository, VM.SeoRepository>()
                        .ReverseMap();

                //ImageRepository Mapping
                CreateMap<DM.ImageRepository, VM.ImageRepository>()
                       .ReverseMap();

                CreateMap<DM.Company, VM.Company>()
                    .ForMember(d => d.CompanySEOId, opt => opt.Ignore())
                    .ForMember(d => d.CompanyImageId, opt => opt.Ignore())
                    .ReverseMap()
                    .ForMember(d => d.CompanySEOId, opt => opt.Ignore())
                    .ForMember(d => d.CompanyImageId, opt => opt.Ignore()); 



                //CreateMap<DM.Company, VM.Company>()
                //    .ForMember(dest => dest.CompanySEOId,
                //    opts => opts.MapFrom(
                //        src => new DM.SeoRepository
                //        {
                //            SeoId=DestinationMemberNamingConvention.
                //        }));
                //Company Mapping
                //CreateMap<DM.Company, VM.Company>()
                //    .AfterMap((s, d) =>
                //        {
                //            d.CompanyImageId.ImageId = s.CompanyImageId;
                //            d.CompanyImageId.ImageLargeUrl = null;
                //            d.CompanyImageId.ImageLogoIcon = null;
                //            d.CompanyImageId.ImageSmallUrl = null;
                //            d.CompanySEOId.SeoId = s.CompanySEOId;
                //            d.CompanySEOId.SeoDescriptionTag = null;
                //            d.CompanySEOId.SeoKeywords = null;
                //            d.CompanySEOId.SeoMetaTag = null;
                //            d.CompanySEOId.SeoPageTitle = null;
                //        }
                //    )
                //    .ReverseMap()
                //    .AfterMap((s, d) =>
                //        {
                //            d.CompanySEOId = s.CompanySEOId.SeoId;
                //            d.CompanyImageId = s.CompanyImageId.ImageId;
                //        }
                //    );


                //CreateMap<DM.Company, VM.Company>()
                //    .ForMember(dest=>dest.CompanySEOId,opt=>opt.MapFrom(src=> Mapper.Map<DM.SeoRepository,VM.SeoRepository>(src)))
                //    .ForMember(destinationMember: d => d.CompanySEOId.SeoId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanySEOId))
                //    .ForMember(destinationMember: d => d.CompanyImageId.ImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyImageId))
                //    .ReverseMap()
                //    .ForPath(destinationMember: s => s.CompanySEOId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanySEOId.SeoId))
                //    .ForPath(destinationMember: s => s.CompanyImageId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.CompanyImageId.ImageId));
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}

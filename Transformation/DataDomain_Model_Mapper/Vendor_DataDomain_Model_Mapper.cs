using AutoMapper;
using DA = LiquorsCart.ServerSide.DataModel.DataModels.Vendor;
using DM = LiquorsCart.ServerSide.DomainModel.Vendor;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Vendor_DataDomain_Model_Mapper : Profile
    {
        public Vendor_DataDomain_Model_Mapper()
        {
            //Vendor Mapping
            CreateMap<DA.Vendor, DM.Vendor>()
                .ReverseMap();

            //VendorSKU Mapping
            CreateMap<DA.VendorSKU, DM.VendorSKU>()
                .ForMember(destinationMember: d => d.VendorId.VendorID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.VendorId))
                .ForMember(destinationMember: d => d.VendorSKUProductID.ProductSKUID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.VendorSKUProductID))
                .ReverseMap()
                .ForPath(destinationMember: s => s.VendorId, memberOptions: opt => opt.MapFrom(sourceMember: src => src.VendorId.VendorID))
                .ForPath(destinationMember: s => s.VendorSKUProductID, memberOptions: opt => opt.MapFrom(sourceMember: src => src.VendorSKUProductID.ProductSKUID));
        }
    }
}

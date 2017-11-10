using AutoMapper;

namespace LiquorsCart.ServerSide.Transformation
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            Inventory_DataDomain_Model_Mapper inventory_DataDomain_Model_Mapper = new Inventory_DataDomain_Model_Mapper();
            Vendor_DataDomain_Model_Mapper vendor_DataDomain_Model_Mapper = new Vendor_DataDomain_Model_Mapper();
        }
    }
}

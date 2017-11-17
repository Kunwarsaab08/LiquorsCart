using AutoMapper;
//using LiquorsCart.ServerSide.Transformation.DataDomain_Model_Mapper;
using LiquorsCart.ServerSide.Transformation.ViewDomain_Model_Mapper;

namespace LiquorsCart.ServerSide.Transformation
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
           // Inventory_DataDomain_Model_Mapper inventory_DataDomain_Model_Mapper = new Inventory_DataDomain_Model_Mapper();
            Inventory_ViewDomain_Model_Mapper inventory_ViewDomain_Model_Mapper = new Inventory_ViewDomain_Model_Mapper();
           // Vendor_DataDomain_Model_Mapper vendor_DataDomain_Model_Mapper = new Vendor_DataDomain_Model_Mapper();            
        }
    }
}

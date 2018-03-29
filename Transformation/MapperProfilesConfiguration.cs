using AutoMapper;

namespace LiquorsCart.ServerSide.Transformation
{
    public class MapperProfilesConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<Inventory_ViewDomain_Model_Mapper>();
            });
        }
    }
}

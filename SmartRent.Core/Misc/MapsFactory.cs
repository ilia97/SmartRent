using AutoMapper;
using SmartRent.Core.Models;
using SmartRent.DataAccess.Models;

namespace SmartRent.Core.Misc
{
    public static class MapsFactory
    {
        public static void CreateCoreMaps(this IMapperConfigurationExpression config)
        {
            config.CreateMap<AdminEntity, Admin>();
            config.CreateMap<CustomerEntity, Customer>();
            config.CreateMap<ItemEntity, Item>();
            config.CreateMap<ManagerEntity, Manager>();
            config.CreateMap<RentEntity, Rent>();
            config.CreateMap<ShopEntity, Shop>();
        }
    }
}

using AutoMapper;
using SmartRent.Core.Models;
using SmartRent.DataAccess.Models;

namespace SmartRent.Core.Misc
{
    public static class MapsFactory
    {
        public static void CreateCoreMaps(this IMapperConfigurationExpression config)
        {
            config.CreateMap<UserEntity, User>();
            config.CreateMap<ItemEntity, Item>();
            config.CreateMap<RentEntity, Rent>();
            config.CreateMap<ShopEntity, Shop>();
        }
    }
}

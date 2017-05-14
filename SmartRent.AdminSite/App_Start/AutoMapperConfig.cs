using AutoMapper;
using SmartRent.AdminSite.Models;
using SmartRent.AdminSite.Models.Shop;
using SmartRent.Core.Misc;
using SmartRent.Core.Models;
using SmartRent.DataAccess.Models;

namespace SmartRent.AdminSite
{
    class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.CreateCoreMaps();

                config.CreateMap<CreateShopViewModel, Shop>();
                config.CreateMap<Shop, ShopListItemViewModel>();
            });
        }
    }
}

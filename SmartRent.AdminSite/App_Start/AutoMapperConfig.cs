using AutoMapper;
using SmartRent.AdminSite.Models;
using SmartRent.Core.Misc;
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
            });
        }
    }
}

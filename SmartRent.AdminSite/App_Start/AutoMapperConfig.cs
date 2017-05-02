using AutoMapper;
using SmartRent.Core.Misc;

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

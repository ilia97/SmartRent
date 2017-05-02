using AutoMapper;
using SmartRent.Core.Misc;

namespace SmartRent.ManagerSite
{
    static class AutoMapperConfig
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

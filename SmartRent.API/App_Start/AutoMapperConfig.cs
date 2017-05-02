using AutoMapper;
using SmartRent.Core.Misc;

namespace SmartRent.API
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

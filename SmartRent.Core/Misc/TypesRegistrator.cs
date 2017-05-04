using Autofac;
using SmartRent.Core.Models;
using SmartRent.Core.Repository;
using SmartRent.Core.Repository.Interfaces;
using SmartRent.Core.Services;
using SmartRent.Core.Services.Interfaces;
using SmartRent.DataAccess;
using SmartRent.DataAccess.Models;

namespace SmartRent.Core.Misc
{
    public static class TypesRegistrator
    {
        public static void RegisterApplicationTypes(this ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>()
                .AsSelf()
                .InstancePerRequest();

            #region Repositories
            builder.RegisterType<Repository<UserEntity>>()
                .As<IRepository<UserEntity>>();

            builder.RegisterType<Repository<ShopEntity>>()
                .As<IRepository<ShopEntity>>();

            builder.RegisterType<Repository<ItemEntity>>()
                .As<IRepository<ItemEntity>>();

            builder.RegisterType<Repository<RentEntity>>()
                .As<IRepository<RentEntity>>();
            #endregion Repositories

            #region Services
            builder.RegisterType<ShopsService>()
                .As<IShopsService>();
            #endregion Services
        }
    }
}
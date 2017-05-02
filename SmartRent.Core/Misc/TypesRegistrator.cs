using Autofac;
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

            builder.RegisterType<Repository<CustomerEntity>>()
                .As<IRepository<CustomerEntity>>();

            builder.RegisterType<Repository<AdminEntity>>()
                .As<IRepository<AdminEntity>>();

            builder.RegisterType<Repository<ManagerEntity>>()
                .As<IRepository<ManagerEntity>>();

            builder.RegisterType<Repository<ShopEntity>>()
                .As<IRepository<ShopEntity>>();

            builder.RegisterType<Repository<ItemEntity>>()
                .As<IRepository<ItemEntity>>();

            builder.RegisterType<Repository<RentEntity>>()
                .As<IRepository<RentEntity>>();

            builder.RegisterType<ShopsService>()
                .As<IShopsService>();
        }
    }
}
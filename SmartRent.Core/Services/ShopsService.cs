using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SmartRent.Core.Exceptions;
using SmartRent.Core.Models;
using SmartRent.Core.Repository.Interfaces;
using SmartRent.Core.Services.Interfaces;
using SmartRent.DataAccess.Models;

namespace SmartRent.Core.Services
{
    public class ShopsService : IShopsService
    {
        private readonly IRepository<ShopEntity> shopsRepository;
        private readonly IRepository<UserEntity> adminsRepository;

        public ShopsService(
            IRepository<ShopEntity> shopsRepository, 
            IRepository<UserEntity> adminsRepository)
        {
            this.shopsRepository = shopsRepository;
            this.adminsRepository = adminsRepository;
        }

        public int AddShop(Shop shop, string adminId)
        {
            var admin = this.adminsRepository.GetById(adminId);

            if (admin == null)
            {
                throw new AdminNotFoundException($"Admin with Id \"{adminId}\" wasn't found.");
            }

            var shopEntity = Mapper.Map<Shop, ShopEntity>(shop);

            this.shopsRepository.Insert(shopEntity);
            this.shopsRepository.Save();

            return shopEntity.Id;
        }

        public void EditShop(Shop shop, string adminId)
        {
            var admin = this.adminsRepository.GetById(adminId);

            if (admin == null)
            {
                throw new AdminNotFoundException($"Admin with Id \"{adminId}\" wasn't found.");
            }

            if (admin.Shops.All(adminShop => adminShop.Id != shop.Id))
            {
                throw new AccessDeniedException($"Admin with Id \"{adminId}\" doesn't contain a shop with Id \"{shop.Id}\".");
            }

            var shopEntity = Mapper.Map<Shop, ShopEntity>(shop);

            this.shopsRepository.Update(shopEntity);
            this.shopsRepository.Save();
        }

        public List<Shop> GetShops()
        {
            var shopsList = this.shopsRepository.Get();

            return Mapper.Map<List<ShopEntity>, List<Shop>>(shopsList);
        }

        public void RemoveShop(int shopId, string adminId)
        {
            var admin = this.adminsRepository.GetById(adminId);

            if (admin == null)
            {
                throw new AdminNotFoundException($"Admin with Id \"{adminId}\" wasn't found.");
            }

            if (admin.Shops.All(adminShop => adminShop.Id != shopId))
            {
                throw new AccessDeniedException($"Admin with Id \"{adminId}\" doesn't contain a shop with Id \"{shopId}\".");
            }

            this.shopsRepository.Delete(shopId);
            this.shopsRepository.Save();
        }

        public Shop GetShop(int shopId)
        {
            var shopEntity = this.shopsRepository.GetById(shopId);

            return Mapper.Map<ShopEntity, Shop>(shopEntity);
        }
    }
}
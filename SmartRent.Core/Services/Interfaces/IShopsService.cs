using System.Collections.Generic;
using SmartRent.Core.Models;

namespace SmartRent.Core.Services.Interfaces
{
    public interface IShopsService
    {
        List<Shop> GetShops();

        Shop GetShop(int shopId);

        void AddShop(Shop shop, string adminId);

        void EditShop(Shop shop, string adminId);

        void RemoveShop(int shopId, string adminId);
    }
}

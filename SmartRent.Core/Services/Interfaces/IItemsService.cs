using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartRent.Core.Models;

namespace SmartRent.Core.Services.Interfaces
{
    public interface IItemsService
    {
        List<Item> GetItems(string searchPart = "", int? shopId = null);

        Item GetItem(int itemId);

        void BookItem(int itemId, string customerId);

        int AddItem(Item item, string managerId);

        void EditItem(Item item, string managerId);

        void RemoveItem(int itemId, string managerId);

        void StartRent(int itemId, string customerId, string managerId);

        void FinishRent(int rentId, string managerId);
    }
}

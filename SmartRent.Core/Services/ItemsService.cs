using System;
using System.Collections.Generic;
using SmartRent.Core.Models;
using SmartRent.Core.Services.Interfaces;

namespace SmartRent.Core.Services
{
    class ItemsService : IItemsService
    {
        public int AddItem(Item item, string managerId)
        {
            throw new NotImplementedException();
        }

        public void EditItem(Item item, string managerId)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int itemId, string managerId)
        {
            throw new NotImplementedException();
        }

        public void StartRent(int itemId, string customerId, string managerId)
        {
            throw new NotImplementedException();
        }

        public void FinishRent(int rentId, string managerId)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItems(string searchPart = "", int? shopId = default(int?))
        {
            throw new NotImplementedException();
        }

        public Item GetItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void BookItem(int itemId, string customerId)
        {
            throw new NotImplementedException();
        }
    }
}

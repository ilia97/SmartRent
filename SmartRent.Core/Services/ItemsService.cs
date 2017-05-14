using System;
using System.Collections.Generic;
using System.Linq;
using SmartRent.Core.Exceptions;
using SmartRent.Core.Models;
using SmartRent.Core.Repository.Interfaces;
using SmartRent.Core.Services.Interfaces;
using SmartRent.DataAccess.Models;

namespace SmartRent.Core.Services
{
    class ItemsService : IItemsService
    {
        private readonly IRepository<ItemEntity> _itemsRepository;
        private readonly IRepository<RentEntity> _rentsRepository;

        public ItemsService(
            IRepository<ItemEntity> itemsRepository,
            IRepository<RentEntity> rentsRepository)
        {
            this._itemsRepository = itemsRepository;
            this._rentsRepository = rentsRepository;
        }

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

        public void StartRent(string chipId)
        {
            var chipItem = this._itemsRepository.Get(item => item.ChipId == chipId).SingleOrDefault();

            if (chipItem == null)
            {
                throw new ItemNotFoundException();
            }

            var chipItemRent = this._rentsRepository.Get(rent => rent.ItemId == chipItem.Id && rent.StartDate == null)
                .SingleOrDefault();

            if (chipItemRent != null)
            {
                chipItemRent.StartDate = DateTime.Now;
                chipItemRent.CustomerId = null;

                this._rentsRepository.Update(chipItemRent);
                this._rentsRepository.Save();
            }
            else
            {
                this._rentsRepository.Insert(new RentEntity
                {
                    ItemId = chipItem.Id,
                    Prepayment = chipItem.Prepayment,
                    PricePerDay = chipItem.PricePerDay,
                    StartDate = DateTime.Now
                });
                this._rentsRepository.Save();
            }
        }

        public void FinishRent(string chipId)
        {
            var chipItem = this._itemsRepository.Get(item => item.ChipId == chipId).SingleOrDefault();

            if (chipItem == null)
            {
                throw new ItemNotFoundException();
            }

            var chipItemRent = this._rentsRepository
                .Get(rent => rent.ItemId == chipItem.Id && rent.StartDate != null && rent.EndDate == null)
                .SingleOrDefault();

            if (chipItemRent != null)
            {
                chipItemRent.EndDate = DateTime.Now;
                this._rentsRepository.Update(chipItemRent);
                this._rentsRepository.Save();
            }
        }
    }
}

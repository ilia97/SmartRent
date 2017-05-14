using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartRent.Core.Services.Interfaces;

namespace SmartRent.API.Controllers
{
    public class ItemsController : ApiController
    {
        private readonly IItemsService _itemsService;

        public ItemsController(IItemsService itemsService)
        {
            this._itemsService = itemsService;
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Items/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Items
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Items/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Items/5
        public void Delete(int id)
        {
        }

        public void SubmitRentStart(string chipId)
        {
            this._itemsService.StartRent(chipId);
        }

        public void SubmitRentEnd(string chipId)
        {
            this._itemsService.FinishRent(chipId);
        }
    }
}

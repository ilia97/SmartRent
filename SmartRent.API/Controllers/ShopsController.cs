using System.Web.Http;
using SmartRent.Core.Services.Interfaces;

namespace SmartRent.API.Controllers
{
    public class ShopsController : ApiController
    {
        private readonly IShopsService _shopsService;

        public ShopsController(IShopsService shopsService)
        {
            this._shopsService = shopsService;
        }

        [Authorize]
        public IHttpActionResult Get()
        {
            return Json(this._shopsService.GetShops());
        }

        [Authorize]
        public IHttpActionResult Get(int id)
        {
            return Json(this._shopsService.GetShop(id));
        }
    }
}

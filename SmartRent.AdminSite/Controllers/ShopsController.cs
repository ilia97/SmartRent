using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SmartRent.AdminSite.Models.Shop;
using SmartRent.Core.Exceptions;
using SmartRent.Core.Models;
using SmartRent.Core.Services.Interfaces;

namespace SmartRent.AdminSite.Controllers
{
    [Authorize]
    public class ShopsController : Controller
    {
        private readonly IShopsService _shopsService;

        public ShopsController(IShopsService shopsService)
        {
            this._shopsService = shopsService;
        }

        public ActionResult Index()
        {
            var shopsList = this._shopsService.GetShops();

            var model = Mapper.Map<List<Shop>, List<ShopListItemViewModel>>(shopsList);

            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            var shop  = this._shopsService.GetShop(id);

            var model = Mapper.Map<Shop, ShopDetailsViewModel>(shop);

            return View(model);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(CreateShopViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var shop = Mapper.Map<CreateShopViewModel, Shop>(model);

                var ceratedShopId = _shopsService.AddShop(shop, this.User.Identity.GetUserId());

                return RedirectToAction("Edit", ceratedShopId);
            }
            catch (AdminNotFoundException)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
        }
        
        public ActionResult Edit(int id)
        {
            var shop = this._shopsService.GetShop(id);

            var model = Mapper.Map<Shop, EditShopViewModel>(shop);

            return View(model);
        }
        
        [HttpPost]
        public ActionResult Edit(EditShopViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var shop = Mapper.Map<EditShopViewModel, Shop>(model);

                _shopsService.EditShop(shop, this.User.Identity.GetUserId());

                return RedirectToAction("Index");
            }
            catch (AdminNotFoundException)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _shopsService.RemoveShop(id, this.User.Identity.GetUserId());

                return RedirectToAction("Index");
            }
            catch (AdminNotFoundException)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            catch (AccessDeniedException)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
        }
    }
}

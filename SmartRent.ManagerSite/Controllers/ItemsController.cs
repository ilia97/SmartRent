using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SmartRent.Core.Models;
using SmartRent.Core.Services.Interfaces;
using SmartRent.DataAccess;
using SmartRent.ManagerSite.Models.Item;

namespace SmartRent.ManagerSite.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemsService _itemsService;
        private readonly IUsersService _usersService;

        public ItemsController(
            IItemsService _itemsService,
            IUsersService _usersService)
        {
            this._itemsService = _itemsService;
            this._usersService = _usersService;
        }

        // GET: Items
        public ActionResult Index()
        {
            var userId = this.User.Identity.GetUserId();

            var manager = this._usersService.GetUser(userId);
            var model = this._itemsService.GetItems("", manager.Shop.Id);

            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var item = this._itemsService.GetItem(id);

            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateItemViewMoel model)
        {
            if (ModelState.IsValid)
            {
                var item = Mapper.Map<CreateItemViewMoel, Item>(model);

                this._itemsService.AddItem(item, this.User.Identity.GetUserId());

                return RedirectToAction("Index");
            }

            return View(model);
        }
        
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var item = this._itemsService.GetItem(id);

            if (item == null)
            {
                return HttpNotFound();
            }

            var model = Mapper.Map<Item, EditItemViewModel>(item);

            return View(model);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var item = Mapper.Map<EditItemViewModel, Item>(model);

                this._itemsService.EditItem(item, this.User.Identity.GetUserId());

                return RedirectToAction("Index");
            }

            return View(model);
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            this._itemsService.RemoveItem(id, this.User.Identity.GetUserId());

            return RedirectToAction("Index");
        }
    }
}

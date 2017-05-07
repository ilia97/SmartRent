using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SmartRent.Core.Models;
using SmartRent.Core.Services.Interfaces;
using SmartRent.DataAccess;

namespace SmartRent.CustomerSite.Controllers
{
    public class ShopsController : Controller
    {
        private readonly IShopsService shopsService;

        public ShopsController(IShopsService shopsService)
        {
            this.shopsService = shopsService;
        }
        
        public ActionResult Index()
        {
            var model = this.shopsService.GetShops();

            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var model = this.shopsService.GetShop(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        
    }
}

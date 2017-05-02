using System.Web.Mvc;
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
            return View();
        }
        
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shops/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shops/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shops/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shops/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shops/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

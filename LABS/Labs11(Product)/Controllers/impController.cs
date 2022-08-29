using Labs11_Product_.Models;
using Labs11_Product_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labs11_Product_.Controllers
{
    [Authorize]
    public class impController : Controller
    {
        private readonly ProductOps _ProdDb = new ProductOps();
        // GET: imp
        public ActionResult Index()
        {

            return View(_ProdDb.GetAll());
            
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Edit(int id)
        {
            return View(_ProdDb.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Product pUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _ProdDb.Update(pUser.ID, pUser);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("Not Found", ex.Message);
                    return View("Edit");

                }
            }
            return View("Edit");


        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int  td)
        {
            return View(_ProdDb.Find(td));
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Register()
        {
            return View(new Product());        //@html.img()
        }
        [HttpPost]
        public ActionResult Register(Product pUser)
        {
            _ProdDb.Add(pUser);
            return RedirectToAction("Index", "imp");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_ProdDb.Find(id));
        }
        [HttpPost]

        public ActionResult Delete(Product pUser)
        {

            try
            {
                _ProdDb.Delete(pUser);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                ModelState.AddModelError("Not Found", ex.Message);
                return View("Delete");

            }

            return View("Delete");
        }
    }
}
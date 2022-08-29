using Labs11_Product_.Models;
using Labs11_Product_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Labs11_Product_.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly ProductOps _ProdDb = new ProductOps();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login uProd)
        {
            if (uProd.Name=="admin" && uProd.password=="nimda")
            {
                FormsAuthentication.SetAuthCookie(uProd.Name, false);
                Session["username"] = "admin";
                return RedirectToAction("Index","imp");
            }
                return View("Login");
            
           
        }

    }
}
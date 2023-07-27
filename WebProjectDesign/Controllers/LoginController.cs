using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjectDesign.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            ///kullanıcı adı "admin", şifre "1234"
            if (username == "admin" && password == "1234")
            {
                ViewBag.Mesaj = "Giriş başarılı.";
                return RedirectToAction("Index", "Proje");
            }
            else
            {
                ViewBag.Mesaj = "Giriş başarısız.";
            }
            return View();
        }

    }
}
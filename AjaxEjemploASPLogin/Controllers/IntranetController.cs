using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxEjemploASPLogin.Controllers
{
    public class IntranetController : Controller
    {
        // GET: Intranet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CerrarSesion()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
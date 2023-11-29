using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AjaxEjemploASPLogin.Controllers
{
    public class IntranetController : Controller
    {
        // GET: Intranet
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
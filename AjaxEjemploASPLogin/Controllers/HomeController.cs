using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AjaxEjemploASPLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult testAjax(Usuario usuario)
        {
            Usuario usuariobd = new Usuario()
            {
                CorreoElectronico = "usuariocorrecto@mail.com",
                Password = "123456"
            };

            if (usuario.CorreoElectronico == usuariobd.CorreoElectronico && usuario.Password == usuariobd.Password)
            {
                return Json(new { success = true, redirectUrl = Url.Action("Index", "Intranet") });
            }
            else
            {
                return Json(new { success = false, message = "Usuario incorrecto" });
            }
        }

        public ActionResult Intranet()
        {
            return View();
        }
    }
}

public class Usuario
{
    public string CorreoElectronico { get; set; }
    public string Password { get; set; }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SantaLucia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login(bool DatosIncorrectos = false)
        {
            ViewBag.DatosIncorrectos = DatosIncorrectos;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Ingresar(string dni, string contraseña)
        {
            return RedirectToAction("ListarProducto", "Producto");
           
        }
        public ActionResult CerrarSession()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
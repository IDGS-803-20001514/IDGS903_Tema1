using IDGS903_Tema1.Models;
using IDGS903_Tema1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulques = new PulqueService();

            var model = pulques.ObtenerPulques();

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            TempData["nombres"] = "Mario Lopez";

            var pulques = new PulqueService();

            var model = pulques.ObtenerPulques();

            return View(model);
        }

        public JsonResult Index()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Mango",
                Descripcion = "Pulque de Mango"
            };
            
            return Json(pulque1, JsonRequestBehavior.AllowGet);
        
        }

        public ActionResult Vista()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Piña",
                Descripcion = "Pulque de Piña",
                Litros = 4,
                Caducidad = new DateTime(2023, 04, 21)
            };

            ViewBag.pulque = pulque1;

            return View();
        }

        public ActionResult Vista2()
        {
            ViewBag.saludo = "Hola Mundo";

            ViewBag.fecha = new DateTime(2023, 03, 12);

            ViewData["Nombre"] = "Cristian Ulises";

            string nombre = "";

            if (TempData.ContainsKey("nombres"))
            {
                nombre = TempData["nombres"] as string;
            }

            ViewBag.nombreNuevo = nombre;

            return View();
        }
    }
}
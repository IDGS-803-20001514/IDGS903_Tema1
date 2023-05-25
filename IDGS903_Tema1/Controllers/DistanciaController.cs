using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace IDGS903_Tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index(Distancia dis)
        {
            dis.CalcularDistancia();

            var model = new Distancia();

            model.Resultado = dis.Resultado;

            ViewBag.Distancia = dis.Resultado;

            return View(model);
        }

        public ActionResult final(Distancia dis)
        {
            var model = new Distancia();

            dis.CalcularDistancia();

            model.Resultado = dis.Resultado;

            ViewBag.Distancia = dis.Resultado;

            return View(model);
        }
    }
}
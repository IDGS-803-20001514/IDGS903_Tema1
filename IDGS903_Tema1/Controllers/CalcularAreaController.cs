using AreaTriangulo.Models;
using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class CalcularAreaController : Controller
    {
        [HttpPost]
        public ActionResult Index(Triangulo tr)
        {

            tr.CalcularAB();

            tr.CalcularBC();

            tr.CalcularAC();

            var model = new Triangulo();

            model.DistanciaAB = tr.DistanciaAB;

            model.DistanciaAC = tr.DistanciaAC;

            model.DistanciaBC = tr.DistanciaBC;

            tr.IdentificarTriangulo();

            model.TringuloStr = tr.TringuloStr;

            model.AreaTrinagulo = tr.AreaTrinagulo;

            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
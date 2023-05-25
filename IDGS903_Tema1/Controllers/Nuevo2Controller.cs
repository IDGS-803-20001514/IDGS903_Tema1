using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class Nuevo2Controller : Controller
    {
        // GET: Nuevo2
        public ActionResult Ventana2()
        {
            return View();
        }

        public ActionResult Calculos(string n1, string n2, string operacion)
        {
            float res = 0;

            switch (operacion)
            {
                case "suma":
                    res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                    break;
                case "resta":
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    break;
                case "multiplicacion":
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    break;
                case "division":
                    res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                    break;

            }
                ViewBag.Res = Convert.ToString(res);

            return View();
        }
    
        public ActionResult Ventana3(OperasBas op, string operacion) 
        {
            op.calcular(operacion);

            var model = new OperasBas();

            model.Resultado = op.Resultado;

            return View(model);
        }
    }
}
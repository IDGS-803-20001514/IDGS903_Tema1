using IDGS903_Tema1.Models;
using IDGS903_Tema1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TraductorES_INGController : Controller
    {
        // GET: TraductorES_ING
        public ActionResult GuardarPalabra()
        {
            var traduc = new Traductor();

            ViewBag.Traducciones = traduc.MostrarPalabras();

            return View();
        }


        [HttpPost]
        public ActionResult GuardarPalabra(Diccionario dic) 
        {
            var op = new Traductor();

            op.GuardarPalabra(dic);

            ViewBag.Traducciones = op.MostrarPalabras();

            return View();
        }

        public ActionResult MostrarTraducciones()
        {
            var traduc = new Traductor();

            ViewBag.Traducciones = traduc.MostrarPalabras();

            return View();
        }

        public ActionResult TraducirPalabras()
        {
            return View();
        }
    }
}
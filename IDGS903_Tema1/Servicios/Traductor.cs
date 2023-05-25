using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace IDGS903_Tema1.Servicios
{
    public class Traductor
    {

        public void GuardarPalabra(Diccionario dic)
        {

            var palabraIngles = dic.palabraIngles;

            var palabraEspanol = dic.palabraEspanol;

            var datos = palabraIngles + " , " + palabraEspanol + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");

            File.AppendAllText(archivo, datos);

        }

        public Array MostrarPalabras()
        {
            Array traducciones = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");

            if (File.Exists(archivo))
            {
                traducciones = File.ReadAllLines(archivo);
            }

            return traducciones;
        }

        public string TraducirPalabra()
        {
            Array traducciones = null;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");

            if (File.Exists(archivo))
            {
                traducciones = File.ReadAllLines(archivo);
            }

            foreach (var item in traducciones)
            {
                Console.WriteLine(item);
            }

            return "hola";
        }
    }
}
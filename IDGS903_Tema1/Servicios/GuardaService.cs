using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Servicios
{
    public class GuardaService
    {

        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.Matricula;

            var nom = maes.Nombre;

            var apePaterno = maes.Apaterno;

            var apeMaterno = maes.Apamaterno;

            var email = maes.Email;

            var datos = mat + " , " + nom + " , " + apePaterno + " , " + apeMaterno + " , " + email + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            File.AppendAllText(archivo, datos);

        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Distancia
    {
        public double x1 {  get; set; }

        public double x2 { get; set; }

        public double y2 { get; set; }

        public double y1 { get; set; }

        public double Resultado { get; set; }

        public void CalcularDistancia()
        {
            this.Resultado = Math.Sqrt(Math.Pow((this.x2 - this.x1),2) + Math.Pow((this.y2 - this.y1),2));
        }
    }
}
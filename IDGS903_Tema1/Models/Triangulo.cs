using System;

namespace AreaTriangulo.Models
{
    public class Triangulo
    {
        public double X1 { get; set; } //Coordenadas de A

        public double Y1 { get; set; } //Coordenadas de A

        public double X2 { get; set; } //Cordenadas de B

        public double Y2 { get; set; } //Coordenadas de B

        public double X3 { get; set; } //Coordenadas de C

        public double Y3 { get; set; } //Coordenadas de C

        public double DistanciaAB { get; set; }

        public double DistanciaAC { get; set; }

        public double DistanciaBC { get; set; }

        public bool EsTringulo { get; set; }

        public string TringuloStr { get; set; } = string.Empty;

        public double numeroMayor { get; set; }

        public double identificar { get; set; }

        public double AreaTrinagulo { get; set; }

        public double Perimetro { get; set; }

        public void CalcularAB()
        {
            this.DistanciaAB = Math.Round(Math.Sqrt(Math.Pow((this.X2 - this.X1), 2) + Math.Pow((this.Y2 - this.Y1), 2)), 0);
        }

        public void CalcularAC()
        {
            this.DistanciaAC = Math.Round(Math.Sqrt(Math.Pow((this.X3 - this.X1), 2) + Math.Pow((this.Y3 - this.Y1), 2)), 0);
        }

        public void CalcularBC()
        {
            this.DistanciaBC = Math.Round(Math.Sqrt(Math.Pow((this.X3 - this.X2), 2) + Math.Pow((this.Y3 - this.Y2), 2)), 0);
        }

        public void IdentificarTriangulo()
        {

            ObtenerMayor();

            if (this.numeroMayor < this.identificar)
            {
                this.EsTringulo = true;

                TipoTringulo();
            }
            else
            {
                this.EsTringulo = false;

                this.TringuloStr = "No es un triangulo";
            }
        }

        public void TipoTringulo()
        {
            if (this.DistanciaAB == this.DistanciaAC && this.DistanciaAB == this.DistanciaBC)
            {
                this.TringuloStr = "Equilatero";

            }
            else if (this.DistanciaAB == this.DistanciaAC ||
                      this.DistanciaAB == this.DistanciaBC)
            {
                this.TringuloStr = "Isosceles";
            }
            else
            {
                this.TringuloStr = "Escaleno";
            }

            this.Perimetro = (this.DistanciaAB + this.DistanciaAC + this.DistanciaBC) / 2;

            this.AreaTrinagulo = Math.Round(Math.Sqrt(this.Perimetro * (this.Perimetro - this.DistanciaAB) * (this.Perimetro - this.DistanciaAC) * (this.Perimetro - this.DistanciaBC)), 2);
        }

        public void ObtenerMayor()
        {
            this.numeroMayor = this.DistanciaAB;

            this.identificar = this.DistanciaAC + this.DistanciaBC;

            if (this.DistanciaAC > this.numeroMayor)
            {
                this.numeroMayor = this.DistanciaAC;

                this.identificar = this.DistanciaAB + this.DistanciaBC;

            }
            else if (this.DistanciaBC > this.numeroMayor)
            {
                this.numeroMayor = this.DistanciaBC;

                this.identificar = this.DistanciaAB + this.DistanciaAC;
            }
        }
    }
}
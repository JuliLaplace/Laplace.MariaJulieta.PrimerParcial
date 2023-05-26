using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje
    {
        private static int contadorPasajes = 1000;
        private int codigoPasaje;
        private ETipoPasaje tipoDePasaje;
        private double precio;

     

        public Pasaje()
        {
            this.codigoPasaje = contadorPasajes;
            Pasaje.contadorPasajes++;
            this.precio = 0;
            this.tipoDePasaje = ETipoPasaje.Turista;
        }
        public Pasaje( double precio, ETipoPasaje tipoDePasaje):this() //preguntar a seba si esta bien
        {
            this.tipoDePasaje = tipoDePasaje;
            this.precio = precio;

        }

        public int CodigoPasaje
        {
            get { return codigoPasaje; }
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                this.precio = value;
            }
        }
        public ETipoPasaje TipoDePasaje
        {
            get { return tipoDePasaje; }
            set
            {
                this.tipoDePasaje = value;
            }
        }


        public override string ToString()
        {
            return $"Codigo pasaje: {this.CodigoPasaje}";
        }
        public override int GetHashCode()
        {
            return this.CodigoPasaje;
        }
    }
}

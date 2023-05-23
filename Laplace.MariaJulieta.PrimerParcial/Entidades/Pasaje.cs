using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaje
    {
        private int codigoPasaje;
        private ETipoPasaje tipoDePasaje;
        private double precio;
        public Pasaje()
        {
            this.codigoPasaje = 0;
            this.precio = 0;
            this.tipoDePasaje = ETipoPasaje.Turista;
        }
        public Pasaje(int codigoPasaje, double precio, ETipoPasaje tipoDePasaje)
        {
            this.codigoPasaje = codigoPasaje;
            this.tipoDePasaje = tipoDePasaje;
            this.precio = precio;

        }

        public int CodigoPasaje
        {
            get { return codigoPasaje; }
            set
            {
                codigoPasaje = value;
            }
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
    }
}

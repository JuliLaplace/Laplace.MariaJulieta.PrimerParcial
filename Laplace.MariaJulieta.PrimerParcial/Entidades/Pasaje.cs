using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Entidades
{
    public class Pasaje
    {
        private static int contadorPasajes = 1000;
        private int codigoPasaje;
        private ETipoPasaje tipoDePasaje;
        private Vuelo vuelo;



        public Pasaje() 
        {       
            this.vuelo = new Vuelo();
        }
        public Pasaje( ETipoPasaje tipoDePasaje, Vuelo vuelo)
        {
            this.codigoPasaje = contadorPasajes;
            Pasaje.contadorPasajes++;
            this.tipoDePasaje = tipoDePasaje;
            this.vuelo = vuelo;
        }

        public int CodigoPasaje
        {
            get { return codigoPasaje; }
        }

        public ETipoPasaje TipoDePasaje
        {
            get { return tipoDePasaje; }
            set
            {
                this.tipoDePasaje = value;
            }
        }
        public Vuelo Vuelo {
            get { return this.vuelo; }
            set {this.vuelo = value; } 
        }


        public override string ToString()
        {
            return $"Codigo pasaje: {this.CodigoPasaje} - Precio {PrecioPasajeBruto()}";
        }
        public override int GetHashCode()
        {
            return this.CodigoPasaje;
        }

        public double PrecioPasajeBruto()
        {
            double precio=0;

            if (this.vuelo.TipoDeViaje == ETipoViaje.Nacional)
            {
                precio = 50 * vuelo.HorasDeViaje;
            }
            else
            {
                precio = 100 * vuelo.HorasDeViaje;
            }

            if (this.tipoDePasaje == ETipoPasaje.Premium)
            {
                precio *= 1.35;
            }

            return precio;
        }

        public double PrecioPasajeNeto()
        {
            return this.PrecioPasajeBruto()* 1.21;
        }


    }
}

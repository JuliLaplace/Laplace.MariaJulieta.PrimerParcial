using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        
        private string origen;
        private string destino;
        private bool esVueloNacional;
        private Avion unAvion;
        private DateTime diaDePartida;
        private List<Pasajero> pasajeros;
        private int horasDeViaje;
        //private bool ofreceComida;

        public Vuelo(string origen, string destino, bool esVueloNacional, Avion unAvion, DateTime diaDePartida /*bool ofreceComida*/)
        {
            this.origen = origen;
            this.destino = destino;
            this.esVueloNacional = esVueloNacional;
            this.unAvion = unAvion;
            pasajeros = new List<Pasajero>();
            this.diaDePartida = diaDePartida;
            //this.ofreceComida = ofreceComida;
            Random random = new Random();
            if (esVueloNacional)
            {
                horasDeViaje = random.Next(2, 4);
            }
            else
            {
                horasDeViaje = random.Next(8, 12);
            }
        }
        public string Origen
        {
            get { return origen; }
        }
        public string Destino
        {
            get { return destino; }
        }

        public bool EsVueloNacional
        {
            get { return esVueloNacional; }
        }

        /*public bool OfreceComida
        {
            get { return ofreceComida; }
        }*/


        public Avion UnAvion
        {
            get { return unAvion; }
        }

        public List<Pasajero> Pasajeros
        {
            get { return pasajeros; }
        }

        public DateTime DiaDePartida
        {
            get { return diaDePartida; }
        }

        public int HorasDeViaje
        {
            get { return horasDeViaje; }
        }



    
        public void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }



    }


}


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
        private ETipoViaje tipoDeViaje;
        private Avion unAvion;
        private DateTime diaDePartida;
        private List<Pasajero> pasajeros;
        private int horasDeViaje;
        private bool ofreceComida;
        private bool tieneWifi;

        public Vuelo() //sobrecarga de constructores para poder inicializar la lista de pasajeros.
        {
            this.pasajeros = new List<Pasajero>();
            this.origen = "";
            this.destino = "";
            this.unAvion = new Avion();
        }
        public Vuelo(string origen, string destino, ETipoViaje tipoDeViaje, Avion unAvion, DateTime diaDePartida, bool ofreceComida, bool tieneWifi):this()
        {
            this.origen = origen;
            this.destino = destino;
            this.tipoDeViaje = tipoDeViaje;
            this.unAvion = unAvion;
            this.diaDePartida = diaDePartida;
            this.ofreceComida = ofreceComida;
            this.tieneWifi = tieneWifi;

            Random random = new Random();
            if (tipoDeViaje == ETipoViaje.Nacional)
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

        public ETipoViaje TipoDeViaje
        {
            get { return tipoDeViaje; }
        }

        public bool OfreceComida
        {
            get { return ofreceComida; }
        }


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
        public bool TieneWifi
        {
            get { return tieneWifi; }
        }
        public int CantidadPasajesVendidos(ETipoPasaje tipoDePasaje)
        {
            int cantidad = 0;
            foreach (Pasajero item in pasajeros)
            {
                if (item.UnPasaje.TipoDePasaje == tipoDePasaje)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public int CantidadDeAsientosDisponiblesTurista()
        {
            return unAvion.CantidadAsientosTurista() - CantidadPasajesVendidos(ETipoPasaje.Turista);
        }

        public int CantidadDeAsientosDisponiblesPremium()
        {
            return unAvion.CantidadAsientosPremium() - CantidadPasajesVendidos(ETipoPasaje.Premium);
        }



        public void AgregarPasajero(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }


        public static bool operator ==(Vuelo vuelo, Avion avion)
        {
            return (vuelo.UnAvion == avion);
            
        }
        public static bool operator !=(Vuelo vuelo, Avion avion)
        {
            return (vuelo == avion);

        }
    }


}


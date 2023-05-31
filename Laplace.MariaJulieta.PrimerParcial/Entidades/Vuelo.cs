using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Vuelo
    {
        private int codigoVuelo;
        private static int contadorVuelos = 0;
        private string origen;
        private string destino;
        private ETipoViaje tipoDeViaje;
        private Avion unAvion;
        private DateTime diaDePartida;
        private List<Pasajero> pasajeros;
        private int horasDeViaje;
        private bool ofreceComida;
        private bool tieneWifi;


       
        public Vuelo() 
        {
            this.pasajeros = new List<Pasajero>();
            this.origen = "Sin origen";
            this.destino = "Sin destino";
            this.unAvion = new Avion();
            this.codigoVuelo = contadorVuelos;
            Vuelo.contadorVuelos++;

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
        public int CodigoVuelo
        {
            get { return this.codigoVuelo; }
            set { this.codigoVuelo = value; }
        }

        public string Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }
        public string Destino
        {
            get { return this.destino; }
            set
            {
                this.destino = value;
            }
        }

        public ETipoViaje TipoDeViaje
        {
            get { return this.tipoDeViaje; }
            set
            {
                this.tipoDeViaje = value;
            }
        }

        public bool OfreceComida
        {
            get { return this.ofreceComida; }
            set
            {
                this.ofreceComida = value;
            }
        }


        public Avion UnAvion
        {
            get { return this.unAvion; }
            set
            {
                this.unAvion = value;
            }
        }

        public List<Pasajero> Pasajeros
        {
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }

        public DateTime DiaDePartida
        {
            get { return this.diaDePartida; }
            set
            {
                this.diaDePartida = value;
            }
        }

        public int HorasDeViaje
        {
            get { return this.horasDeViaje; }
            set
            {
                this.horasDeViaje = value;
            }
        }
        public bool TieneWifi
        {
            get { return this.tieneWifi; }
            set
            {
                this.tieneWifi = value;
            }
        }
        public int CantidadPasajesVendidos(ETipoPasaje tipoDePasaje)
        {
            int cantidad = 0;
            foreach (Pasajero item in pasajeros)

            {
                foreach (Viaje viaje in item.ListaDeViajes)
                {
                    if (viaje.Pasaje.TipoDePasaje == tipoDePasaje)
                    {
                        cantidad++;
                    }
                }

            }
            return cantidad;
        }
        public int CantidadDeAsientosTurista
        {
            get
            {
                return CantidadDeAsientosDisponiblesTurista();
            }
        }
        public int CantidadDeAsientosPremium
        {
            get
            {
                return CantidadDeAsientosDisponiblesPremium();
            }
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


        
        public static bool operator ==(Vuelo vuelo1, Vuelo vuelo2)
        {
            return (vuelo1.codigoVuelo == vuelo2.codigoVuelo);

        }
        public static bool operator !=(Vuelo vuelo1, Vuelo vuelo2)
        {
            return (vuelo1 == vuelo2);

        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Vuelo)
            {
                retorno = this == ((Vuelo)obj);
            }
            return retorno;
        }

        public override string ToString()
        {
            return $"Origen: {this.Origen}\nDestino: {this.Destino}\nFecha: {this.DiaDePartida}"; 
        }

        public override int GetHashCode()
        {
            return this.codigoVuelo;
        }

        
    }


}


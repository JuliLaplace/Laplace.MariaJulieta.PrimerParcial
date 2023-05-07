using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Pasajero;

namespace Entidades
{
    public class Pasajero 
    {
        private Cliente unCliente;
        private Pasaje unPasaje;
        private Vuelo unVuelo;
        private Equipaje[] equipajePasajero;
        private bool tieneEquipajeDeMano;

        
        public Pasajero(Cliente unCliente, Pasaje unPasaje, Vuelo unVuelo, Equipaje[] equipajeACargar, bool tieneEquipajeDeMano)
        {
            this.unCliente = unCliente;
            this.unPasaje = unPasaje;
            this.unVuelo = unVuelo;
            equipajePasajero = equipajeACargar;
            this.tieneEquipajeDeMano = tieneEquipajeDeMano;
        }


        public Cliente UnCliente
        {
            get { return unCliente; }
        }
        public Equipaje[] EquipajePasajero
        {
            get { return equipajePasajero; }
        }

        public Vuelo UnVuelo
        {
            get { return unVuelo; }
        }

        public Pasaje UnPasaje
        {
            get { return unPasaje; }
        }
        public bool TieneEquipajeDeMano
        {
            get { return tieneEquipajeDeMano; }
        }
       

    }
}


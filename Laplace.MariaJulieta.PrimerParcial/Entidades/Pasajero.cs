using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Pasajero;

namespace Entidades
{
    public class Pasajero : Persona
    {
            private int dni;
            private int edad;   
            private Vuelo unVuelo;
            private Pasaje pasaje;
            private Equipaje[] equipajePasajero;
            private bool tieneEquipajeDeMano;


        public Pasajero(int dni, int edad, Vuelo unVuelo,Pasaje pasaje, Equipaje[] equipajeACargar, bool tieneEquipajeDeMano):base()
            {
                this.dni = dni;
                this.edad = edad;
                this.unVuelo = unVuelo;
                this.pasaje = pasaje;
                this.equipajePasajero = equipajeACargar;
                this.tieneEquipajeDeMano = tieneEquipajeDeMano;
            }


           
            public Equipaje[] EquipajePasajero
            {
                get { return equipajePasajero; }
            }

            public Vuelo UnVuelo
            {
                get { return unVuelo; }
            }

           
            public bool TieneEquipajeDeMano
            {
                get { return tieneEquipajeDeMano; }
            }
            public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2) //cambiar a dni cuando lo agregue como atributo
            {
                return pasajero1.nombre == pasajero2.nombre;    
            }
            public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2) //uso el operador == de arriba
            {
                return !(pasajero1 == pasajero2);
            }

    }
}


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
        private ESexo sexo;
        private int edad;
        private DateTime fechaNacimiento;
        private Pasaje unPasaje;
        private Vuelo unVuelo;
        private Equipaje equipaje;
        private bool tieneEquipajeDeMano;

        public Pasajero() : base()
        {
            this.dni = 0;
            this.sexo = ESexo.Masculino;
            this.edad = 0;
            this.fechaNacimiento = new DateTime(1900, 1, 1);
            this.unPasaje = new Pasaje();
            this.unVuelo = new Vuelo();
            this.equipaje = new Equipaje();
            this.tieneEquipajeDeMano = false;
        }
        public Pasajero(string nombre, string apellido, int dni, DateTime fechaDeNacimiento, ESexo sexo, int edad) : base(nombre, apellido)
        {
            this.dni = dni;
            this.sexo = sexo;
            this.edad = edad;
            this.fechaNacimiento = fechaDeNacimiento;
            this.unPasaje = new Pasaje();
            this.unVuelo = new Vuelo();
            this.equipaje = new Equipaje();
            this.tieneEquipajeDeMano = false ;
        }

        public Pasajero(string nombre, string apellido, int dni, DateTime fechaNacimiento, ESexo sexo, int edad, Equipaje equipajeACargar, bool tieneEquipajeDeMano, Pasaje unPasaje, Vuelo unVuelo) : this(nombre, apellido, dni, fechaNacimiento, sexo, edad)
        {
          
            this.unPasaje = unPasaje;
            this.unVuelo = unVuelo;
            this.equipaje = equipajeACargar;
            this.tieneEquipajeDeMano = tieneEquipajeDeMano;
           
        }

        public int Dni
        {
            get { return dni; }
            set
            {
                if (value > 1000000 && value < 999999999)
                {

                    dni = value;
                }


            }

        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public ESexo Sexo
        {
            get { return sexo; }
            set { this.sexo = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0 && value < 100)
                {
                    edad = value;
                }
            }
        }

        public Equipaje Equipaje
        {
            get { return equipaje; }
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
        //Para comparar pasajeros por dni
        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            return pasajero1.dni == pasajero2.dni;
        }
        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2) //uso el operador == de arriba
        {
            return !(pasajero1 == pasajero2);
        }

        public override bool Equals(object? obj) //esta bien??
        {
            bool retorno = false;

            if (obj is Pasajero)
            {
                retorno = this == ((Pasajero)obj);
            }
            return retorno;
        }

        public override int GetHashCode() //con esto se le dice que se le de hascodes a los objetos en base a su dni y no su direccion de memoria
        {
            return (dni).GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.Apellido}, {this.Nombre} - DNI: {this.Dni}";
        }


    }
}


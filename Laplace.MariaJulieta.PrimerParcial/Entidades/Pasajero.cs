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
        private List<Viaje> listaDeViajes;

        public Pasajero() : base()
        {
            this.dni = 0;
            this.sexo = ESexo.Masculino;
            this.edad = 0;
            this.fechaNacimiento = new DateTime(1900, 1, 1);
            this.listaDeViajes = new List<Viaje>();
        }

        public Pasajero(string nombre, string apellido, int dni, DateTime fechaDeNacimiento, ESexo sexo, int edad) : base(nombre, apellido)
        {
            this.dni = dni;
            this.sexo = sexo;
            this.edad = edad;
            this.fechaNacimiento = fechaDeNacimiento;
            this.listaDeViajes = new List<Viaje>();
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

        public List<Viaje> ListaDeViajes {
            get { return this.listaDeViajes; }
            set {this.listaDeViajes = value; } 
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

        public void AgregarViaje(Viaje viaje)
        {
            this.listaDeViajes.Add(viaje);  
        }


    }
}


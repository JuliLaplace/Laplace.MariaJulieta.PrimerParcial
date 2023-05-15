using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int dni;
        private ESexo sexo;
        private int edad;

        public Cliente():base()
        {
            this.dni = 0;
            this.sexo = ESexo.Masculino;
            this.edad = 0;
        }
        public Cliente(string nombre, string apellido, int dni, ESexo sexo, int edad):base(nombre,apellido)
        {
            this.dni = dni;
            this.sexo = sexo;
            this.edad = edad;
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

        //Para comparar clientes por dni
        public static bool operator ==(Cliente cliente1, Cliente cliente2) 
        {
            return cliente1.dni == cliente2.dni;
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2) //uso el operador == de arriba
        {
            return !(cliente1 == cliente2);
        }

        public override bool Equals(object? obj) //esta bien??
        {
            bool retorno =false;

            if(obj is Cliente)
            {
                retorno = this == ((Cliente)obj);
            }
            return retorno;
        }

        public override int GetHashCode() //con esto se le dice que se le de hascodes a los objetos en base a su dni y no su direccion de memoria
        {
            return (dni).GetHashCode();
        }

        
    }
}

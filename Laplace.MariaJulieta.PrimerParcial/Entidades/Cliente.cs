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

        public Cliente(string nombre, string apellido, int dni, ESexo sexo, int edad):base(nombre, apellido)
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
        public static bool operator ==(Cliente cliente1, Cliente cliente2) //cambiar a dni cuando lo agregue como atributo
        {
            return cliente1.dni == cliente2.dni;
        }
        public static bool operator !=(Cliente cliente1, Cliente cliente2) //uso el operador == de arriba
        {
            return !(cliente1 == cliente2);
        }
    }
}

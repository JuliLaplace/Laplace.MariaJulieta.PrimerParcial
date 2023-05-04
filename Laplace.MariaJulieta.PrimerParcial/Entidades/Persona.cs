using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }




        public string Apellido
        {
            get { return this.apellido; }
            //set { this.apellido = value; }
            
        }
        public string Nombre
        {
            get { return this.nombre; }
            //set { this.nombre = value; }
        }


        protected string MostrarPersona()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"Apellido: {this.apellido}");
            cadena.AppendLine($"Nombre: {this.nombre}");
            return cadena.ToString();
        }
    }
}

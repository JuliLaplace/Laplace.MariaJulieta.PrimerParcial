using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona // abstracta porque jamas voy a instancias una persona, si voy a instanciar a sus derivadas (cliente - usuario)
    {
        protected string apellido;
        protected string nombre;


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }



        [JsonProperty("apellido")]
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }

        }
        [JsonProperty("nombre")]
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
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

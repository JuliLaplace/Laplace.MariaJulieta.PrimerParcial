using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Entidades
{
    public class Usuario : Persona
    {
        private string correo;
        private string clave;
        private int legajo;
        private string perfil;


        public Usuario(string nombre, string apellido, string correo, string clave, int legajo, string perfil):base (nombre, apellido){

            
            this.correo = correo;   
            this.clave = clave; 
            this.legajo = legajo;
            this.perfil = perfil;   

        
        }
        [JsonProperty("clave")]
        public string Clave
        {
            
            set { this.clave = value; }
        }
        [JsonProperty("correo")]
        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }
        [JsonProperty("legajo")]
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        [JsonProperty("perfil")]
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public bool EsContraseñaCorrecta(string clave)
        {
            return (clave == this.clave);
        }

        public string MostrarUsuario()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"{base.MostrarPersona()}");
            cadena.AppendLine($"Correo: {this.correo}");
            cadena.AppendLine($"Clave: {this.clave}");
            cadena.AppendLine($"Legajo: {this.legajo}");
            cadena.AppendLine($"Usuario: {this.perfil}");
            return cadena.ToString();
        }
    }
}

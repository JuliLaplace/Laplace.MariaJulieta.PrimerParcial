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


        public Usuario(string nombre, string apellido, string correo, string clave, int legajo, string perfil) : base(nombre, apellido) {


            this.correo = correo;
            this.clave = clave;
            this.legajo = legajo;
            this.perfil = perfil;


        }
        [JsonProperty("clave")]
        public string Clave
        {
            get { return this.clave; }
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

        //public static bool operator ==(Usuario usuario1, Usuario usuario2)
        //{
        //    return ((usuario1.Correo == usuario2.Correo) && (usuario1.clave == usuario2.clave));
        //}
        //public static bool operator !=(Usuario usuario1, Usuario usuario2) //uso el operador == de arriba
        //{
        //    return !(usuario1 == usuario2);
        //}

        //public override bool Equals(object? obj) //esta bien??
        //{
        //    bool retorno = false;

        //    if (obj is Usuario)
        //    {
        //        retorno = this == ((Usuario)obj);
        //    }
        //    return retorno;
        //}
    }
}

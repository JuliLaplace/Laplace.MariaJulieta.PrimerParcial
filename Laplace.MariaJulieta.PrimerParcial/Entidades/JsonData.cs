using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Entidades
{
    public static class JsonData
    {
        //static string ruta;
        static JsonData()
        {
            //ruta = AppDomain.CurrentDomain.BaseDirectory;
            //ruta += @"\Archivos-Serializacion";
        }
        public static List<Usuario> LeerUsuario() 
        {
            List<Usuario>? listaDeUsuariosEnJson = new List<Usuario>();
            using(StreamReader read = new StreamReader("MOCK_DATA.json"))
            {
                string archivoALeer = read.ReadToEnd();
                listaDeUsuariosEnJson = JsonConvert.DeserializeObject<List<Usuario>>(archivoALeer);
                if(listaDeUsuariosEnJson is null)
                {
                    listaDeUsuariosEnJson = new List<Usuario>();
                }

            }
            return listaDeUsuariosEnJson;
        }
       
       
    }
    
}

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
        static string ruta;
        static JsonData()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion";
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

        public static List<Avion> LeerAviones()
        {
            string rutaCompleta = ruta + @"\ArchivoJsonEscribirListaAviones.json";
            List<Avion>? listaDeAvionesEnJson = new List<Avion>();
            using (StreamReader read = new StreamReader(rutaCompleta))
            {
                string archivoALeer = read.ReadToEnd();
                listaDeAvionesEnJson = JsonConvert.DeserializeObject<List<Avion>>(archivoALeer);
                if (listaDeAvionesEnJson is null)
                {
                    listaDeAvionesEnJson = new List<Avion>();
                }

            }
            return listaDeAvionesEnJson;
        }

        public static void EscribirListaAviones(List<Avion> listaAviones)
        {
            string rutaCompleta = ruta + @"\ArchivoJsonEscribirListaAviones.json";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                string archivo = JsonConvert.SerializeObject(listaAviones);
                sw.WriteLine(archivo);
            }
        }   
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public static class JsonData
    {
        public static List<Usuario>? LeerUsuario() //esta bien? esto deja que la lista sea null (ELIMINA WARNING)
        {
            List<Usuario>? listaDeUsuariosEnJson = new List<Usuario>();
            using(StreamReader read = new StreamReader("MOCK_DATA.json"))
            {
                string archivoALeer = read.ReadToEnd();
                listaDeUsuariosEnJson = JsonConvert.DeserializeObject<List<Usuario>>(archivoALeer);

            }
            return listaDeUsuariosEnJson;
        }
        public static void SeriaLizarVuelos()
        {

        }
    }
    
}

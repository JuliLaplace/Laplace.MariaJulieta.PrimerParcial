using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class XmlData
    {
        static string ruta;
        static XmlData()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion";
        }
   
        public static void EscribirListaVuelos(List<Vuelo> listaDeVuelos)
        {
            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaVuelos.xml";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Vuelo>));
                xmlSer.Serialize(sw, listaDeVuelos);
            }

        }
        public static void EscribirListaPasajeros(List<Pasajero> listaDePasajeros)
        {
            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaClientes.xml";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(List<Pasajero>));
                    xmlSer.Serialize(sw, listaDePasajeros);
                }
        }
      
        public static List<Vuelo> LeerListaVuelos()
        {
            List<Vuelo>? listaAux = new List<Vuelo>();

            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaVuelos.xml";
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Vuelo>));
                    listaAux = (List<Vuelo>?)xmlSerializer.Deserialize(sr);
                    if (listaAux is null)
                    {
                        listaAux = new List<Vuelo>();
                    }
                }
            }

            return listaAux;
        }

        public static List<Pasajero> LeerListaPasajeros()
        {
            List<Pasajero>? listaAux = null;

            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaClientes.xml";
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pasajero>));
                    listaAux = (List<Pasajero>?)xmlSerializer.Deserialize(sr);
                   
                }

            }
            if (listaAux is null)
            {
                listaAux = new List<Pasajero>();
            }
            return listaAux;
        }
    }
}

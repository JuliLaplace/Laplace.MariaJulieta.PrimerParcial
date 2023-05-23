using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivo
    {
        static string ruta;
        static Archivo()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos-Serializacion";
        }
        public static void EscribirLista(List<Avion> listaDeAviones)
        {
            string rutaCompleta = ruta + @"\ArchivoXmlEscribirLista.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(List<Avion>));
                    xmlSer.Serialize(sw, listaDeAviones);
                }
            }

            catch (Exception)
            {

                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }
        public static void EscribirLista(List<Pasajero> listaDePasajeros)
        {
            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaClientes.xml";

            try
            {
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

            catch (Exception)
            {

                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }
        public static List<Avion> LeerLista()
        {
            List<Avion> listaAux = null;

            string rutaCompleta = ruta + @"\ArchivoXmlEscribirLista.xml";
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Avion>));
                    listaAux = (List<Avion>)xmlSerializer.Deserialize(sr);
                }
            }

            return listaAux;
        }

        public static List<Pasajero> LeerListaPasajeros()
        {
            List<Pasajero> listaAux = null;

            string rutaCompleta = ruta + @"\ArchivoXmlEscribirListaClientes.xml";
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pasajero>));
                    listaAux = (List<Pasajero>)xmlSerializer.Deserialize(sr);
                }
            }

            return listaAux;
        }
    }
}

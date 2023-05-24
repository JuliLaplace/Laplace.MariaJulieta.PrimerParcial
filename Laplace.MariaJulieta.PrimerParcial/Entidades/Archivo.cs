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
        public static void EscribirListaAviones(List<Avion> listaDeAviones)
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
        public static void EscribirListaPasajeros(List<Pasajero> listaDePasajeros)
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
      
        public static List<Avion> LeerListaAviones()
        {
            List<Avion>? listaAux = new List<Avion>();

            string rutaCompleta = ruta + @"\ArchivoXmlEscribirLista.xml";
            string datos = string.Empty;
            if (Directory.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Avion>));
                    listaAux = (List<Avion>?)xmlSerializer.Deserialize(sr);
                    if(listaAux is null)
                    {
                        listaAux= new List<Avion>();
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



        //PREGUNTAR A FACUNDO

        //public static void EscribirLista(List<Object> listaDePasajeros, string ruta)
        //{
        //    string rutaCompleta = ruta + @"\ArchivoXmlEscribirLista.xml";

        //    try
        //    {
        //        if (!Directory.Exists(ruta))
        //        {
        //            Directory.CreateDirectory(ruta);
        //        }
        //        using (StreamWriter sw = new StreamWriter(rutaCompleta))
        //        {
        //            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Object>));
        //            xmlSer.Serialize(sw, listaDePasajeros);
        //        }
        //    }

        //    catch (Exception)
        //    {

        //        throw new Exception($"Error en el archivo {rutaCompleta}");
        //    }
        //}
    }
}

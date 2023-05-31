using System.Text.Json;
using System;
using System.IO;



namespace Entidades
{
    public static class Empresa
    {
        private static List<Usuario>? usuarios;
        private static List <Avion> aviones;
        private static List<Vuelo> vuelos;
        private static List<Pasajero> pasajeros;
        //private static Dictionary<string, int> destinoMasElegido;
        //private static Dictionary<Pasajero, int> pasajerosFrecuentes;
        //private static double gananciaTotalCabojate;
        //private static double gananciaTotalInternacional;
        private static string [] destinosNacionales;
        private static string[] destinosInternacionales;
        
       
        static Empresa()
        {
            usuarios = new List<Usuario>();
            aviones = new List<Avion>();
            vuelos = new List<Vuelo>();
            pasajeros = new List<Pasajero>();
            //destinoMasElegido = new Dictionary<string, int>();
            //pasajerosFrecuentes = new Dictionary<Pasajero, int>();
            destinosInternacionales = new string[4];
            destinosNacionales = new string[15];
            LeerUsuarios();
            HarcodearDestinosNacionales();
            HarcodearDestinosInternacionales();
            HarcodearPasajeros();
            HarcodearAviones();
            HarcodearVuelos();
        }

        
        private static void LeerUsuarios()
        {
            usuarios = JsonData.LeerUsuario();
        }

        private static void HarcodearAviones()
        {
            aviones = JsonData.LeerAviones();

        }
        private static void HarcodearVuelos()
        {
            vuelos = XmlData.LeerListaVuelos();
        }
        private static void HarcodearPasajeros()
        {
            pasajeros = XmlData.LeerListaPasajeros();
        }
        /// <summary>
        /// Metodo estatico que carga los destinos (nacionales o internacionales) en un array de string
        /// </summary>
        private static void HarcodearDestinosInternacionales() 
        {
            destinosInternacionales = new string[] { "Recife (Brasil)", "Roma (Italia)", "Acapulco (México)", "Miami (EE.UU.)" };
        }
        private static void HarcodearDestinosNacionales()
        {
            destinosNacionales = new string[] { "Santa Rosa", "Bariloche", "Corrientes", "Córdoba", "Jujuy", "Mendoza", "Neuquén", "Posadas", "Iguazú", "Salta", "Santiago del Estero", "Trelew", "Tucumán", "Puerto Madryn", "Ushuaia" };
        }

        /// <summary>
        /// Metodo que realiza la validacion de un usuario segun el correo y la clave ingresada. 
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static Usuario ValidarUnUsuario(string correo, string clave)
        {
                               
            foreach (Usuario item in usuarios)
            {
                if (item.Correo == correo && item.EsContraseñaCorrecta(clave))
                {
                    return item;
                }
            }
            return null;
        }


        /// <summary>
        ///   Metodos que muestras Listas segun lo pedido por el usuario
        /// </summary>
        /// <returns>Retorna una lista de un tipo de objeto determinado segun la necesidad del usuario</returns>
        public static List<Avion> ListarAviones()
        {
            List<Avion> mostrarAviones = new List<Avion>();
            foreach (Avion item in aviones)
            {
                mostrarAviones.Add(item);
            }
            return mostrarAviones;
        }
        public static List<Pasajero> ListarPasajeros()
        {
            List<Pasajero> mostrarPasajeros = new List<Pasajero>();
            foreach(Pasajero item in pasajeros)
            {
                mostrarPasajeros.Add(item);
            }
            return mostrarPasajeros;
        }


        public static List<Vuelo> ListarVuelos()
        {
            List<Vuelo> mostrarVuelos = new List<Vuelo>();
            foreach (Vuelo item in vuelos)
            {
                mostrarVuelos.Add(item);
                
            }
            return mostrarVuelos;
        }
        public static List<Vuelo> ListarVuelosDisponibles()
        {
            List<Vuelo> mostrarVuelos = new List<Vuelo>();
            foreach (Vuelo item in vuelos)
            {
                if(item.DiaDePartida >= DateTime.Today)
                {
                    mostrarVuelos.Add(item);
                }
                

            }
            return mostrarVuelos;
        }
        /// <summary>
        /// Metodos que Agregan objetos a un listado especifico - por cada objeto Pasajero/Vuelo/Avion que se cree (mediante los parametros enviados), se lo agrega a la lista correspondiente (pasajeros - vuelos - aviones)
        /// El metodo tambien sobreescribe el archivo XML/JSON cada momento que la lista es modificada agregando un elemento mas en ella.
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="sexo"></param>
        /// <param name="fecha"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public static void AgregarUnPasajero(string apellido, string nombre, ESexo sexo, DateTime fecha,  int edad, string dni)
        {
            pasajeros.Add(new Pasajero(nombre, apellido, Validador.CadenaStringAInt(dni), fecha, sexo, edad));
            XmlData.EscribirListaPasajeros(pasajeros);
        }

        public static void AgregarVuelo(string origen, string destino, ETipoViaje tipoDeViaje, Avion avion, DateTime diaDeViaje, bool ofreceComida, bool ofreceWifi)
        {
            vuelos.Add(new Vuelo(origen, destino, tipoDeViaje, avion, diaDeViaje, ofreceComida, ofreceWifi));            
            XmlData.EscribirListaVuelos(vuelos);
        }
        public static void AgregarAvion(EAvion avion, string matricula, int cantidadAsientos, int cantidadBanios, float capacidadBodega)
        {
            aviones.Add(new Avion(avion, matricula, cantidadAsientos, cantidadBanios, capacidadBodega));
            JsonData.EscribirListaAviones(aviones);
        }

        public static string[] ListarDestinosNacionales()
        {
            return Empresa.destinosNacionales;
        }
        public static string[] ListarDestinosInternacionales()
        {
            return Empresa.destinosInternacionales;
        }
        /// <summary>
        /// Metodos que filtran segun necesidad del ususario. Metodo FiltrarvuelosPorBusqueda recibe distintos parametros que se utilizaran para buscar dentro de la lista vuelos, el elemento especifico.
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="fechaIngresada"></param>
        /// <param name="servicioComida"></param>
        /// <param name="servicioWifi"></param>
        /// <returns></returns>
        public static List<Vuelo> FiltrarVuelosPorBusqueda(string origen, string destino, DateTime fechaIngresada, bool servicioComida, bool servicioWifi)
        {
            List<Vuelo> mostrarVuelos = new List<Vuelo>();
            foreach (Vuelo item in vuelos)
            {
                bool cumpleCondicionesCuidades = false;
                bool cumpleCondicionFecha = false;
                bool cumpleCondicionComida = false;
                bool cumpleCondicionWifi = false;

                if (item.Destino == destino && item.Origen == origen)
                {
                    cumpleCondicionesCuidades = true;
                }
                if (item.DiaDePartida.Date == fechaIngresada.Date)
                {
                    cumpleCondicionFecha = true;
                }

                if (servicioComida)
                {
                    cumpleCondicionComida = item.OfreceComida;   
                }
                else
                {
                    cumpleCondicionComida = true;
                }

                if (servicioWifi)
                {
                    cumpleCondicionWifi = item.TieneWifi;
                }
                else
                {
                    cumpleCondicionWifi = true;
                }

                if (cumpleCondicionComida && cumpleCondicionesCuidades && cumpleCondicionFecha && cumpleCondicionWifi)
                {
                    mostrarVuelos.Add(item);
                }

            }
            return mostrarVuelos;
        }

        public static List<Pasajero> FiltrarPasajerosPorBusqueda(string nombre, string apellido, int dni)
        {
            List<Pasajero> mostrarPasajeros = new List<Pasajero>();

            foreach (Pasajero item in pasajeros)
            {
                bool cumpleCondicion = true;

                if (!string.IsNullOrEmpty(nombre) && item.Nombre != nombre)
                {
                    cumpleCondicion = false;
                }

                if (!string.IsNullOrEmpty(apellido) && item.Apellido != apellido)
                {
                    cumpleCondicion = false;
                }

                if (dni != 0 && item.Dni != dni)
                {
                    cumpleCondicion = false;
                }

                if (cumpleCondicion)
                {
                    mostrarPasajeros.Add(item);
                }
            }

            return mostrarPasajeros;
        }

       
        /// <summary>
        /// Metodo que elimina un objeto (ya sea pasajero, avion o vuelo) de una lista segun que se le indique por parametro.
        /// Metodo con sobrecarga para PASAJER - VUELO - AVION
        /// </summary>
        /// <param name="pasajero"></param>
        public static void Eliminar(Pasajero pasajero)
        {
            foreach (Pasajero item in pasajeros)
            {
                if (pasajero == item)
                {
                    pasajeros.Remove(pasajero);
                    break; 
                }
            }
        }
        public static void Eliminar(Avion avion)
        {
            foreach (Avion item in aviones)
            {
                if (avion == item)
                {
                    aviones.Remove(avion);
                    break;
                }
            }
        }
        public static void Eliminar(Vuelo vuelo)
        {
            foreach (Vuelo item in vuelos)
            {
                if (vuelo == item)
                {
                    vuelos.Remove(vuelo);
                    break;
                }
            }
        }

        /// <summary>
        /// Metodos que modifican un objeto especifico dentro de una lista especifica. Si se quiere eliminar un Pasajero, se lo busca en la lista "pasajeros" segun su dni, y se modifican sus atributos
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        public static void Modificar(Pasajero pasajero, string nombre, string apellido, ESexo sexo)
        {
            foreach (Pasajero item in pasajeros)
            {
                if (pasajero == item)
                {
                    item.Nombre = nombre;
                    item.Apellido = apellido;
                    item.Sexo = sexo;
                    break;
                }
            }
        }
        public static void Modificar(Avion avion, EAvion nombre, int cantidadAsientos, int cantidadBaños, float capacidad)
        {
            foreach (Avion item in aviones)
            {
                if (avion == item)
                {
                    item.Nombre = nombre;
                    item.CantidadDeBanios = cantidadBaños;
                    item.CantidadDeAsientos = cantidadAsientos;
                    item.CapacidadBodega = capacidad;
                    break;
                }
            }
        }

        public static void Modificar(Vuelo vuelo, string origen, string destino, ETipoViaje tipoDeViaje, Avion avionSeleccionado, DateTime fechaPartida, bool ofreceServicioComida, bool ofreceServicioWifi)
        {
            foreach (Vuelo item in vuelos)
            {
                if ( vuelo == item)
                {
                    item.Origen = origen;
                    item.Destino = destino;
                    item.TipoDeViaje = tipoDeViaje;
                    item.UnAvion= avionSeleccionado;
                    item.DiaDePartida= fechaPartida;
                    item.OfreceComida= ofreceServicioComida;
                    item.TieneWifi= ofreceServicioWifi;
                    item.UnAvion = avionSeleccionado;
                    break;
                }
            }
        }

        public static bool EstaAvionEnVuelo(Avion avion, DateTime fecha)
        {
            bool estaEnVuelo = false;

            foreach (Vuelo item in vuelos)
            {
                if (item.UnAvion == avion)
                {
                    DateTime fechaLlegada = item.DiaDePartida.AddHours(item.HorasDeViaje);
                    if (fecha >= item.DiaDePartida && fecha <= fechaLlegada)
                    {
                        estaEnVuelo = true;
                        break;
                    }
                }
            }

            return estaEnVuelo;
        }

        public static void CargarPasajeroVuelo(Vuelo vuelo, Pasajero pasajero)
        {
            vuelo.AgregarPasajero(pasajero);
        }




     






    }
}
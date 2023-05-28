using System.Text.Json;
using System;
using System.IO;



namespace Entidades
{
    public static class Empresa
    {
        private static List<Usuario>? usuarios; // DEJO EL ? ?????
        private static List <Avion> aviones;
        private static List<Vuelo> vuelos;
        private static List<Pasajero> pasajeros;
        private static Dictionary<string, int> destinoMasElegido;
        private static Dictionary<Cliente, int> pasajerosFrecuentes;
        private static double gananciaTotalCabojate;
        private static double gananciaTotalInternacional;
        private static string [] destinosNacionales;
        private static string[] destinosInternacionales;
        
       
        static Empresa()
        {
            usuarios = new List<Usuario>();
            aviones = new List<Avion>();
            vuelos = new List<Vuelo>();
            pasajeros = new List<Pasajero>();
            destinoMasElegido = new Dictionary<string, int>();
            pasajerosFrecuentes = new Dictionary<Cliente, int>();
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
            aviones = Archivo.LeerListaAviones();
        }
        private static void HarcodearVuelos()
        {
            vuelos.Add(new Vuelo(destinosNacionales[3], destinosNacionales[0], ETipoViaje.Nacional, aviones[2], DateTime.Now, true, true));
            vuelos.Add(new Vuelo(destinosNacionales[2], destinosNacionales[6], ETipoViaje.Nacional, aviones[3], DateTime.Now, false, false));
            vuelos.Add(new Vuelo(destinosNacionales[5], destinosNacionales[1], ETipoViaje.Nacional, aviones[0], DateTime.Now, false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[1], destinosInternacionales[0], ETipoViaje.Internacional, aviones[5], DateTime.Now, false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[3], ETipoViaje.Internacional, aviones[6], DateTime.Today,true, true));
            vuelos.Add(new Vuelo(destinosNacionales[1], destinosNacionales[3], ETipoViaje.Nacional, aviones[4], new DateTime(2022, 10, 5, 12, 30, 0), false, false));
            vuelos.Add(new Vuelo(destinosInternacionales[2], destinosInternacionales[1], ETipoViaje.Internacional, aviones[0], new DateTime(2022, 10, 5, 12, 30, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[1], ETipoViaje.Internacional, aviones[1], new DateTime(2022, 10, 6, 10, 00, 0), true, false));
            vuelos.Add(new Vuelo(destinosInternacionales[1], destinosInternacionales[0], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 6, 10, 00, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[2], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[3], destinosInternacionales[1], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[2], destinosNacionales[0], ETipoViaje.Nacional, aviones[2], new DateTime(2022, 10, 8, 22, 15, 0), false, true));
            vuelos.Add(new Vuelo(destinosNacionales[3], destinosNacionales[5], ETipoViaje.Nacional, aviones[2], new DateTime(2022, 10, 8, 22, 15, 0), true, true));
            vuelos.Add(new Vuelo(destinosInternacionales[3], destinosInternacionales[0], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 9, 17, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[0], destinosNacionales[3], ETipoViaje.Nacional, aviones[1], new DateTime(2022, 10, 9, 17, 30, 0), true, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[2], ETipoViaje.Internacional, aviones[4], new DateTime(2024, 11, 8, 15, 30, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[3], destinosInternacionales[1], ETipoViaje.Internacional, aviones[4], new DateTime(2023, 01, 7, 8, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[2], destinosNacionales[0], ETipoViaje.Nacional, aviones[2], new DateTime(2021, 10, 9, 20, 15, 0), false, true));
            vuelos.Add(new Vuelo(destinosNacionales[3], destinosNacionales[5], ETipoViaje.Nacional, aviones[1], new DateTime(2025, 12, 3, 15, 15, 0), true, true));
            vuelos.Add(new Vuelo(destinosInternacionales[3], destinosInternacionales[0], ETipoViaje.Internacional, aviones[2], new DateTime(2023, 6, 9, 17, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[0], destinosNacionales[3], ETipoViaje.Nacional, aviones[0], new DateTime(2024, 10, 9, 17, 30, 0), true, true));
        }
        private static void HarcodearPasajeros()
        {
            //pasajeros.Add(new Pasajero("Andrea", "Papana", 35454676, new DateTime(1991, 4, 9), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1991, 4, 9)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Martin", "Lorez", 20343562, new DateTime(1982, 3, 10), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1982, 3, 10)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Juan", "Zeia", 25674273, new DateTime(2001, 11, 12), ESexo.NoBinario, ((int)((DateTime.Now - new DateTime(2001, 11, 12)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Juana", "Garcia", 34172934, new DateTime(1991, 4, 10), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1991, 4, 10)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Laura", "Pep", 31825374, new DateTime(1990, 1, 9), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1990, 1, 9)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Ariel", "Lisboa", 201632348, new DateTime(1968, 11, 12), ESexo.NoBinario, ((int)((DateTime.Now - new DateTime(1968, 11, 12)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Melody", "Perez", 19453826, new DateTime(1962, 1, 4), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1962, 1, 4)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Martin", "Gil", 20351827, new DateTime(1964, 2, 5), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1964, 2, 5)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Gladys", "Perez", 22373812, new DateTime(1968, 5, 1), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1968, 5, 1)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Ludmila", "Papana", 19726384, new DateTime(1962, 2, 10), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1962, 2, 10)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Martin", "Reinoso", 18263826, new DateTime(1961, 8, 9), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1961, 8, 9)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Juan", "Loncopan", 40283713, new DateTime(1999, 9, 1), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1999, 9, 1)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Laura", "Samiel", 28322929, new DateTime(1989, 11, 3), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1989, 11, 3)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Manuel", "Saluo", 35637283, new DateTime(1991, 10, 12), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1991, 10, 12)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Macarena", "Lorez", 42673849, new DateTime(2001, 3, 12), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(2001, 3, 12)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Andrea", "Gimenez", 37652839, new DateTime(1992, 1, 11), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1992, 1, 11)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Martin", "Garcia", 31928361, new DateTime(1990, 7, 7), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1990, 7, 7)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Abel", "Gorriti", 25637292, new DateTime(1980, 5, 3), ESexo.NoBinario, ((int)((DateTime.Now - new DateTime(1980, 5, 3)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Maricel", "von Hinke", 26738291, new DateTime(1985, 11, 10), ESexo.Femenino, ((int)((DateTime.Now - new DateTime(1985, 11, 10)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Pablo", "Paez", 18725392, new DateTime(1960, 4, 11), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1960, 4, 11)).TotalDays / 365.25))));
            //pasajeros.Add(new Pasajero("Leonel", "Garcia", 17263518, new DateTime(1957, 4, 4), ESexo.Masculino, ((int)((DateTime.Now - new DateTime(1957, 4, 4)).TotalDays / 365.25))));
            //Archivo.EscribirListaPasajeros(pasajeros);
            pasajeros = Archivo.LeerListaPasajeros();
            
            
        }
        private static void HarcodearDestinosInternacionales() 
        {
            destinosInternacionales = new string[] { "Recife (Brasil)", "Roma (Italia)", "Acapulco (México)", "Miami (EE.UU.)" };
        }
        private static void HarcodearDestinosNacionales()
        {
            destinosNacionales = new string[] { "Santa Rosa", "Bariloche", "Corrientes", "Córdoba", "Jujuy", "Mendoza", "Neuquén", "Posadas", "Iguazú", "Salta", "Santiago del Estero", "Trelew", "Tucumán", "Puerto Madryn", "Ushuaia" };
        }


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
        public static void AgregarUnPasajero(string apellido, string nombre, ESexo sexo, DateTime fecha,  int edad, string dni)
        {
            pasajeros.Add(new Pasajero(nombre, apellido, Validador.CadenaStringAInt(dni), fecha, sexo, edad));
            Archivo.EscribirListaPasajeros(pasajeros);

        }

        public static void AgregarVuelo(string origen, string destino, ETipoViaje tipoDeViaje, Avion avion, DateTime diaDeViaje, bool ofreceComida, bool ofreceWifi)
        {
            vuelos.Add(new Vuelo(origen, destino, tipoDeViaje, avion, diaDeViaje, ofreceComida, ofreceWifi));            
            
        }
        public static void AgregarAvion(EAvion avion, string matricula, int cantidadAsientos, int cantidadBanios, float capacidadBodega)
        {
          
            aviones.Add(new Avion(avion, matricula, cantidadAsientos, cantidadBanios, capacidadBodega));
            Archivo.EscribirListaAviones(aviones);
            
        }

        public static string[] ListarDestinosNacionales()
        {
            return Empresa.destinosNacionales;
        }
        public static string[] ListarDestinosInternacionales()
        {
            return Empresa.destinosInternacionales;
        }

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
        public static Pasajero BuscarPasajeroPorDni(int dni)
        {

            Pasajero pasajeroEncontrado = new Pasajero();

            foreach (Pasajero pasajero in pasajeros)
            {
                if (pasajero.Dni == dni)
                {
                    pasajeroEncontrado = pasajero;
                    break; // Si se encuentra el cliente, se termina el bucle
                }
            }
            return pasajeroEncontrado;

        }
        //sobrecarga
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


        public static void ModificarPasajero(Pasajero pasajero, string nombre, string apellido, ESexo sexo)
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


        public static bool EstaAvionEnVuelo(Avion avion, List<Vuelo> lista)
        {
            Vuelo vueloEncontrado = null;
            bool estaEnVuelo = false;

            foreach (Vuelo item in lista)
            {
                if (item.UnAvion == avion)
                {
                    vueloEncontrado = item;
                    
                    break; // Se encontró el avión en un vuelo, se sale del bucle
                }
            }

            if (vueloEncontrado != null)
            {
                estaEnVuelo = true;
            }
            else
            {
                
            }
            return estaEnVuelo;
           
        }
        public static void ModificarAvion(Avion avion, EAvion nombre, string matricula, int cantidadAsientos, int cantidadBaños, float capacidad)
        {
            foreach (Avion item in aviones)
            {
                if (avion == item)
                {
                    item.Nombre = nombre;
                    item.Matricula = matricula;
                    item.CantidadDeBanios = cantidadBaños;
                    item.CantidadDeAsientos = cantidadAsientos;
                    item.CapacidadBodega = capacidad;
                    break;
                }
            }
        }

        public static void CargarPasajeroVuelo(Vuelo vuelo, Pasajero pasajero)
        {
            vuelo.AgregarPasajero(pasajero);
        }




        //public static Avion BuscarAvionPorMatricula(List<Avion> aviones, string matriculaBuscada)
        //{
        //    Avion avion = new Avion();
        //    foreach (Avion item in aviones)
        //    {
        //        if(matriculaBuscada == item.Matricula)
        //        {
        //            avion = item;
        //        }
        //    }
        //    return avion;
        //}

        
    }
}
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

        }
        private static void HarcodearPasajeros()
        {
            pasajeros.Add(new Pasajero("Andrea", "Papana", 35454676, ESexo.Femenino, 34));
            pasajeros.Add(new Pasajero("Martin", "Lorez", 20343562, ESexo.Masculino, 24));
            pasajeros.Add(new Pasajero("Juan", "Zeia", 25674273, ESexo.NoBinario, 50));
            //clientes.Add(new Cliente(37289384, "Perez", "Federico", ESexo.Masculino, 34));
            //clientes.Add(new Cliente(47362983, "Manzo", "Ludmila", ESexo.Femenino, 24));
            //clientes.Add(new Cliente(35627839, "Firma", "Tristan", ESexo.Masculino, 61));
            //clientes.Add(new Cliente(35454676, "Lopez", "Maria", ESexo.Femenino, 19));
            //clientes.Add(new Cliente(20343562, "Martinez", "Florencia", ESexo.Femenino, 33));
            //clientes.Add(new Cliente(25674273, "Remallo", "Veronica", ESexo.NoBinario, 54));
            //clientes.Add(new Cliente(37289384, "Zanco", "Damian", ESexo.Masculino, 18));
            //clientes.Add(new Cliente(47362983, "Juarez", "Sabrina", ESexo.Femenino, 20));
            //clientes.Add(new Cliente(35627839, "Nilo", "Helena", ESexo.Femenino, 31));
            //Archivo.EscribirLista(pasajeros);
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
        public static void AgregarUnPasajero(string apellido, string nombre, ESexo sexo, int edad, string dni)
        {

            pasajeros.Add(new Pasajero(nombre, apellido, Validador.CadenaStringAInt(dni), sexo, edad));
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

        public static void EliminarPasajero(Pasajero pasajero)
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

        public static void EliminarAvion(Avion avion)
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
                // El avión no se encuentra en ningún vuelo de la lista
                // Realiza las acciones necesarias
            }
            return estaEnVuelo;
           
        }
        public static void ModificarAvion(Avion avion)
        {
            






        }


        //public static bool EstaAvionEnViaje(string matricula)
        //{
        //    Avion auxAvion = BuscarAvionPorMatricula(matricula);
        //    if (auxAvion is not null)
        //    {
        //        foreach (Avion item in aviones)
        //        {
        //            if (item.Matricula == matricula)
        //            {
        //                auxAvion = item;
        //            }
        //        }

        //    }
        //    return auxAvion;

        //}

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

        //    public static List<Cliente> operator -(List<Cliente> lista, Cliente cliente)
        //    {
        //        //for (int i = 0; i < lista.Count; i++)
        //        //{
        //        //    if (lista[i] == cliente)
        //        //    {
        //        //        lista.RemoveAt(i);
        //        //        break;
        //        //    }

        //        //}
        //        foreach (Cliente item in clientes)
        //        {
        //            if (item == cliente)
        //            {
        //                lista.Remove(cliente);
        //                break;
        //            }
        //        }


        //        return lista;
        //    }
    }
}
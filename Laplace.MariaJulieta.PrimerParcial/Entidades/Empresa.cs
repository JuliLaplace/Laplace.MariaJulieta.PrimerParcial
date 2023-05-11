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
        private static List<Cliente> clientes;
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
            clientes = new List<Cliente>();
            destinoMasElegido = new Dictionary<string, int>();
            pasajerosFrecuentes = new Dictionary<Cliente, int>();
            destinosInternacionales = new string[5];
            destinosNacionales = new string[15];
            HarcodearUsuarios();
            HarcodearDestinosNacionales();
            HarcodearDestinosInternacionales();
            HarcodearClientes();
            HarcodearAviones();
            HarcodearVuelos();


        }

        
        private static void HarcodearUsuarios()
        {
            usuarios = JsonData.LeerUsuario();
        }

        private static void HarcodearAviones()
        {
            aviones.Add(new Avion(EAvion.Boeing, "B7772001", 100, 2, 100));
            aviones.Add(new Avion(EAvion.Boeing, "B7772002", 100, 2, 100)); 
            aviones.Add(new Avion(EAvion.Boeing, "B7772003", 100, 2, 100));
            aviones.Add(new Avion(EAvion.Airbus,"A5551001", 200, 4, 200));
            aviones.Add(new Avion(EAvion.Airbus,"A5551002", 200, 4, 200));
            aviones.Add(new Avion(EAvion.Airbus, "A5551003", 200, 4, 200));
            aviones.Add(new Avion(EAvion.Airbus, "A5551004", 200, 4, 200));

        }
        private static void HarcodearVuelos()
        {
            vuelos.Add(new Vuelo(destinosNacionales[3], destinosNacionales[0], ETipoViaje.Nacional, aviones[2], DateTime.Now, true, true));
            vuelos.Add(new Vuelo(destinosNacionales[2], destinosNacionales[6], ETipoViaje.Nacional, aviones[3], DateTime.Now, false, false));
            vuelos.Add(new Vuelo(destinosNacionales[5], destinosNacionales[1], ETipoViaje.Nacional, aviones[0], DateTime.Now, false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[1], destinosInternacionales[0], ETipoViaje.Internacional, aviones[5], DateTime.Now, false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[4], ETipoViaje.Internacional, aviones[6], DateTime.Today,true, true));
            vuelos.Add(new Vuelo(destinosNacionales[1], destinosNacionales[3], ETipoViaje.Nacional, aviones[4], new DateTime(2022, 10, 5, 12, 30, 0), false, false));
            vuelos.Add(new Vuelo(destinosInternacionales[2], destinosInternacionales[1], ETipoViaje.Internacional, aviones[0], new DateTime(2022, 10, 5, 12, 30, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[1], ETipoViaje.Internacional, aviones[1], new DateTime(2022, 10, 6, 10, 00, 0), true, false));
            vuelos.Add(new Vuelo(destinosInternacionales[4], destinosInternacionales[0], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 6, 10, 00, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[0], destinosInternacionales[2], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0), false, true));
            vuelos.Add(new Vuelo(destinosInternacionales[4], destinosInternacionales[1], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[2], destinosNacionales[0], ETipoViaje.Nacional, aviones[2], new DateTime(2022, 10, 8, 22, 15, 0), false, true));
            vuelos.Add(new Vuelo(destinosNacionales[3], destinosNacionales[5], ETipoViaje.Nacional, aviones[2], new DateTime(2022, 10, 8, 22, 15, 0), true, true));
            vuelos.Add(new Vuelo(destinosInternacionales[3], destinosInternacionales[0], ETipoViaje.Internacional, aviones[4], new DateTime(2022, 10, 9, 17, 30, 0), true, false));
            vuelos.Add(new Vuelo(destinosNacionales[0], destinosNacionales[3], ETipoViaje.Nacional, aviones[1], new DateTime(2022, 10, 9, 17, 30, 0), true, true));

        }
        private static void HarcodearClientes()
        {
            clientes.Add(new Cliente("Andrea", "Papana", 35454676, ESexo.Femenino, 34));
            clientes.Add(new Cliente("Martin", "Lorez", 20343562, ESexo.Masculino, 24));
            clientes.Add(new Cliente(  "Juan", "Zeia", 25674273, ESexo.NoBinario, 50));
            //clientes.Add(new Cliente(37289384, "Perez", "Federico", ESexo.Masculino, 34));
            //clientes.Add(new Cliente(47362983, "Manzo", "Ludmila", ESexo.Femenino, 24));
            //clientes.Add(new Cliente(35627839, "Firma", "Tristan", ESexo.Masculino, 61));
            //clientes.Add(new Cliente(35454676, "Lopez", "Maria", ESexo.Femenino, 19));
            //clientes.Add(new Cliente(20343562, "Martinez", "Florencia", ESexo.Femenino, 33));
            //clientes.Add(new Cliente(25674273, "Remallo", "Veronica", ESexo.NoBinario, 54));
            //clientes.Add(new Cliente(37289384, "Zanco", "Damian", ESexo.Masculino, 18));
            //clientes.Add(new Cliente(47362983, "Juarez", "Sabrina", ESexo.Femenino, 20));
            //clientes.Add(new Cliente(35627839, "Nilo", "Helena", ESexo.Femenino, 31));
        }
        private static void HarcodearDestinosInternacionales() 
        {
            destinosNacionales = new string[] { "Santa Rosa", "Bariloche", "Corrientes", "Córdoba", "Jujuy", "Mendoza", "Neuquén", "Posadas", "Iguazú", "Salta", "Santiago del Estero", "Trelew", "Tucumán", "Puerto Madryn", "Ushuaia" };

        }
        private static void HarcodearDestinosNacionales()
        {
            destinosInternacionales = new string[] { "Buenos Aires (Argentina)", "Recife (Brasil)", "Roma (Italia)", "Acapulco (México)", "Miami (EE.UU.)" };

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
        public static List<Cliente> ListarClientes()
        {
            List<Cliente> mostrarClientes = new List<Cliente>();
            foreach(Cliente item in clientes)
            {
                mostrarClientes.Add(item);
            }
            return mostrarClientes;
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
        public static void AgregarUnCliente(string apellido, string nombre, ESexo sexo, int edad, string dni)
        {

            clientes.Add(new Cliente(nombre,apellido, Validador.CadenaStringAInt(dni), sexo, edad));

        }

        public static void AgregarVuelo(string origen, string destino, ETipoViaje tipoDeViaje, Avion avion, DateTime diaDeViaje, bool ofreceComida, bool ofreceWifi)
        {
            vuelos.Add(new Vuelo(origen, destino, tipoDeViaje, avion, diaDeViaje, ofreceComida, ofreceWifi));
        }
        public static void AgregarAvion(EAvion avion, string matricula, int cantidadAsientos, int cantidadBanios, float capacidadBodega)
        {
          
                aviones.Add(new Avion(avion, matricula, cantidadAsientos, cantidadBanios, capacidadBodega));
            
        }

        public static string[] ListarDestinosNacionales()
        {
            return Empresa.destinosNacionales;
        }
        public static string[] ListarDestinosInternacionales()
        {
            return Empresa.destinosInternacionales;
        }

        //public static bool EstaAvionEnViaje(string matricula)
        //{
        //    Avion auxAvion = BuscarAvionPorMatricula(matricula);
        //    if(auxAvion is not null)
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

        //public static List<Cliente> operator -(List<Cliente> lista, Cliente cliente)
        //{
        //    //for (int i = 0; i < lista.Count; i++)
        //    //{
        //    //    if (lista[i] == cliente)
        //    //    {
        //    //        lista.RemoveAt(i);
        //    //        break;
        //    //    }

        //    //}
        //        foreach (Cliente item in clientes)
        //        {
        //            if(item == cliente)
        //            {
        //                lista.Remove(cliente); 
        //                break;
        //            }
        //        }


        //    return lista;
        //}
    }
}
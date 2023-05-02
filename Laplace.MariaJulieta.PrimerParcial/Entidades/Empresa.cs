using System.Text.Json;
using System;
using System.IO;



namespace Entidades
{
    public static class Empresa
    {
        private static List<Usuario> usuarios; // ponerlos en array?
        private static Avion[] aviones;
        private static List<Vuelo> vuelos;
        private static Dictionary<string, int> destinoMasElegido;
        private static Dictionary<int, int> pasajerosFrecuentes;
        private static double gananciaTotalCabojate;
        private static double gananciaTotalInternacional;
        
        //private static string json;



        static Empresa()
        {
            usuarios = new List<Usuario>();
            aviones = new Avion[7];
            vuelos = new List<Vuelo>();
            destinoMasElegido = new Dictionary<string, int>();
            pasajerosFrecuentes = new Dictionary<int, int>();
            HarcodearUsuarios();
            HarcodearAviones();
            HarcodearVuelos();
           
        }

        
        private static void HarcodearUsuarios() // sacar despues de .json cuando pueda deserializar, se harcodea asi para rpobar login
        {
            usuarios.Add(new Usuario("Corey", "Gorgen", "cgorgen@vendedor.com.com", "123abc45", 12341, "vendedor" ));
            usuarios.Add(new Usuario("Ingrid", "Harroll", "iharroll@vendedor.com.com", "qweasdzx", 12341, "vendedor"));
            usuarios.Add(new Usuario("Steve", "Harris", "sharris@maiden.com.uk", "eddie666", 12341, "vendedor"));
            usuarios.Add(new Usuario("Tilda", "Robinson", "trobinson@super.com", "12345678", 12341, "supervisor"));
            usuarios.Add(new Usuario("Michael", "Jordan", "admin@admin.com", "12345678", 12341, "administrador"));

        }
        private static void HarcodearAviones()
        {
            aviones[0] = new Avion("B7772001", 100, 2, 100, true, true);
            aviones[1] = new Avion("B7772002", 100, 2, 100, true,false); 
            aviones[2] = new Avion("B7772003", 100, 2, 100, false, true);
            aviones[3] = new Avion("A5551001", 200, 4, 200, false, true);
            aviones[4] = new Avion("A5551002", 200, 4, 200, true, true);
            aviones[5] = new Avion("A5551003", 200, 4, 200, false, true);
            aviones[6] = new Avion("A5551004", 200, 4, 200, true, false);

        }
        private static void HarcodearVuelos()
        {
            vuelos.Add(new Vuelo("Ushuaia", "Jujuy", true, aviones[2], DateTime.Now));
            vuelos.Add(new Vuelo("Puerto Mardyn", "Tucuman", true, aviones[3], DateTime.Now));
            vuelos.Add(new Vuelo("Tucuman", "Corrientes", true, aviones[4], DateTime.Now));
            vuelos.Add(new Vuelo("Salta", "Corrientes", true, aviones[5], DateTime.Now));
            vuelos.Add(new Vuelo("Salta", "Corrientes", true, aviones[6], DateTime.Today));
            vuelos.Add(new Vuelo("Puerto Mardyn", "Santa Rosa", true, aviones[4], new DateTime(2022, 10, 5, 12, 30, 0)));
            vuelos.Add(new Vuelo("Iguazu", "Trelew", true, aviones[4], new DateTime(2022, 10, 5, 12, 30, 0)));
            vuelos.Add(new Vuelo("Posadas", "Cordoba", true, aviones[4], new DateTime(2022, 10, 6, 10, 00, 0)));
            vuelos.Add(new Vuelo("Puerto Mardyn", "Mendoza", true, aviones[4], new DateTime(2022, 10, 6, 10, 00, 0)));
            vuelos.Add(new Vuelo("Cordoba", "Tucuman", true, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0)));
            vuelos.Add(new Vuelo("Puerto Mardyn", "Posadas", true, aviones[4], new DateTime(2022, 10, 7, 15, 30, 0)));
            vuelos.Add(new Vuelo("Mendoza", "Iguazu", true, aviones[4], new DateTime(2022, 10, 8, 22, 15, 0)));
            vuelos.Add(new Vuelo("Tucuman", "Santa Rosa", true, aviones[4], new DateTime(2022, 10, 8, 22, 15, 0)));
            vuelos.Add(new Vuelo("Cordoba", "Mendoza", true, aviones[4], new DateTime(2022, 10, 9, 17, 30, 0)));
            vuelos.Add(new Vuelo("Iguazu", "Santa Rosa", true, aviones[4], new DateTime(2022, 10, 9, 17, 30, 0)));

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
    }
}
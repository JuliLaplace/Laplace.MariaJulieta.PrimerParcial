# Fly Airlines App
## _Aplicación de gestión de venta de pasajes_

### Sobre mi:

Mi nombre es Julieta Laplace, tengo 32 años y soy trabajadora social. Me inicié en el camino de la programacion en 2019 con cursos dictados por la ciudad de Buenos Aires (codo a codo) por simple curiosidad, y termine encontrando un "mundo nuevo" el cual disfrutaba de estudiar y aprender. Desde ahí decidi ampliar mi conocimiento a un grado educativo mayor como lo es la UTN. Antes de esto jamás habia programado, ya que vengo de estudiar una carrera correspodiente a la ciencias sociales, lo cual implica "dejar de lado" materias que contengan lógica,álgebra, matemática; en secundario o en mi vida en general no tuve aproximación a la programación, por ello a mis 32 años recien estoy adentrandome en el mundo IT.

#### Resumen
![Imagen de login](Laplace.MariaJulieta.PrimerParcial/Imagenes/FuncionamientoApp/Login.jpg)

La aplicación inicia con un login en donde el usuario (puede ser vendedor, administrador o supervisor) se loguean con su correo y contraseña para acceder a la aplicación en si. Si la persona que desea loguearse coloca datos incorrectos, se mostrará un mensaje de error para dar aviso a quien utilice la aplicación. Si los datos son correctos, se abrirá el menú principal, y la ventana de login no será visible.
DATO: La pantalla de login contiene un botón de autocompletar, donde se autollenarán los campos Usuario y Contraseña con los datos correspondientes al supervisor.
![Imagen Menu principal](Laplace.MariaJulieta.PrimerParcial/Imagenes/FuncionamientoApp/Menu_Principal.jpg)
Una vez dentro del menú principal, se encuentra una barra con ciertas opciones: inicio, vuelos, venta de pasajes, pasajeros, aviones y estadisticas historicas. Si se clickea en la opcion "Vuelos", se verá un panel con los botones Agregar - Modificar - Eliminar, acompañado de un datagrid el cual listará los vuelos realizados en la empresa:
![Imagen de Opcion Vuelos](Laplace.MariaJulieta.PrimerParcial/Imagenes/FuncionamientoApp/Menu_vuelos.jpg)
La opcion de Agregar, eliminar y modificar viajes es exclusiva del usuario administrador, es decir, estas opciones solo aparecerán disponibles para quien se loguee con el perfil de "administrador", los demas usuarios tendran bloqueada dicha accion.
COMPLETAR CON AGREGAR - MODIFICAR - ELIMINAR

![Imagen de Opcion Pasajeros](Laplace.MariaJulieta.PrimerParcial/Imagenes/FuncionamientoApp/Menu_Pasajeros.jpg)
 
La seleccion "Venta de Pasajes" abre un nuevo formulario:
IMAGENFORMULARIOVENTAPASAJES
En el mismo se encontrarán cinco (5) opciones para realizar la venta de pasajes: Cargar Vuelo, Seleccionar tipo de pasaje, Cargar Pasajero, Cargar Equipaje y Generar Factura.
Al seleccionar el boton Cargar vuelo, se abrirá un formulario el cual permitirá filtrar vuelos segun su origen-destino y con la posibilidad del usuario de seleccionar la fecha de partida. A partir de dichas selecciones, se vera un datagrid con todos los vuelos filtrados por busqueda.
El boton "Limpiar", vuelve a mostrar en el datagrid todos los vuelos disponibles.
No es neecsario filtrar un vuelo para poder seleccionarlo desde la lista del datagrid. Con hacer doble click en el vuelo que se requiera, y clickear sobre el boton "Cargar vuelo", se cerrará el formulario y se volverá a ver el formulario de venta de pasaje con la información del vuelo seleccionado.
Si no se selecciona un vuelo y se clickea en el boton "Cargar vuelo", se mostrará un messagebox con el texto "Vuelo no seleccionado", y no se verá información alguna en los datos del vuelo, dentro del formulario de venta de pasajes
(COMPLETAR)

Otras de las opciones del menú principal es la referida a Pasajeros:
IMAGENMENUPASAJEROS
Al igual que en la opción "Vuelos", pasajeros tambien tiene un panel de botones: Agrear, modificar y eliminar. 
Si se selecciona agregar un cliente,  se abrirá un formulario el cual pedirá todos los datos relacionados al cliente. Este formulario no permite su cierre al menos que se cargue (correctamente) un cliente o se decida cancelar la carga del mismo. Esta opcion esta disponible para los perfiles "vendedor" y "supervisor", quedando bloqueado su uso para el perfil "administrador"


Se puede salir del menú principal, pero al realizar dicha accion, aparecera un messagebox verificando si el usuario desea salir de la aplicación:
 ![Imagen Opcion Salir](Laplace.MariaJulieta.PrimerParcial/Imagenes/FuncionamientoApp/Menu_salir.jpg)
Si el usuario elige la opción "Si", se cerrará el formulario Menu Principal, y se volverá al formulario de Login, para volver a ingresar con cualquier perfil. Si se clickea "No", el messagebox se cerrará y la aplicación seguirá funcionando.


##### Diagrama
COMPLETAR

#### Justificación técnica
1. Introduccion a .Net y c#
2. Clases y objetos estáticos
3. Programación orientada a objetos
4. Sobrecarga
5. Windows forms
6. Colecciones
7. Encapsulamiento
8. Herencia
9. Poliformismo

Estos son los temas tratados en la evaluación presentada. 
1)
Se utiliza el lenguaje C#, y se utiliza la plataforma .Net, el cual cito:
> "(...)provee una serie de herramientas y programas para construir fácilmente una gran variedad de software, así como el entorno necesario para ejecutarlo sobre distintos sistemas operativos y tipos de arquitectura".
 
Con dicha plataforma, utilizando el lenguanje C#, se creó este proyecto. .Net nos permite crear software en variedad, dando diversas herramientas (desde librerias propias con funcionalidades preexistentes, compliadores, e inclusive el IntelliSense que el programa posee) al programador para poder conllevar su cometido.
Dentro del proyecto se pueden encontrar fragmentos de código donde se utilizan elementos básicos tales como sentencias de iteración (sentencia for, foreach), operadores lógicos condicionales (if, if else), declaración de variables: Value types (tales como int, float) o Reference Types (Objetos, string). 
Algunos ejemplos dentro del codigo del uso de los mismos son:
`public class Vuelo
    {

        private string origen;
        private string destino;
        private bool esVueloNacional;
        private Avion unAvion;
        private DateTime diaDePartida;
        private List<Pasajero> pasajeros;
        private int horasDeViaje;
	public Vuelo(string origen, string destino, bool esVueloNacional, Avion unAvion, DateTime diaDePartida)
        {
            this.origen = origen;
            this.destino = destino;
            this.esVueloNacional = esVueloNacional;
            this.unAvion = unAvion;
            pasajeros = new List<Pasajero>();
            this.diaDePartida = diaDePartida;
            
            Random random = new Random();
            if (esVueloNacional)
            {
                horasDeViaje = random.Next(2, 4);
            }
            else
            {
                horasDeViaje = random.Next(8, 12);
            }
        }
        

    }
`
En este ejemplo se ve el uso de una clase publica especifica llamada Vuelo la cual busca modelar/crear un objeto de tipo vuelo. Este vuelo tendrá ciertas caracteristicas tales una lista de pasajeros, su lugar de salida y de destino, etc. En esta línea de código, se visualiza la declaración de variables de tipo int para definir la duracion del vuelo; una variable booleana esVueloNacional, la cual indicará si el vuelo efectivamente es Nacional o de caracter internacional, etc.
También podemos ver la utilización de un condicional (un if) para asignar las horas de viaje dependiendo si el vuelo es nacional o no.
2)
Dentro del temario, se encuentra el concepto de Clases, el cual se ejemplifico arriba, pero también se aborda el concepto de clases estáticas. 
En este proyecto se crean diferentes clases con el modificador llamado static, el cual nos provee la capacidad de declarar clases que no seran instanciadas, es decir, no serán creadoras de "objetos a moldear". Estas clases no buscan moldear objetos de la vida cotidiana, si no que buscan facilitar al programador el uso de diversos métodos (funciones que pueden realizarse) dentro del proyecto sin la necesidad de instanciar un objeto para su uso.
Un ejemplo de ello es:
`public static class Empresa
    {
        private static List<Usuario> usuarios; // ponerlos en array?
        private static Avion[] aviones;
        private static List<Vuelo> vuelos;
        private static List<Cliente> clientes;
        private static Dictionary<string, int> destinoMasElegido;
        private static Dictionary<int, int> pasajerosFrecuentes;
        private static double gananciaTotalCabojate;
        private static double gananciaTotalInternacional;
        
        COMPLETAR



        static Empresa()
        {
            usuarios = new List<Usuario>();
            aviones = new Avion[7];
            vuelos = new List<Vuelo>();
            clientes = new List<Cliente>();
            destinoMasElegido = new Dictionary<string, int>();
            pasajerosFrecuentes = new Dictionary<int, int>();
            HarcodearUsuarios();
            HarcodearAviones();
            HarcodearVuelos();
           
        }
    }
`
La clase estatica Empresa, no busca instanciar objetos de tipo empresa, si no que busca ser la base del programa a ejecutar. Dentro de esta clase se almacenan diversos datos para el funcionamiento de la app (listas de aviones pertenecientes a la empresa, los usuarios que trabajan y utilizan la aplicación, entre otros), contiene funciones especificas que se ejecutan dentro del programa (funciones que validan el ingreso de un usuario, funciones que muestras una lista de Aviones, etc).

En este trabajo, se aplica el paradigma de la programación orientada a objetos, ya que creo que todos los elementos propios de una empresa, la cual se encarga de vender tickets de vuelo a diversas personas (entre otras cosas), púede ser modelada (crear objetos con sus atributos, caracteristicas etc) para ser representada en código C#.
El ejemplo claro de ello es pensar a los pasajeros, vuelos, pasaje, aviones como objetos que podemos modelar, que tienen sus caracteristicas particulares (atributos), sus funciones (métodos) y demás.
COMPLETAR

4)
COMPLETAR CON CODIGO DE SOBRECARGA.
La sobrecarga se entiende como:
>"Permite declarar miembros con el mismo nombre en la misma clase, siempre y cuando tengan distintos conjuntos de parámetros.
(...)La sobrecarga consiste en crear dos o más miembros (métodos, constructores o indexadores) con el mismo identificador (mismo nombre), dentro de la misma clase, cambiando el número de parámetros, tipo de parámetros u orden de los tipos."

La sobrecarga de métodos, nos ayudará en la reutilización y simplificación de código, para no generar "Código repetido".
3)
Para entender la Programación orientada a objetos, citamos:
>Un paradigma de programación define la forma, metodología o estilo con el que se resolverá un problema utilizando un lenguaje de programación.
(...)La programación orientada a objetos (Object Oriented Programming - OOP) es un paradigma de programación que propone resolver problemas a través de identificar objetos de la vida real, sus atributos (datos), su comportamiento (acciones) y las relaciones de colaboración entre ellos.



5)
Para generar una interacción con el usuario que utilizara la aplicación, el cual no solo contendrá la logica del programa, si no también el diseño del mismo, se utilizan los formularios de Windows Forms.

>Windows Forms es una tecnología que permite crear aplicaciones gráficas para escritorio en Windows. Ofrece capacidades para definir visualmente todo tipo de ventanas y controles dentro de éstas, y además facilita la creación de interfaces orientadas al manejo de datos gracias a sus capacidades de enlace bi-direccional a datos (capa lógica - capa visual).

A partir de diversos formularios creados, se genera la parte logica-visual de la aplicación en si, para poder generar esta interacción con el usuario.
COMPLETAR

COLECCIONES


ENCAPSULAMIENTO
HERENCIA
COMPLETAR.
En este trabajo, se utilizó la herencia especificamente en la relacion entre la clase Persona con sus clases derivadas Usuario y Cliente.
POLIMORFISMO (COMPLETAR)


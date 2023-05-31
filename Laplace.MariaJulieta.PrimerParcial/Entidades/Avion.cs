using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        private EAvion nombre;
        private string matricula;
        private int cantidadDeAsientos;
        private int cantidadDeBanios;
        private float capacidadBodega;

        public Avion()
        {
            this.matricula = string.Empty;
        }
        public Avion(EAvion nombre, string matricula, int cantidadDeAsientos, int cantidadDeBaños, float capacidadBodega):this() 
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBanios = cantidadDeBaños;
            this.capacidadBodega = capacidadBodega;
            
 
        }
        public EAvion     Nombre
        {
            get { return this.nombre; } 
            set { this.nombre = value; }
        }
        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }
        public int CantidadDeAsientos
        {
            get { return this.cantidadDeAsientos; }
            set
            {
                this.cantidadDeAsientos = value;
            }
        }

        public int CantidadDeBanios
        {
            get { return this.cantidadDeBanios; }
            set
            {
                this.cantidadDeBanios = value;
            }
        }

        public float CapacidadBodega
        {
            get { return this.capacidadBodega; }
            set
            {
                this.capacidadBodega = value;
            }
        }
       
        public int CantidadAsientosPremium()
        {
            return (int)Math.Floor(cantidadDeAsientos * 0.2);
        }

        public int CantidadAsientosTurista()
        {
            return cantidadDeAsientos - CantidadAsientosPremium();
        }
        public string MostrarAvion()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"{this.Nombre} - {this.Matricula}");
            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarAvion();
        }

        public static bool operator ==(Avion avion1, Avion avion2)
        {
            return (avion1.Matricula == avion2.Matricula);
          

        }
        public static bool operator !=(Avion avion1, Avion avion2)
        {
            return !(avion1 == avion2);


        }

        public override bool Equals(object? obj)
        {

            bool retorno = false;
            if(obj is Avion)
            {
                retorno = this ==((Avion)obj);
            }
            return retorno;
        }

    }
}

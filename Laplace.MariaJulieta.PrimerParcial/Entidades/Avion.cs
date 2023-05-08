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
            get { return nombre; } 
        }
        public string Matricula
        {
            get { return matricula; }
        }
        public int CantidadDeAsientos
        {
            get { return cantidadDeAsientos; }
        }

        public int CantidadDeBanios
        {
            get { return cantidadDeBanios; }
        }

        public float CapacidadBodega
        {
            get { return capacidadBodega; }
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
            //cadena.AppendLine($"Matricula: {this.Matricula}");
            //cadena.AppendLine($"Cantidad de asientos: {this.CantidadDeAsientos}");
            //cadena.AppendLine($"Cantidad de asientos premium: {this.CantidadAsientosPremium()}");
            //cadena.AppendLine($"Cantidad de asientos: {this.CantidadAsientosTurista()}");
            //cadena.AppendLine($"Cantidad de baños: {this.CantidadDeBanios}");
            //cadena.AppendLine($"Capacidad en bodega: {this.CapacidadBodega}");
            return cadena.ToString();
        }

        public override string ToString() //sobreescribi el tostring asi cuando listo los vuelos, en el marco de Avion, se muestra sun nombre y matricula
        {
            return this.MostrarAvion();
        }
    }
}

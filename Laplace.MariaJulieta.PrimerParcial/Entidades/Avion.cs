using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        private string matricula;
        private int cantidadDeAsientos;
        private int cantidadDeBanios;
        private float capacidadBodega;
        private bool tieneWifi;
        private bool ofreceComida;
        

        public Avion(string matricula, int cantidadDeAsientos, int cantidadDeBaños, float capacidadBodega, bool tieneWifi, bool ofreceComida)
        {
            this.matricula = matricula;
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBanios = cantidadDeBaños;
            this.capacidadBodega = capacidadBodega;
            this.tieneWifi = tieneWifi;
            this.ofreceComida = ofreceComida;
           
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
        public bool TieneWifi
        {
            get { return tieneWifi; }
        }
        public bool OfreceComida
        {
            get { return this.ofreceComida; }
        }
      


      
        public int CantidadAsientosPremium()
        {
            return (int)Math.Floor(cantidadDeAsientos * 0.2);
        }

        public int CantidadAsientosTurista()
        {
            return cantidadDeAsientos - CantidadAsientosPremium();
        }
    }
}

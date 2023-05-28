using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        private int cantidadValijas;
        private float pesoTotalValija;
        public Equipaje()
        {
            this.pesoTotalValija = 0;
            this.cantidadValijas = 0;
        }
        public Equipaje(int cantidadValijas, float pesoTotalValija)
        {
            this.cantidadValijas = cantidadValijas;
            this.pesoTotalValija = pesoTotalValija;
        }

        public int CantidadValijas
        {
            get { return this.cantidadValijas; }
            set { this.cantidadValijas = value;}
        }


        public float PesoTotalValija
        {
            get { return this.pesoTotalValija; }
            set { this.pesoTotalValija= value; }
        }

        public override string ToString()
        {
            return $"Cantidad de valijas: {this.CantidadValijas} - Peso total: {this.PesoTotalValija}";
        }

    }
}


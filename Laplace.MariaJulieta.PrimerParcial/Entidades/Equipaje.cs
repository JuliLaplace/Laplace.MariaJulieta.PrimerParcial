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

        public Equipaje(int cantidadValijas, float pesoTotalValija)
        {
            this.cantidadValijas = cantidadValijas;
            this.pesoTotalValija = pesoTotalValija;
        }

        public int CantidadValijas
        {
            get { return cantidadValijas; }
        }


        public float PesoTotalValija
        {
            get { return pesoTotalValija; }
        }
    }
}


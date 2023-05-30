using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Viaje
    {
        private Pasaje pasaje;
        private Equipaje equipaje;
        private bool llevaEquipajeDeMano;
        public Viaje() { }
        public Viaje(Pasaje pasaje, Equipaje equipaje, bool llevaEquipajeDeMano)
        {
            this.pasaje = pasaje;
            this.equipaje = equipaje;
            this.llevaEquipajeDeMano = llevaEquipajeDeMano;
        }
        public Pasaje Pasaje { get {return this.pasaje; } 
        }
        public Equipaje Equipaje { get { return this.equipaje; } }

        public bool LlevaEquipajeDeMano { get { return this.llevaEquipajeDeMano; } }

        public override string ToString()
        {
            // mostrar viajes 
            return $"Codigo pasaje: {this.pasaje.CodigoPasaje} - Valijas que lleva: {this.equipaje.CantidadValijas}";
        }
    }
}

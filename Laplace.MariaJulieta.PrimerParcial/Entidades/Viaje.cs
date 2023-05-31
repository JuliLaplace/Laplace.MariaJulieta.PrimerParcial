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
        public Pasaje Pasaje { get {return this.pasaje;}
            set
            {
                this.pasaje = value;
            }
        }
        public Equipaje Equipaje { get { return this.equipaje; } set { this.equipaje = value; } }

        public bool LlevaEquipajeDeMano { get { return this.llevaEquipajeDeMano; } set { this.llevaEquipajeDeMano = value; } }

        public string EquipajeMano()
        {
            string cadenaEquipajeMano = "No lleva equipaje de mano";
            if (llevaEquipajeDeMano)
            {
                cadenaEquipajeMano = "Lleva equipaje de mano";
            }
            return cadenaEquipajeMano;
        }
        public override string ToString()
        {
        
            return $"Codigo pasaje: {this.pasaje.CodigoPasaje} - Valijas que lleva: {this.equipaje.CantidadValijas} -  {EquipajeMano()} ";
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCargarEquipaje : Form
    {
        Equipaje equipajeCargado;
        public Equipaje EquipajeCargado
        {
            get { return equipajeCargado; }
        }
        public FrmCargarEquipaje()
        {
            InitializeComponent();
            equipajeCargado = new Equipaje();
        }
    }
}

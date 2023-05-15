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
    public partial class FrmModificarAvion : FrmAgregarAvion
    {
        Avion avionRecibido;
        public FrmModificarAvion(Avion avion) : base()
        {
            InitializeComponent();
            this.avionRecibido = avion;
            base.btnBoton1.Text = "Modificar";
        }

        private void btnBoton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

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
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmModificarAvion_Load(object sender, EventArgs e)
        {
           
            //this.cboAviones.SelectedIndex = 0;
            //base.domUpDownAsientos.Items.Add(avionRecibido.CantidadDeAsientos);
            //base.domUpDownCantidadBanios.Items.Add(avionRecibido.CantidadDeBanios);
            //base.domUpDownCapacidadMaxima.Items.Add(avionRecibido.CapacidadBodega);

            base.domUpDownCapacidadMaxima.SelectedItem = avionRecibido.CapacidadBodega;
            base.domUpDownCantidadBanios.SelectedItem = avionRecibido.CantidadDeBanios;
            base.domUpDownAsientos.SelectedItem = avionRecibido.CantidadDeAsientos;

        }
    }
}

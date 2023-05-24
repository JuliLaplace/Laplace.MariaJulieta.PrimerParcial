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
    public partial class FrmEliminarAvion : FrmAgregarAvion
    {
        Avion avionRecibido;
        public FrmEliminarAvion(Avion avion) : base()
        {
            InitializeComponent();
            this.avionRecibido = avion;
        }

        private void FrmEliminarAvion_Load(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Eliminar";
            base.cboAviones.Enabled = false;
            base.cboAviones.SelectedItem = avionRecibido.Nombre;
            base.domUpDownAsientos.Enabled = false;
            base.domUpDownAsientos.SelectedItem = avionRecibido.CantidadDeAsientos;
            base.domUpDownCantidadBanios.Enabled = false;
            base.domUpDownCantidadBanios.SelectedItem = avionRecibido.CantidadDeBanios;
            base.domUpDownCapacidadMaxima.Enabled = false;
            base.domUpDownCapacidadMaxima.SelectedItem = avionRecibido.CapacidadBodega;
            base.txtMatriculaAvion.Enabled = false;
            base.txtMatriculaAvion.Text = avionRecibido.Matricula;
        }
        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected override void btnBoton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Avion eliminado con exito");
        }
    }
}

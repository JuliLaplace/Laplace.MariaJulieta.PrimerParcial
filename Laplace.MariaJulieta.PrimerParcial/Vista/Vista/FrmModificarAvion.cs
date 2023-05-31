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
        }
        private void FrmModificarAvion_Load(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Modificar";
            base.txtMatriculaAvion.Text = avionRecibido.Matricula;
            base.txtMatriculaAvion.Enabled = false;
            base.cboAviones.SelectedItem = avionRecibido.Nombre;
            base.domUpDownCapacidadMaxima.SelectedItem = avionRecibido.CapacidadBodega;
            base.domUpDownCantidadBanios.SelectedItem = avionRecibido.CantidadDeBanios;
            base.domUpDownAsientos.SelectedItem = avionRecibido.CantidadDeAsientos;
            base.txtMatriculaAvion.Text = avionRecibido.Matricula;

        }

        protected override void btnBoton1_Click(object sender, EventArgs e)
        {

            Empresa.Modificar(avionRecibido, (EAvion)this.cboAviones.SelectedValue, Convert.ToInt32(this.domUpDownAsientos.SelectedItem), Convert.ToInt32(this.domUpDownCantidadBanios.SelectedItem), Convert.ToSingle(this.domUpDownCapacidadMaxima.SelectedItem));
            MessageBox.Show("Avion modificado con exito");
            this.DialogResult = DialogResult.OK;

        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        public bool VerificarAvionEnVuelo(Avion avion, List<Vuelo> lista)
        {
            return true;
        }
    }
}

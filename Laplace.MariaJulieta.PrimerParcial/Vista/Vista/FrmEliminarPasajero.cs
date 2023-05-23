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
    public partial class FrmEliminarPasajero : FrmPasajero
    {
        Pasajero pasajeroRecibido;
        public FrmEliminarPasajero(Pasajero pasajeroRecibido) : base()
        {
            InitializeComponent();
            this.pasajeroRecibido = pasajeroRecibido;
        }


        private void FrmEliminarPasajero_Load(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Eliminar";
            base.txtDniPasajero.Enabled = false;
            base.txtDniPasajero.Text = pasajeroRecibido.Dni.ToString();
            base.txtNombrePasajero.Enabled = false;
            base.txtNombrePasajero.Text = pasajeroRecibido.Nombre;
            base.txtApellidoPasajero.Enabled = false;
            base.txtApellidoPasajero.Text = pasajeroRecibido.Apellido;
            base.cmbGenero.Enabled = false;
            base.cmbGenero.SelectedItem = pasajeroRecibido.Sexo;
            base.dtpickerFechaNacimiento.Visible = false;
            base.dtpickerFechaNacimiento.Enabled = false;
        }

 
        protected override void btnBoton1_Click(object sender, EventArgs e)
        {
            this.LimpiarPantalla();

            //Empresa.EliminarCliente(clienteRecibido);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Cliente eliminado con exito");


        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.LimpiarPantalla();
            base.DialogResult = DialogResult.Cancel;
        }
        //protected override void LimpiarPantalla()
        //{
        //    this.txtApellidoPasajero.Text = string.Empty;
        //    this.txtDniPasajero.Text = string.Empty;
        //    this.txtNombrePasajero.Text = string.Empty;
        //    this.cmbGenero.Text = string.Empty;

        //}
    }
}

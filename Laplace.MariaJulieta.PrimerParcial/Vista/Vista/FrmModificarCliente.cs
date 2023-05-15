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
    public partial class FrmModificarCliente : FrmAgregarCliente
    {
        public Cliente clienteRecibido;

        public FrmModificarCliente(Cliente cliente):base()
        {
            InitializeComponent();
            base.btnBoton1.Text = "Modificar";
            this.clienteRecibido = cliente;
        }
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Modificar";
            base.dtpickerFechaNacimiento.Enabled = false;
            base.txtDniCliente.Text = clienteRecibido.Dni.ToString();
            base.txtDniCliente.Enabled = false;
            base.txtApellidoCliente.Text = clienteRecibido.Apellido;
            base.txtNombreCliente.Text = clienteRecibido.Nombre;
            base.cmbGenero.SelectedItem = clienteRecibido.Sexo;
        }

        protected override void btnBoton1_Click(object sender, EventArgs e)
        {   
            ESexo sexo = (ESexo)base.cmbGenero.SelectedValue;

            Empresa.ModificarCliente(clienteRecibido, base.txtNombreCliente.Text, base.txtApellidoCliente.Text, sexo);
            this.DialogResult = DialogResult.OK;

        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarPantalla();
            base.DialogResult = DialogResult.Cancel;
        }
        protected override void LimpiarPantalla()
        {
            this.txtApellidoCliente.Text = string.Empty;
            this.txtDniCliente.Text = string.Empty;
            this.txtNombreCliente.Text = string.Empty;
            this.cmbGenero.Text = string.Empty;

        }

    }
}

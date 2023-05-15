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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmEliminarCliente : FrmAgregarCliente
    {
        private int dni;
        public Cliente clienteRecibido;

        public FrmEliminarCliente(Cliente cliente):base()
        {
            InitializeComponent();
            this.clienteRecibido = cliente;

        }
        private void FrmEliminarCliente_Load(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Eliminar";
            base.txtDniCliente.Enabled = false;
            base.txtApellidoCliente.Enabled = false;
            base.txtNombreCliente.Enabled = false;
            base.dtpickerFechaNacimiento.Visible = false;
            base.cmbGenero.Enabled = false;
            base.txtDniCliente.Text = clienteRecibido.Dni.ToString();
            base.txtApellidoCliente.Text = clienteRecibido.Apellido;
            base.txtNombreCliente.Text = clienteRecibido.Nombre;
            base.cmbGenero.SelectedItem = clienteRecibido.Sexo;
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

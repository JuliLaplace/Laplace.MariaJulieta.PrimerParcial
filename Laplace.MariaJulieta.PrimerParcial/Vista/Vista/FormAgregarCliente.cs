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
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
            this.lblError.Visible = false;


        }
        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(ESexo));
            cmbGenero.SelectedIndex = 0;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombreIngresado = this.txtNombreCliente.Text;
            string apellidoIngresado = this.txtApellidoCliente.Text;
            string edadIngresada = this.txtEdadCliente.Text;
            string dniIngresado = this.txtDniCliente.Text;
            ESexo sexoSeleccionado = (ESexo)cmbGenero.SelectedValue;

            if (ValidarDatosIngresados(nombreIngresado, apellidoIngresado, edadIngresada, dniIngresado))
            {
                Empresa.AgregarUnCliente(apellidoIngresado, nombreIngresado, sexoSeleccionado, edadIngresada, dniIngresado);
                MessageBox.Show("Cliente agregado con exito");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Visible = true;
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private static bool ValidarDatosIngresados(string nombre, string apellido, string edad, string dni)
        {
            return (Validador.ValidarSiCadenaEsSoloLetras(nombre) && Validador.ValidarSiCadenaEsSoloLetras(apellido) && Validador.StringEsNumerico(edad) && Validador.StringEsNumerico(dni));

        }

    }
}

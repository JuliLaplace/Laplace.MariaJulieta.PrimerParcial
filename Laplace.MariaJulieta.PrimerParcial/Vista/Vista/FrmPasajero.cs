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
    public partial class FrmPasajero : Form
    {


        public FrmPasajero()
        {
            InitializeComponent();

        }

        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            this.cmbGenero.DataSource = Enum.GetValues(typeof(ESexo));
            this.cmbGenero.SelectedIndex = 0;
            this.lblError.Visible = false;
            this.dtpickerFechaNacimiento.MaxDate = DateTime.Today;
            this.btnBoton1.Text = "Agregar";

        }

        private static bool ValidarDatosIngresados(string nombre, string apellido, int edad, string dni)
        {
            return (Validador.ValidarSiCadenaEsSoloLetras(nombre) && Validador.ValidarSiCadenaEsSoloLetras(apellido) && Validador.ValidarEdadCorrecta(edad) && Validador.StringEsNumerico(dni));
        }


        private void dtpickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = this.dtpickerFechaNacimiento.Value;
            int edad = (int)((DateTime.Now - fechaNacimiento).TotalDays / 365.25);
        }

        protected virtual void btnBoton1_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = this.dtpickerFechaNacimiento.Value;
            int edadIngresada = (int)((DateTime.Now - fechaNacimiento).TotalDays / 365);
            string nombreIngresado = this.txtNombrePasajero.Text;
            string apellidoIngresado = this.txtApellidoPasajero.Text;
            string dniIngresado = this.txtDniPasajero.Text;
            ESexo sexoSeleccionado = (ESexo)this.cmbGenero.SelectedValue;


            if (ValidarDatosIngresados(nombreIngresado, apellidoIngresado, edadIngresada, dniIngresado))
            {
                this.lblError.Visible = false;
                Empresa.AgregarUnPasajero(apellidoIngresado, nombreIngresado, sexoSeleccionado, fechaNacimiento, edadIngresada, dniIngresado);
                MessageBox.Show("Cliente agregado con exito");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.lblError.Visible = true;
                LimpiarPantalla();
            }
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected void LimpiarPantalla()
        {
            this.txtApellidoPasajero.Text = string.Empty;
            this.txtDniPasajero.Text = string.Empty;
            this.txtNombrePasajero.Text = string.Empty;
        }




    }
}

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
    public partial class FrmModificarPasajero : FrmPasajero
    {
        public Pasajero pasajeroRecibido;
        public FrmModificarPasajero(Pasajero pasajero) : base()
        {
            InitializeComponent();

            this.pasajeroRecibido = pasajero;
        }


        private void FrmModificarPasajero_Load_1(object sender, EventArgs e)
        {
            base.btnBoton1.Text = "Modificar";
            base.dtpickerFechaNacimiento.Enabled = false;
            base.dtpickerFechaNacimiento.Value = pasajeroRecibido.FechaNacimiento;
            base.txtDniPasajero.Text = pasajeroRecibido.Dni.ToString();
            base.txtDniPasajero.Enabled = false;
            base.txtApellidoPasajero.Text = pasajeroRecibido.Apellido;
            base.txtNombrePasajero.Text = pasajeroRecibido.Nombre;
            base.cmbGenero.SelectedItem = pasajeroRecibido.Sexo;


        }

        protected override void btnBoton1_Click(object sender, EventArgs e)
        {
            ESexo sexo = (ESexo)base.cmbGenero.SelectedValue;


            if (ValidarDatosIngresados(base.txtNombrePasajero.Text, base.txtApellidoPasajero.Text))
            {
                Empresa.Modificar(pasajeroRecibido, this.txtNombrePasajero.Text, this.txtApellidoPasajero.Text, sexo);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                base.lblError.Visible = true;
                this.LimpiarPantalla();
            }

        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.LimpiarPantalla();
            base.DialogResult = DialogResult.Cancel;
        }
        protected override void LimpiarPantalla()
        {
            this.txtApellidoPasajero.Text = string.Empty;
            this.txtNombrePasajero.Text = string.Empty;
        }
        public bool ValidarDatosIngresados(string nombre, string apellido)
        {
            return (Validador.ValidarSiCadenaEsSoloLetras(nombre) && Validador.ValidarSiCadenaEsSoloLetras(apellido) && (nombre != string.Empty) && (apellido != string.Empty));
        }
    }
}

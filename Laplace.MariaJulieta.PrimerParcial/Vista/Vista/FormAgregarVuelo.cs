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
    public partial class FormAgregarVuelo : Form
    {
        ETipoViaje tipoDeViaje;
        public FormAgregarVuelo()
        {
            InitializeComponent();
        }

        private void FormAgregarVuelo_Load(object sender, EventArgs e)
        {
            this.lblMensajeError.Visible = false;
            this.calendarSeleccionFechaDeViaje.MinDate = DateTime.Now;
            this.cboSeleccionTipoDeViaje.DataSource = Enum.GetValues(typeof(ETipoViaje));
            this.cboSeleccionAvion.DataSource = Empresa.ListarAviones();

            this.cboSeleccionTipoDeViaje.SelectedItem = 0;

            tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedItem;

            if (tipoDeViaje == ETipoViaje.Internacional)
            {


                this.cboSeleccionOrigen.Items.AddRange(Empresa.ListarDestinosInternacionales());
                this.cboSeleccionDestino.Items.AddRange(Empresa.ListarDestinosInternacionales());
            }
            else
            {

                this.cboSeleccionOrigen.Items.AddRange(Empresa.ListarDestinosNacionales());
                this.cboSeleccionDestino.Items.AddRange(Empresa.ListarDestinosNacionales());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

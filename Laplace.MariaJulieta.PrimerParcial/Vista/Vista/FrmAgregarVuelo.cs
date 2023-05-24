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
    public partial class FrmAgregarVuelo : Form
    {
        ETipoViaje tipoDeViaje;
        bool ofreceWifi;
        bool ofreceServicioComida;
        public FrmAgregarVuelo()
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
            tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;
            this.btnAgregarVuelo.Text = "Agregar";

        }


        private void cboSeleccionTipoDeViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ETipoViaje tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;

            if (tipoDeViaje == ETipoViaje.Internacional)
            {
                this.cboSeleccionOrigen.Items.Clear();
                this.cboSeleccionOrigen.Items.Add("Buenos Aires - Argentina");
                this.cboSeleccionOrigen.SelectedIndex = 0;
                this.cboSeleccionDestino.Items.Clear();
                this.cboSeleccionDestino.Items.AddRange(Empresa.ListarDestinosInternacionales());
                this.cboSeleccionDestino.SelectedIndex = 0;
            }
            else
            {
                this.cboSeleccionOrigen.Items.Clear();
                this.cboSeleccionOrigen.Items.AddRange(Empresa.ListarDestinosNacionales());
                this.cboSeleccionOrigen.SelectedIndex = 0;
                this.cboSeleccionDestino.Items.Clear();
                this.cboSeleccionDestino.Items.AddRange(Empresa.ListarDestinosNacionales());
                this.cboSeleccionDestino.SelectedIndex = 0;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {

            string origen = this.cboSeleccionOrigen.SelectedItem.ToString();
            string destino = this.cboSeleccionDestino.SelectedItem.ToString();
            Avion avionSeleccionado = (Avion)cboSeleccionAvion.SelectedItem;//VER
            string matriculaAvionSeleccionado = avionSeleccionado.Matricula;
            DateTime fecha = this.calendarSeleccionFechaDeViaje.SelectionStart;


            if (destino == origen)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = "El origen debe ser distinto del destino";
            }
            else
            {

                Empresa.AgregarVuelo(origen, destino, tipoDeViaje, avionSeleccionado, fecha, ofreceServicioComida, ofreceWifi); //COMPLETAR
                MessageBox.Show("Vuelo agregado con exito");
                this.DialogResult = DialogResult.OK;

            }


        }

        private void chkbOfreceComida_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkbOfreceComida.Checked)
            {
                this.ofreceServicioComida = true;
            }
            else
            {
                this.ofreceServicioComida = false;
            }
        }

        private void chkbOfreceWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkbOfreceWifi.Checked)
            {
                this.ofreceWifi = true;
            }
            else
            {
                this.ofreceWifi = false;
            }
        }
    }
}

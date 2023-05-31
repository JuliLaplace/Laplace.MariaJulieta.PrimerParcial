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
    public partial class FrmModificarVuelo : Form
    {
        Vuelo vueloRecibido;
        ETipoViaje tipoDeViaje;
        bool ofreceComida;
        bool ofreceWifi;
        public FrmModificarVuelo(Vuelo vuelo)
        {
            InitializeComponent();
            this.vueloRecibido = vuelo;
            this.ofreceComida = vuelo.OfreceComida;
            this.ofreceWifi = vuelo.TieneWifi;
        }

        private void FrmModificarVuelo_Load(object sender, EventArgs e)
        {
            this.lblMensajeError.Visible = false;
            this.calendarSeleccionFechaDeViaje.MinDate = DateTime.Today;
            this.cboSeleccionTipoDeViaje.DataSource = Enum.GetValues(typeof(ETipoViaje));
            this.cboSeleccionAvion.DataSource = Empresa.ListarAviones();
            this.cboSeleccionTipoDeViaje.SelectedItem = this.vueloRecibido.TipoDeViaje;
            this.cboSeleccionAvion.SelectedItem = this.vueloRecibido.UnAvion;
            this.tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;
            this.cboSeleccionOrigen.SelectedItem = this.vueloRecibido.Origen;
            this.cboSeleccionDestino.SelectedItem = this.vueloRecibido.Destino;
            this.calendarSeleccionFechaDeViaje.SetDate(vueloRecibido.DiaDePartida);
            this.chkbOfreceWifi.Checked = ofreceWifi;
            this.chkbOfreceComida.Checked = ofreceComida;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string origen = this.cboSeleccionOrigen.SelectedItem.ToString();
            string destino = this.cboSeleccionDestino.SelectedItem.ToString();
            Avion avionSeleccionado = (Avion)cboSeleccionAvion.SelectedItem;
            DateTime fecha = this.calendarSeleccionFechaDeViaje.SelectionStart;

            if (destino == origen)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = "El origen debe ser distinto del destino";
            }
            else if (Empresa.EstaAvionEnVuelo(avionSeleccionado, fecha))
            {
                MessageBox.Show($"El avion {avionSeleccionado} está en vuelo el día {fecha}. \nNo se puede modificar el vuelo.");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                Empresa.Modificar(vueloRecibido, origen, destino, tipoDeViaje, avionSeleccionado, fecha, ofreceComida, ofreceWifi);
                MessageBox.Show("Vuelo modificado con éxito");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chkbOfreceComida_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkbOfreceComida.Checked)
            {
                this.ofreceComida = true;
            }
            else
            {
                this.ofreceComida = false;
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

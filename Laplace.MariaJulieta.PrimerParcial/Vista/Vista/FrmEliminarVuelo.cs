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
    public partial class FrmEliminarVuelo : Form
    {
        Vuelo vueloRecibido;
        public FrmEliminarVuelo(Vuelo vuelo)
        {
            InitializeComponent();
            this.vueloRecibido = vuelo;
        }

        private void FrmEliminarVuelo_Load(object sender, EventArgs e)
        {
            this.cboSeleccionTipoDeViaje.Enabled = false;
            this.cboSeleccionTipoDeViaje.DisplayMember = "TipoDeViaje";
            this.cboSeleccionTipoDeViaje.Items.Add(vueloRecibido.TipoDeViaje);
            this.cboSeleccionTipoDeViaje.SelectedItem = vueloRecibido.TipoDeViaje;

            this.cboSeleccionOrigen.Enabled = false;
            this.cboSeleccionOrigen.Items.Add(vueloRecibido.Origen);
            this.cboSeleccionOrigen.SelectedItem = vueloRecibido.Origen;

            this.cboSeleccionDestino.Enabled = false;
            this.cboSeleccionDestino.Items.Add(vueloRecibido.Destino);
            this.cboSeleccionDestino.SelectedItem = vueloRecibido.Destino;

            this.cboSeleccionAvion.Enabled = false;
            this.cboSeleccionAvion.Items.Add(vueloRecibido.UnAvion);
            this.cboSeleccionAvion.SelectedItem = vueloRecibido.UnAvion;

            this.calendarSeleccionFechaDeViaje.Enabled = false;
            this.calendarSeleccionFechaDeViaje.SetDate(vueloRecibido.DiaDePartida);

            this.chkbOfreceComida.Enabled = false;
            this.chkbOfreceComida.Checked = vueloRecibido.OfreceComida;

            this.chkbOfreceWifi.Enabled = false;
            this.chkbOfreceWifi.Checked = vueloRecibido.TieneWifi;

        }

        private void btnEliminarVuelo_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;

            if (vueloRecibido.DiaDePartida.Date <= fechaActual)
            {
                MessageBox.Show("No se puede eliminar un vuelo en viaje o que vuela del mismo día");
            }
            else
            {
                MessageBox.Show("Vuelo eliminado con éxito");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

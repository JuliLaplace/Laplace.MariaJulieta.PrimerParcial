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
    public partial class FrmBusquedaVuelo : Form
    {
        ETipoViaje tipoDeViaje;
        bool ofreceWifi;
        bool ofreceComida;
        List<Vuelo> listaDeVuelosDisponibles;
        Vuelo vuelo;
        private bool filaSeleccionada; //

        public Vuelo Vuelo
        {
            get { return vuelo; }
            set { this.vuelo = value; }
        }
        public FrmBusquedaVuelo()
        {
            InitializeComponent();
            this.filaSeleccionada = false;
            this.vuelo = new Vuelo();
            this.calendarSeleccionFechaDeViaje.MinDate = DateTime.Now;
            this.cboSeleccionTipoDeViaje.DataSource = Enum.GetValues(typeof(ETipoViaje));
            this.cboSeleccionTipoDeViaje.SelectedItem = 0;
            this.lblMensajeError.Visible = false;
            this.tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;
            this.listaDeVuelosDisponibles = new List<Vuelo>();
            this.dtgListaVuelosFiltrados.DataSource = Empresa.ListarVuelosDisponibles();
            this.dtgListaVuelosFiltrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosColumnaDataGridVuelo();
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

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            this.DatosColumnaDataGridVuelo();
            string origen = this.cboSeleccionOrigen.SelectedItem.ToString();
            string destino = this.cboSeleccionDestino.SelectedItem.ToString();
            DateTime fecha = this.calendarSeleccionFechaDeViaje.SelectionStart;



            if (destino == origen)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = "El origen debe ser distinto del destino";
            }
            else
            {
                listaDeVuelosDisponibles = Empresa.FiltrarVuelosPorBusqueda(origen, destino, fecha, ofreceComida, ofreceWifi);
                this.dtgListaVuelosFiltrados.DataSource = listaDeVuelosDisponibles;

            }
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

        private void btnCargarVueloSeleccionado_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usted no selecciono un vuelo");
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarDatagrid();

        }

        private void LimpiarDatagrid()
        {

            this.dtgListaVuelosFiltrados.DataSource = null;
            this.dtgListaVuelosFiltrados.Rows.Clear();
            this.dtgListaVuelosFiltrados.DataSource = Empresa.ListarVuelosDisponibles();
            this.DatosColumnaDataGridVuelo();

        }

        private void DatosColumnaDataGridVuelo()
        {

            this.dtgListaVuelosFiltrados.Columns[0].HeaderText = "Codigo";
            this.dtgListaVuelosFiltrados.Columns[1].HeaderText = "Origen";
            this.dtgListaVuelosFiltrados.Columns[2].HeaderText = "Destino";
            this.dtgListaVuelosFiltrados.Columns[3].HeaderText = "Tipo de viaje";
            this.dtgListaVuelosFiltrados.Columns[4].HeaderText = "Servicio Comida";
            this.dtgListaVuelosFiltrados.Columns[5].HeaderText = "Avion";
            this.dtgListaVuelosFiltrados.Columns[6].HeaderText = "Fecha de partida";
            this.dtgListaVuelosFiltrados.Columns[7].HeaderText = "Horas de Viaje";
            this.dtgListaVuelosFiltrados.Columns[8].HeaderText = "Servicio Wifi";
            this.dtgListaVuelosFiltrados.Columns[9].HeaderText = "Asientos turista";
            this.dtgListaVuelosFiltrados.Columns[10].HeaderText = "Asientos Premium";
        }


        private void dtgListaVuelosFiltrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgListaVuelosFiltrados.Rows.Count)
            {
                this.DatosColumnaDataGridVuelo();
                vuelo = dtgListaVuelosFiltrados.Rows[e.RowIndex].DataBoundItem as Vuelo;
                this.filaSeleccionada = true;
            }
        }
    }
}

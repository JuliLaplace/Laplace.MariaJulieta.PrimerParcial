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
    public partial class FrmVentaPasaje : Form
    {
        Vuelo vueloSeleccionado;
        Vuelo vuelo;
        Pasajero pasajeroSeleccionado;
        Pasajero pasajero;
        Equipaje equipajeSeleccionado;
        Pasaje pasajeVendido;
        ETipoPasaje tipoDePasaje;
        double montoTotal;
        bool filaSeleccionada;
        List<Pasajero> listaDePasajerosEnVuelo;


        public FrmVentaPasaje()
        {
            InitializeComponent();
            this.vueloSeleccionado = new Vuelo();
            this.pasajeroSeleccionado = new Pasajero();
            this.equipajeSeleccionado = new Equipaje();
            this.pasajeVendido = new Pasaje();
            this.listaDePasajerosEnVuelo = new List<Pasajero>();
            this.pasajero = new Pasajero();

        }
        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            this.btnCargarPasajero.Enabled = false;
            this.btnCargarEquipaje.Enabled = false;
            this.btnFactura.Enabled = false;
            this.btnCargarOtroPasajero.Enabled = false;
            this.btnEliminarPasajero.Enabled = false;
            this.filaSeleccionada = false;
        }
        public Vuelo VueloSeleccionado
        {
            get { return this.vueloSeleccionado; }
        }

        public Pasajero PasajeroSeleccionado
        {
            get { return this.pasajeroSeleccionado; }
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            FrmBusquedaVuelo frmBusquedaVuelo = new FrmBusquedaVuelo();
            if (frmBusquedaVuelo.ShowDialog() == DialogResult.OK)
            {
                this.vueloSeleccionado = frmBusquedaVuelo.Vuelo;
                this.rtbDatosVuelo.Text = vueloSeleccionado.ToString();
                this.btnCargarPasajero.Enabled = true;
            }
            else
            {

                MessageBox.Show("No se selecciono un vuelo");
            }
        }

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            FrmBusquedaPasajero frmBuscarPasajero = new FrmBusquedaPasajero();
            if (frmBuscarPasajero.ShowDialog() == DialogResult.OK)
            {
                this.pasajeroSeleccionado = frmBuscarPasajero.PasajeroSeleccionado;
                //this.pasajeroSeleccionado.UnVuelo = this.vueloSeleccionado;
                this.rtbDatosPasajero.Text = pasajeroSeleccionado.ToString();
                this.btnCargarEquipaje.Enabled = true;
            }
            else
            {

                MessageBox.Show("No se selecciono un pasajero");
            }
        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {

            FrmCargarEquipaje frmCargarEquipaje = new FrmCargarEquipaje(vueloSeleccionado);
            if (frmCargarEquipaje.ShowDialog() == DialogResult.OK)
            {
                this.equipajeSeleccionado = frmCargarEquipaje.EquipajeCargado;
                this.pasajeroSeleccionado.Equipaje = equipajeSeleccionado;
                this.montoTotal += frmCargarEquipaje.PrecioTotal;
                this.rtbDatosEquipaje.Text = equipajeSeleccionado.ToString();
                this.btnFactura.Enabled = true;
            }

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("************************");
            cadena.AppendLine("Monto total a facturar:");
            cadena.AppendLine("************************");
            cadena.AppendLine($"Precio: ${this.montoTotal}");

            this.rtbDatosFactura.Text = cadena.ToString();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            foreach(Pasajero item in listaDePasajerosEnVuelo)
            {
                Empresa.CargarPasajeroVuelo(this.vueloSeleccionado, item);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            if(listaDePasajerosEnVuelo.Count > 0) {
                foreach (Pasajero item in listaDePasajerosEnVuelo)
                {
                    if (item == pasajeroSeleccionado)
                    {
                        MessageBox.Show("El pasajero ya esta agregado");
                        this.rtbDatosPasajero.Text = string.Empty;
                        this.rtbDatosEquipaje.Text = string.Empty;
                        this.btnBuscarVuelo.Enabled = false;
                        this.btnCargarEquipaje.Enabled = false;
                        return;
                    }
                    
                }
            }
            else
            {
                this.dtgListaPasajesPorVender.DataSource = null;
                this.listaDePasajerosEnVuelo.Add(this.pasajeroSeleccionado);
                this.dtgListaPasajesPorVender.DataSource = listaDePasajerosEnVuelo;
                this.btnCargarOtroPasajero.Enabled = true;
            }
            
            
        }
        private void btnCargarOtroPasajero_Click(object sender, EventArgs e)
        {
            this.rtbDatosPasajero.Text = string.Empty;
            this.rtbDatosEquipaje.Text = string.Empty;
            this.btnBuscarVuelo.Enabled = false;
            this.btnCargarEquipaje.Enabled = false;
        }

        private void dtgListaPasajesPorVender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgListaPasajesPorVender.Rows.Count)
            {
                this.DatosCloumnaDataGridPasajeros();
                //eliminar pasajero
                this.pasajero = dtgListaPasajesPorVender.Rows[e.RowIndex].DataBoundItem as Pasajero;
                this.filaSeleccionada = true;
                this.btnEliminarPasajero.Enabled = true;

            }
        }
        private void DatosCloumnaDataGridPasajeros()
        {
            this.dtgListaPasajesPorVender.Columns[0].HeaderText = "DNI";
            this.dtgListaPasajesPorVender.Columns[1].HeaderText = "Fecha de Nacimiento";
            this.dtgListaPasajesPorVender.Columns[2].HeaderText = "Sexo";
            this.dtgListaPasajesPorVender.Columns[3].HeaderText = "Edad";
            this.dtgListaPasajesPorVender.Columns[4].HeaderText = "Vuelo";
            this.dtgListaPasajesPorVender.Columns[5].HeaderText = "Pasaje";
            this.dtgListaPasajesPorVender.Columns[6].HeaderText = "Lleva equipaje";
            this.dtgListaPasajesPorVender.Columns[7].HeaderText = "Apellido";
            this.dtgListaPasajesPorVender.Columns[8].HeaderText = "Nombre";

        }


        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada)
            {
                this.listaDePasajerosEnVuelo.Remove(pasajero);
            }
            this.dtgListaPasajesPorVender.DataSource = null;
            this.dtgListaPasajesPorVender.DataSource = listaDePasajerosEnVuelo;
        }
    }
}

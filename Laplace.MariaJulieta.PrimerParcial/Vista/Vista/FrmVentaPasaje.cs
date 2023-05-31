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
        Pasajero clienteSeleccionado;
        Pasajero pasajeroSeleccionado;
        Equipaje equipajeSeleccionado;
        Pasaje? pasajeVendido;
        ETipoPasaje tipoDePasaje;
        double montoTotal;
        bool filaSeleccionada;
        List<Pasajero> listaDePasajerosEnVuelo;




        public FrmVentaPasaje()
        {
            InitializeComponent();
            this.vueloSeleccionado = new Vuelo();
            this.clienteSeleccionado = new Pasajero();
            this.equipajeSeleccionado = new Equipaje();
            this.listaDePasajerosEnVuelo = new List<Pasajero>();
            this.pasajeroSeleccionado = new Pasajero();

        }
        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            this.dtgListaPasajesPorVender.Visible = false;
            this.dtgListaPasajesPorVender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaPasajesPorVender.ReadOnly = true;
            this.btnBuscarPasajero.Enabled = false;
            this.btnEmitirPasaje.Enabled = false;
            this.btnFactura.Enabled = false;
            this.btnEliminarPasajero.Enabled = false;
            this.filaSeleccionada = false;
            Color colorPersonalizado = ColorTranslator.FromHtml("#275248");
            this.BackColor = colorPersonalizado;
            this.montoTotal = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            FrmBusquedaVuelo frmBusquedaVuelo = new FrmBusquedaVuelo();
            if (frmBusquedaVuelo.ShowDialog() == DialogResult.OK)
            {
                this.vueloSeleccionado = frmBusquedaVuelo.Vuelo;
                this.rtbDatosVuelo.Text = vueloSeleccionado.ToString();
                this.btnBuscarPasajero.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se selecciono un vuelo");
            }
        }
        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            FrmBusquedaPasajero frmBuscarPasajero = new FrmBusquedaPasajero();
            if (frmBuscarPasajero.ShowDialog() == DialogResult.OK)
            {
                this.clienteSeleccionado = frmBuscarPasajero.PasajeroSeleccionado;
                this.rtbDatosPasajero.Text = clienteSeleccionado.ToString();
                this.btnEmitirPasaje.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se selecciono un pasajero");
            }
        }

        private void btnEmitirPasaje_Click(object sender, EventArgs e)
        {
            FrmCargarEquipaje frmCargarEquipaje = new FrmCargarEquipaje(vueloSeleccionado);
            if (frmCargarEquipaje.ShowDialog() == DialogResult.OK)
            {
                Viaje viaje = new Viaje(frmCargarEquipaje.PasajeAVender, frmCargarEquipaje.EquipajeCargado, frmCargarEquipaje.EquipajeMano);
                this.clienteSeleccionado.ListaDeViajes.Add(viaje);
                this.montoTotal += frmCargarEquipaje.PasajeAVender.PrecioPasajeNeto();
                this.rtbDatosEquipaje.Text = viaje.ToString();
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



        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {

            bool sePuedeAgregar = true;
            if (listaDePasajerosEnVuelo.Count > 0)
            {
                foreach (Pasajero item in listaDePasajerosEnVuelo)
                {
                    if (item == clienteSeleccionado)
                    {
                        MessageBox.Show("El pasajero ya esta agregado");
                        this.rtbDatosPasajero.Text = string.Empty;
                        this.rtbDatosEquipaje.Text = string.Empty;
                        this.btnBuscarVuelo.Enabled = false;
                        this.btnEmitirPasaje.Enabled = false;
                        sePuedeAgregar = false;
                        return;
                    }

                }
            }

            if (sePuedeAgregar)
            {
                AgregarPasajeroAListado();
                DatosCloumnaDataGridPasajeros();
            }


        }

        private void AgregarPasajeroAListado()
        {
            this.dtgListaPasajesPorVender.Visible = true;
            this.dtgListaPasajesPorVender.DataSource = null;
            this.listaDePasajerosEnVuelo.Add(this.clienteSeleccionado);
            this.dtgListaPasajesPorVender.DataSource = listaDePasajerosEnVuelo;
            limpiarFormulario();

        }

        private void limpiarFormulario()
        {
            this.rtbDatosPasajero.Text = string.Empty;
            this.rtbDatosEquipaje.Text = string.Empty;
            this.btnBuscarVuelo.Enabled = false;
            this.btnEmitirPasaje.Enabled = false;
        }
        private void btnVender_Click(object sender, EventArgs e)
        {

            int asientosDisponiblesTurista = vueloSeleccionado.CantidadDeAsientosDisponiblesTurista();
            int asientosDisponiblesPremium = vueloSeleccionado.CantidadDeAsientosDisponiblesPremium();

            if (vueloSeleccionado.CantidadDeAsientosDisponiblesTurista() <= asientosDisponiblesTurista && vueloSeleccionado.CantidadDeAsientosDisponiblesPremium() <= asientosDisponiblesPremium)
            {
                foreach (Pasajero item in listaDePasajerosEnVuelo)
                {
                    Empresa.CargarPasajeroVuelo(this.vueloSeleccionado, item);
                }
                MessageBox.Show("Pasajes vendidos exitosamente.");
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("No hay suficientes asientos disponibles.");
            }
        }

        private void dtgListaPasajesPorVender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgListaPasajesPorVender.Rows.Count)
            {
                this.DatosCloumnaDataGridPasajeros();
                this.pasajeroSeleccionado = dtgListaPasajesPorVender.Rows[e.RowIndex].DataBoundItem as Pasajero;
                this.filaSeleccionada = true;
                this.btnEliminarPasajero.Enabled = true;

            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada)
            {
                Viaje? viajeAEliminar = null;

                foreach (Viaje viaje in pasajeroSeleccionado.ListaDeViajes)
                {
                    if (viaje.Pasaje.Vuelo == vueloSeleccionado)
                    {
                        viajeAEliminar = viaje;
                        break;
                    }
                }
                if (viajeAEliminar is not null)
                {
                    montoTotal -= viajeAEliminar.Pasaje.PrecioPasajeNeto();
                    this.pasajeroSeleccionado.ListaDeViajes.Remove(viajeAEliminar);
                }

                this.DatosCloumnaDataGridPasajeros();

                this.listaDePasajerosEnVuelo.Remove(pasajeroSeleccionado);

            }
            this.dtgListaPasajesPorVender.DataSource = null;
            this.dtgListaPasajesPorVender.DataSource = listaDePasajerosEnVuelo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Pasajero item in listaDePasajerosEnVuelo)
            {
                item.ListaDeViajes.RemoveAt(item.ListaDeViajes.Count - 1);
            }
            this.DialogResult = DialogResult.Cancel;
        }
        private void DatosCloumnaDataGridPasajeros()
        {
            this.dtgListaPasajesPorVender.Columns[0].HeaderText = "DNI";
            this.dtgListaPasajesPorVender.Columns[1].HeaderText = "Fecha de Nacimiento";
            this.dtgListaPasajesPorVender.Columns[2].HeaderText = "Sexo";
            this.dtgListaPasajesPorVender.Columns[3].HeaderText = "Edad";
            this.dtgListaPasajesPorVender.Columns[4].HeaderText = "Apellido";
            this.dtgListaPasajesPorVender.Columns[5].HeaderText = "Nombre";
        }

    }
}

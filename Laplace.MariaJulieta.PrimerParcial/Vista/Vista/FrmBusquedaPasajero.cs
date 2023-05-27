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
    public partial class FrmBusquedaPasajero : Form
    {
        Pasajero pasajeroBuscado;
        bool filaSeleccionada;
        List<Pasajero> listaPasajerosFiltrados;
        public Pasajero PasajeroSeleccionado
        {
            get { return pasajeroBuscado; }
            set { pasajeroBuscado = value; }
        }

        public FrmBusquedaPasajero()
        {
            InitializeComponent();
            this.pasajeroBuscado = new Pasajero();
            this.filaSeleccionada = false;
            this.listaPasajerosFiltrados = new List<Pasajero>();
        }

        private void FrmBusquedaPasajero_Load(object sender, EventArgs e)
        {
            this.dtgListarPasajeros.DataSource = Empresa.ListarPasajeros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarDatagrid();
            this.dtgListarPasajeros.ClearSelection();
            this.dtgListarPasajeros.DataSource = Empresa.ListarPasajeros();
        }

        private void LimpiarDatagrid()
        {
            this.DatosCloumnaDataGridPasajeros();
            this.dtgListarPasajeros.DataSource = null;
            this.dtgListarPasajeros.Rows.Clear();
        }
        private void DatosCloumnaDataGridPasajeros()
        {
            this.dtgListarPasajeros.Columns[0].HeaderText = "DNI";
            this.dtgListarPasajeros.Columns[1].HeaderText = "Fecha de Nacimiento";
            this.dtgListarPasajeros.Columns[2].HeaderText = "Sexo";
            this.dtgListarPasajeros.Columns[3].HeaderText = "Edad";
            this.dtgListarPasajeros.Columns[4].HeaderText = "Vuelo";
            this.dtgListarPasajeros.Columns[5].HeaderText = "Pasaje";
            this.dtgListarPasajeros.Columns[6].HeaderText = "Lleva equipaje";
            this.dtgListarPasajeros.Columns[7].HeaderText = "Apellido";
            this.dtgListarPasajeros.Columns[8].HeaderText = "Nombre";

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            FrmPasajero formularioPasajero = new FrmPasajero();
            if (formularioPasajero.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void btnSeleccionPasajero_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usted no selecciono un Pasajero");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.DatosCloumnaDataGridPasajeros();
            string nombre = this.txtBusquedaPorNombre.Text;
            string apellido = this.txtBusquedaPorApellido.Text;
            int dni;
            if ((int.TryParse(this.txtBusquedaPorDni.Text, out dni)) || nombre != string.Empty || apellido != string.Empty)
            {
                this.listaPasajerosFiltrados = Empresa.FiltrarPasajerosPorBusqueda(nombre, apellido, dni);
                this.dtgListarPasajeros.DataSource = listaPasajerosFiltrados;
            }
            else
            {
                MessageBox.Show("Ingreso campos invalidos. Reintente.");
                this.txtBusquedaPorDni.Text = string.Empty;
            }

        }

        private void dtgListarPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgListarPasajeros.Rows.Count)
            {
                DatosCloumnaDataGridPasajeros();
                this.pasajeroBuscado = dtgListarPasajeros.Rows[e.RowIndex].DataBoundItem as Pasajero;
                this.filaSeleccionada = true;
            }
        }
    }
}

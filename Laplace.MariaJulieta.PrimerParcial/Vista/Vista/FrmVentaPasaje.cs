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
        Pasajero pasajeroSeleccionado;
        Equipaje equipajeSeleccionado;
        Pasaje pasajeVendido;
        ETipoPasaje tipoDePasaje;


        public FrmVentaPasaje()
        {
            InitializeComponent();
            this.vueloSeleccionado = new Vuelo();
            this.pasajeroSeleccionado = new Pasajero();
            this.equipajeSeleccionado = new Equipaje();
            this.pasajeVendido = new Pasaje();

        }
        public Vuelo VueloSeleccionado
        {
            get { return this.vueloSeleccionado;}
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
                this.rtbDatosPasajero.Text = pasajeroSeleccionado.ToString();
            }
            else
            {
                MessageBox.Show("No se selecciono un pasajero");
            }
        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {
            FrmCargarEquipaje frmCargarEquipaje = new FrmCargarEquipaje();
            if (frmCargarEquipaje.ShowDialog() == DialogResult.OK)
            {
                this.equipajeSeleccionado = frmCargarEquipaje.EquipajeCargado;
                this.rtbDatosEquipaje.Text = equipajeSeleccionado.ToString();
            }

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Mostrar datos factruracion
        }

        private void btnCargarOtroPasajero_Click(object sender, EventArgs e)
        {
            //hablilitar para cargar otro pasajero a vuelo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           this.DialogResult= DialogResult.OK;
        }
    }
}

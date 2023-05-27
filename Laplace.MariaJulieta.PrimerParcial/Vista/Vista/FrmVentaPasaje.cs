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


        public FrmVentaPasaje()
        {
            InitializeComponent();
            this.vueloSeleccionado = new Vuelo();
            this.pasajeroSeleccionado = new Pasajero();
            this.equipajeSeleccionado = new Equipaje();

        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            FrmBusquedaVuelo frmBusquedaVuelo = new FrmBusquedaVuelo();
            if (frmBusquedaVuelo.ShowDialog() == DialogResult.OK)
            {
                this.vueloSeleccionado = frmBusquedaVuelo.Vuelo;
                this.CargarListBoxVuelo();
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
                this.CargarListBoxPasajero();
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
                this.CargarListBoxEquipaje();
            }

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //mostrar cuanto se factura en listbox
        }

        private void btnCargarOtroPasajero_Click(object sender, EventArgs e)
        {
            this.lstDatosEquipaje.Items.Clear();
            this.lstDatosPasajero.Items.Clear();
            this.lstDatosVueloSeleccionado.Items.Clear();
        }


        private void CargarListBoxVuelo()
        {
            this.lstDatosVueloSeleccionado.Items.Clear();
            this.lstDatosVueloSeleccionado.Items.Add(vueloSeleccionado);


        }
        private void CargarListBoxPasajero()
        {
            this.lstDatosPasajero.Items.Clear();
            this.lstDatosPasajero.Items.Add(pasajeroSeleccionado);


        }
        private void CargarListBoxEquipaje()
        {
            this.lstDatosEquipaje.Items.Clear();
            this.lstDatosEquipaje.Items.Add(equipajeSeleccionado);


        }
        private void CargarListBoxFactura()
        {
            this.lstFactura.Items.Clear();
            this.lstFactura.Items.Add("Buenos Aires - Argentina");


        }
    }
}

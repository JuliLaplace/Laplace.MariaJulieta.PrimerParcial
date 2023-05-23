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

        public FrmVentaPasaje()
        {
            InitializeComponent();
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            FrmBusquedaVuelo frmBusquedaVuelo = new FrmBusquedaVuelo();
            frmBusquedaVuelo.ShowDialog();
        }

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            FrmBusquedaPasajero frmBuscarPasajero = new FrmBusquedaPasajero();
            frmBuscarPasajero.ShowDialog();
        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {
            FrmCargarEquipaje frmCargarEquipaje = new FrmCargarEquipaje();
            frmCargarEquipaje.ShowDialog();
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
    }
}

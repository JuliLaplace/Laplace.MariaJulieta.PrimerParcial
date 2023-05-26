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
        public FrmModificarVuelo(Vuelo vuelo)
        {
            InitializeComponent();
            vueloRecibido = vuelo;
        }

        private void FrmModificarVuelo_Load(object sender, EventArgs e)
        {
            this.lblMensajeError.Visible = false;
            this.calendarSeleccionFechaDeViaje.MinDate = DateTime.Now;
            this.cboSeleccionTipoDeViaje.DataSource = Enum.GetValues(typeof(ETipoViaje));
            this.cboSeleccionAvion.DataSource = Empresa.ListarAviones();
            this.cboSeleccionTipoDeViaje.SelectedItem = 0;
            this.tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;

        }
    }
}

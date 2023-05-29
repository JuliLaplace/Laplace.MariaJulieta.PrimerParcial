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
    public partial class FrmListaPasajeros : Form
    {
        Vuelo vueloAMostrar;
        public FrmListaPasajeros(Vuelo vueloRecibido)
        {
            InitializeComponent();
            this.vueloAMostrar = vueloRecibido;
        }

        private void FrmListaPasajeros_Load(object sender, EventArgs e)
        {
            this.lblVuelo.Text = this.vueloAMostrar.ToString();
            this.dtgListadoPasajeros.DataSource = this.vueloAMostrar.Pasajeros;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

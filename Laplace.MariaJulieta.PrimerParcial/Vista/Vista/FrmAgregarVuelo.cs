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
    public partial class FrmAgregarVuelo : Form
    {
        ETipoViaje tipoDeViaje;
        bool ofreceWifi;
        public FrmAgregarVuelo()
        {
            InitializeComponent();
        }

        private void FormAgregarVuelo_Load(object sender, EventArgs e)
        {
            this.lblMensajeError.Visible = false;
            this.calendarSeleccionFechaDeViaje.MinDate = DateTime.Now;
            this.cboSeleccionTipoDeViaje.DataSource = Enum.GetValues(typeof(ETipoViaje));
            this.cboSeleccionAvion.DataSource = Empresa.ListarAviones();
            this.cboSeleccionAvion.DisplayMember = "Nombre"; // propiedad del objeto Avion que se mostrará en el ComboBox
            this.cboSeleccionAvion.ValueMember = "Matricula"; // propiedad del objeto Avion que se utilizará como valor seleccionado en el ComboBox
            this.cboSeleccionTipoDeViaje.SelectedItem = 0;
            this.cboSeleccionServicioComida.SelectedIndex = 0;
            tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;

        }


        private void cboSeleccionTipoDeViaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ETipoViaje tipoDeViaje = (ETipoViaje)cboSeleccionTipoDeViaje.SelectedValue;

            if (tipoDeViaje == ETipoViaje.Internacional)
            {
                this.cboSeleccionOrigen.Items.Clear();
                this.cboSeleccionOrigen.Items.AddRange(Empresa.ListarDestinosInternacionales());
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {

            string origen = this.cboSeleccionOrigen.SelectedItem.ToString();
            string destino = this.cboSeleccionDestino.SelectedItem.ToString();
            
            Avion avionSeleccionado = (Avion)cboSeleccionAvion.SelectedItem;//VER
            string matriculaAvionSeleccionado = avionSeleccionado.Matricula;
            DateTime fecha = this.calendarSeleccionFechaDeViaje.SelectionStart;
            bool ofreceComida = ServicioOfreceComida();


            if (destino == origen)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = "El origen debe ser distinto del destino";
            }
            else
            {

                Empresa.AgregarVuelo(origen, destino, tipoDeViaje, avionSeleccionado, fecha, ofreceComida, ofreceWifi); //COMPLETAR
                MessageBox.Show("Vuelo agregado con exito");
                this.Close();

            }


        }

        private bool ServicioOfreceComida()
        {
            bool ofreceComida;
            if (this.cboSeleccionServicioComida.SelectedItem.ToString() == "No")
            {
                ofreceComida = false;
            }
            else
            {
                ofreceComida = true;
            }
            return ofreceComida;
        }

        private void rdbServicioDeWifi_CheckedChanged(object sender, EventArgs e)
        {
            ofreceWifi = this.rdbServicioDeWifi.Checked;
        }
    }
}

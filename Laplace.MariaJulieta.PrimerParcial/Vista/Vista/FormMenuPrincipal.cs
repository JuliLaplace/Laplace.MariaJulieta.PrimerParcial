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
    public partial class FormMenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        FormLogin formularioLogin;
        public FormMenuPrincipal(Usuario usuario, FormLogin login)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.formularioLogin = login;
            this.lblBienvenidaUser.Visible = false;
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;
            
        }


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

            
            this.lblFechaActual.Text = DateTime.Now.ToShortDateString();
            this.lblBienvenidaUser.Visible = true;
            this.lblBienvenidaUser.Text = "Bienvenido " + usuarioLogueado.Correo;

            if (usuarioLogueado.Perfil == "vendedor")
            {
                this.vuelosToolStripMenuItem.Visible = true;
                this.ventaDePasajesToolStripMenuItem.Visible = true;
                this.estadisticasHistoricasToolStripMenuItem.Visible = true;
                this.clientesToolStripMenuItem.Visible = true;

            }
            else if (usuarioLogueado.Perfil == "supervisor")
            {
                this.estadisticasHistoricasToolStripMenuItem.Visible = true;
                this.clientesToolStripMenuItem.Visible = true;
            }
            else
            {
                this.vuelosToolStripMenuItem.Visible = true;
                this.aeronavesToolStripMenuItem.Visible = true;

            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            formularioLogin.Show();
            formularioLogin.LimpiarPantalla();
            this.Close();
        }

        private void verListadoDeVuelosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgListar.Visible = true;
            this.lblTitulo.Text = "Listado de Vuelos";
            this.lblTitulo.Visible = true;
            this.dtgListar.DataSource = Empresa.ListarVuelos();


        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;
        }

        private void aeronavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgListar.Visible = true;
            this.lblTitulo.Text = "Listado de Aeronaves";
            this.lblTitulo.Visible = true;
            this.dtgListar.DataSource = Empresa.ListarAviones();
        }

        private void agregarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente frmAgregarCliente = new FormAgregarCliente(); //formulario modal
            if (frmAgregarCliente.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

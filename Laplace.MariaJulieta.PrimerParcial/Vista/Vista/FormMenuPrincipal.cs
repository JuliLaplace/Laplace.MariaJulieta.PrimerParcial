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
                this.vuelosToolStripMenuItem.Enabled = false;
                this.aeronavesToolStripMenuItem.Enabled = false;


            }
            else if (usuarioLogueado.Perfil == "supervisor")
            {
                this.ventaDePasajesToolStripMenuItem.Enabled = false;
                this.vuelosToolStripMenuItem.Enabled = false;
                this.aeronavesToolStripMenuItem.Enabled = false;
                //si las puede listar. Hacer boton aparte para Listar cosas? va a ser mejor manejado
            }
            else if( usuarioLogueado.Perfil == "administrador")
            {
                this.verListadoDeVuelosDisponiblesToolStripMenuItem.Enabled = false;
                this.ventaDePasajesToolStripMenuItem.Enabled = false;
                this.estadisticasHistoricasToolStripMenuItem.Enabled = false;
                this.clientesToolStripMenuItem.Enabled = false;


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


        private void agregarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente frmAgregarCliente = new FormAgregarCliente(); //formulario modal
            if (frmAgregarCliente.ShowDialog() == DialogResult.OK)
            {
                //?????????????????
            }
        }

        private void agregarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarVuelo formAgregarVuelo = new FormAgregarVuelo();
            formAgregarVuelo.Show();
        }

        private void listarAeronavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgListar.Visible = true;
            this.lblTitulo.Text = "Listado de Aeronaves";
            this.lblTitulo.Visible = true;
            this.dtgListar.DataSource = Empresa.ListarAviones();
        }

        private void verListadoDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dtgListar.Visible = true;
            this.lblTitulo.Text = "Listado de Clientes";
            this.lblTitulo.Visible = true;
            this.dtgListar.DataSource = Empresa.ListarClientes();
        }

        private void crearAeronavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarAvion formAgregarAvion = new FormAgregarAvion();
            formAgregarAvion.Show();
        }
    }
}

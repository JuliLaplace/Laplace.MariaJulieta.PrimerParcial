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
using System.IO;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        FrmLogin formularioLogin;
        string categoriaSeleccionada;



        public FrmMenuPrincipal(Usuario usuario, FrmLogin login)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.formularioLogin = login;
            this.lblBienvenidaUser.Visible = false; //?????????????????
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;
            this.categoriaSeleccionada = "Inicio";


        }


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.MostrarControles(categoriaSeleccionada);
            this.lblFechaActual.Text = DateTime.Now.ToShortDateString();
            this.lblBienvenidaUser.Visible = true;
            this.lblBienvenidaUser.Text = "Bienvenido " + usuarioLogueado.Nombre;

            if (usuarioLogueado.Perfil == "vendedor")
            {
                this.vuelosToolStripMenuItem.Enabled = false;
                this.avionesToolStripMenuItem.Enabled = false;


            }
            else if (usuarioLogueado.Perfil == "supervisor")
            {
                this.ventaDePasajesToolStripMenuItem.Enabled = false;
                this.vuelosToolStripMenuItem.Enabled = false;
                this.avionesToolStripMenuItem.Enabled = false;
                //si las puede listar. Hacer boton aparte para Listar cosas? va a ser mejor manejado
            }
            else if (usuarioLogueado.Perfil == "administrador")
            {
                this.btnListar.Enabled = false;
                this.ventaDePasajesToolStripMenuItem.Enabled = false;
                this.estadisticasHistoricasToolStripMenuItem.Enabled = false;
                this.clientesToolStripMenuItem.Enabled = false;


            }

        }


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoriaSeleccionada = "Inicio";
            this.MostrarControles(categoriaSeleccionada);
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;

        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.dtgListar.Visible = false;
            this.lblTitulo.Text = "Categoría: Aviones";
            this.categoriaSeleccionada = "Avion";
            this.pctBxImagenPAraMostrar.Visible = true;
            this.MostrarControles(categoriaSeleccionada);
            //string rutaImagen = Path.Combine(Application.StartupPath, "Iconos", "ImagenClientes.png\\..\\..\\..\\..\\..");
            //pctBxImagenPAraMostrar.Image = Image.FromFile(rutaImagen);
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.LimpiarDatagrid();
            this.dtgListar.Visible = false; //que es mejor?
            this.lblTitulo.Text = "Categoría: Clientes";
            this.categoriaSeleccionada = "Cliente";
            this.pctBxImagenPAraMostrar.Visible = true;
            this.MostrarControles(categoriaSeleccionada);
            //string rutaImagen = Path.Combine(Application.StartupPath, "Iconos", "ImagenClientes.png\\..\\..\\..\\..\\..");
            //pctBxImagenPAraMostrar.Image = Image.FromFile(rutaImagen);
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.LimpiarDatagrid();
            this.dtgListar.Visible=false;
            this.lblTitulo.Text = "Categoría: Vuelos";
            this.categoriaSeleccionada = "Vuelo";
            this.pctBxImagenPAraMostrar.Visible = true;
            this.MostrarControles(categoriaSeleccionada);
            //string rutaImagen = Path.Combine(Application.StartupPath, "Iconos", "ImagenClientes.png\\..\\..\\..\\..\\..");
            //pctBxImagenPAraMostrar.Image = Image.FromFile(rutaImagen);

        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            switch (categoriaSeleccionada)
            {
                case "Cliente":

                    FrmAgregarCliente agregarClienteForm = new FrmAgregarCliente();
                    agregarClienteForm.ShowDialog();
                    break;
                case "Vuelo":

                    FrmAgregarVuelo agregarVueloForm = new FrmAgregarVuelo();
                    agregarVueloForm.ShowDialog();
                    break;
                case "Avion":

                    FrmAgregarAvion agregarAvionForm = new FrmAgregarAvion();
                    agregarAvionForm.ShowDialog();
                    break;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (categoriaSeleccionada)
            {
                case "Cliente":

                    FrmAgregarCliente agregarClienteForm = new FrmAgregarCliente();
                    agregarClienteForm.ShowDialog();
                    break;
                case "Vuelo":

                    FrmAgregarVuelo agregarVueloForm = new FrmAgregarVuelo();
                    agregarVueloForm.ShowDialog();
                    break;
                case "Avion":

                    FrmAgregarAvion agregarAvionForm = new FrmAgregarAvion();
                    agregarAvionForm.ShowDialog();
                    break;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (categoriaSeleccionada)
            {
                case "Cliente":

                    FrmAgregarCliente agregarClienteForm = new FrmAgregarCliente();
                    agregarClienteForm.ShowDialog();
                    break;
                case "Vuelo":

                    FrmAgregarVuelo agregarVueloForm = new FrmAgregarVuelo();
                    agregarVueloForm.ShowDialog();
                    break;
                case "Avion":

                    FrmAgregarAvion agregarAvionForm = new FrmAgregarAvion();
                    agregarAvionForm.ShowDialog();
                    break;

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (categoriaSeleccionada)
            {
                case "Cliente":
                    this.LimpiarDatagrid();
                    this.dtgListar.Visible = true;
                    this.dtgListar.ClearSelection();
                    this.dtgListar.DataSource = Empresa.ListarClientes();

                    break;
                case "Vuelo":
                    
                    this.dtgListar.Visible = true;
                    this.dtgListar.ClearSelection();
                    this.dtgListar.DataSource = Empresa.ListarVuelos();
                    this.DatosColumnaDataGridVuelo();
                    this.dtgListar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;
                case "Avion":
                    this.LimpiarDatagrid();
                    this.dtgListar.Visible = true;

                    this.dtgListar.DataSource = Empresa.ListarAviones();
                    this.DatosColumnaDataGridAviones();
                    this.dtgListar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            formularioLogin.Show();
            formularioLogin.LimpiarPantalla();
            this.Close();
        }
        private void DatosColumnaDataGridVuelo()
        {
            this.dtgListar.Columns[0].HeaderText = "Origen";
            this.dtgListar.Columns[1].HeaderText = "Destino";
            this.dtgListar.Columns[2].HeaderText = "Tipo de viaje";
            this.dtgListar.Columns[3].HeaderText = "Servicio Comida";
            this.dtgListar.Columns[4].HeaderText = "Avion";
            this.dtgListar.Columns[5].HeaderText = "Fecha de partida";
            this.dtgListar.Columns[6].HeaderText = "Horas de Viaje";
            this.dtgListar.Columns[7].HeaderText = "Servicio Wifi";
            //this.dtgListar.Columns[7].HeaderText = "Asientos Turista";
            //this.dtgListar.Columns[8].HeaderText = "Asientos Premium";
        }
        private void DatosColumnaDataGridAviones()
        {
            this.dtgListar.Columns[0].HeaderText = "Nombre";
            this.dtgListar.Columns[1].HeaderText = "Matricula";
            this.dtgListar.Columns[2].HeaderText = "Cantidad de Asientos";
            this.dtgListar.Columns[3].HeaderText = "Cantidad de Baños";
            this.dtgListar.Columns[4].HeaderText = "Capacidad Bodega";

        }

        private void MostrarControles(string categoriaSeleccionada)
        {
            if (categoriaSeleccionada == "Cliente" || categoriaSeleccionada == "Avion" || categoriaSeleccionada == "Vuelo")
            {
                this.btnModificar.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnAgregar.Visible = true;
                this.panelBotones.Visible = true;
                this.pctBxImagenPAraMostrar.Visible = true;
            }
            else if (categoriaSeleccionada == "Inicio" || categoriaSeleccionada == "Listados")
            {
                this.btnModificar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnAgregar.Visible = false;
                this.panelBotones.Visible = false;
                this.pctBxImagenPAraMostrar.Visible = false;
            }

        }

        private void LimpiarDatagrid()
        {
            dtgListar.DataSource = null;
            dtgListar.Rows.Clear();
        }

    }
}

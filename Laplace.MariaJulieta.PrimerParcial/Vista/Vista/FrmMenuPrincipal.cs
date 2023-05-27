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
        Cliente cliente;
        Avion avion;
        Vuelo vuelo;
        Pasajero pasajero;
        private bool filaSeleccionada; //



        public FrmMenuPrincipal(Usuario usuario, FrmLogin login)
        {
            InitializeComponent();
            this.filaSeleccionada = false;//
            this.usuarioLogueado = usuario;
            this.formularioLogin = login;
            this.pasajero = new Pasajero();
            this.cliente = new Cliente();
            this.avion = new Avion();
            this.vuelo = new Vuelo();
            this.categoriaSeleccionada = "Inicio";

        }


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;
            this.dtgListar.ReadOnly = true;
            Color colorPersonalizado = ColorTranslator.FromHtml("#275248");
            this.menuStrip1.BackColor = colorPersonalizado;
            this.lblBienvenidaUser.BackColor = colorPersonalizado;
            this.lblFechaActual.BackColor = colorPersonalizado;
            this.IsMdiContainer = true;
            this.MostrarControles(categoriaSeleccionada);
            this.lblFechaActual.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            this.lblBienvenidaUser.Visible = true;
            this.lblBienvenidaUser.Text = "Bienvenido: " + usuarioLogueado.Nombre + usuarioLogueado.Apellido;



            switch (usuarioLogueado.Perfil)
            {
                case "vendedor":
                    this.vuelosToolStripMenuItem.Enabled = false;
                    this.avionesToolStripMenuItem.Enabled = false;
                    break;
                case "supervisor":
                    this.ventaDePasajesToolStripMenuItem.Enabled = false;
                    this.vuelosToolStripMenuItem.Enabled = false;
                    this.avionesToolStripMenuItem.Enabled = false;
                    break;
                case "administrador":
                    // Deshabilitar elementos de menú según el perfil de administrador
                    // this.btnListar.Enabled = false;
                    // this.ventaDePasajesToolStripMenuItem.Enabled = false;
                    // this.estadisticasHistoricasToolStripMenuItem.Enabled = false;
                    // this.clientesToolStripMenuItem.Enabled = false;
                    // VOLVER A PONER CUANDO FUNCIONE TODO
                    break;
            }
        }


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarDatosInicio();
        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarDatosAviones();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarDatosClientes();
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarDatosVuelos();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            switch (categoriaSeleccionada)
            {
                case "Pasajero":

                    FrmPasajero agregarPasajeroForm = new FrmPasajero();
                    if (agregarPasajeroForm.ShowDialog() == DialogResult.OK)
                    {
                        this.dtgListar.DataSource = null;
                        this.dtgListar.DataSource = Empresa.ListarPasajeros();
                    }
                    break;
                case "Vuelo":

                    FrmAgregarVuelo agregarVueloForm = new FrmAgregarVuelo();
                    if (agregarVueloForm.ShowDialog() == DialogResult.OK)
                    {
                        this.dtgListar.DataSource = null;
                        this.dtgListar.DataSource = Empresa.ListarVuelos();
                    }
                    break;
                case "Avion":

                    FrmAgregarAvion agregarAvionForm = new FrmAgregarAvion();
                    if (agregarAvionForm.ShowDialog() == DialogResult.OK)
                    {
                        this.dtgListar.DataSource = null;
                        this.dtgListar.DataSource = Empresa.ListarAviones();
                    }
                    break;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!filaSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione una fila antes de continuar.");
                return; // Salir del método sin realizar ninguna otra acción
            }
            else
            {
                switch (categoriaSeleccionada)
                {
                    case "Pasajero":

                        FrmModificarPasajero modificarPasajeroForm = new FrmModificarPasajero(pasajero);
                        if (modificarPasajeroForm.ShowDialog() == DialogResult.OK)
                        {
                            this.dtgListar.DataSource = null;
                            this.dtgListar.DataSource = Empresa.ListarPasajeros();
                        }
                        break;
                    case "Vuelo":

                        FrmModificarVuelo modificarVueloForm = new FrmModificarVuelo(vuelo);
                        if (modificarVueloForm.ShowDialog() == DialogResult.OK)
                        {
                            this.dtgListar.DataSource = null;
                            this.dtgListar.DataSource = Empresa.ListarVuelos();
                        }
                        break;
                    case "Avion":

                        FrmModificarAvion modificarAvionForm = new FrmModificarAvion(avion);
                        if (modificarAvionForm.ShowDialog() == DialogResult.OK)
                        {
                            this.dtgListar.DataSource = null;
                            this.dtgListar.DataSource = Empresa.ListarAviones();
                        }
                        break;

                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!filaSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione una fila antes de continuar.");
                return;
            }
            else
            {
                switch (categoriaSeleccionada)
                {
                    case "Pasajero":

                        FrmEliminarPasajero eliminarPasajeroForm = new FrmEliminarPasajero(pasajero); //tengonque pasarle el pasajero por parametro
                        if (eliminarPasajeroForm.ShowDialog() == DialogResult.OK)
                        {
                            Empresa.Eliminar(pasajero);
                            this.dtgListar.DataSource = null;
                            dtgListar.DataSource = Empresa.ListarPasajeros();
                        }

                        break;
                    case "Vuelo":

                        FrmEliminarVuelo eliminarVueloForm = new FrmEliminarVuelo(vuelo);
                        if (eliminarVueloForm.ShowDialog() == DialogResult.OK)
                        {
                            Empresa.Eliminar(vuelo);
                            this.dtgListar.DataSource = null;
                            dtgListar.DataSource = Empresa.ListarVuelos();
                        }
                        break;
                    case "Avion":

                        FrmEliminarAvion agregarAvionForm = new FrmEliminarAvion(avion);
                        if (agregarAvionForm.ShowDialog() == DialogResult.OK)
                        {
                            Empresa.Eliminar(avion);
                            this.dtgListar.DataSource = null;
                            dtgListar.DataSource = Empresa.ListarAviones();
                        }
                        break;

                }
            }

        }



        private void DatosColumnaDataGridVuelo()
        {
            this.dtgListar.Columns[0].HeaderText = "Codigo";
            this.dtgListar.Columns[1].HeaderText = "Origen";
            this.dtgListar.Columns[2].HeaderText = "Destino";
            this.dtgListar.Columns[3].HeaderText = "Tipo de viaje";
            this.dtgListar.Columns[4].HeaderText = "Servicio Comida";
            this.dtgListar.Columns[5].HeaderText = "Avion";
            this.dtgListar.Columns[6].HeaderText = "Fecha de partida";
            this.dtgListar.Columns[7].HeaderText = "Horas de Viaje";
            this.dtgListar.Columns[8].HeaderText = "Servicio Wifi";
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
        private void DatosCloumnaDataGridPasajeros()
        {
            this.dtgListar.Columns[0].HeaderText = "DNI";
            this.dtgListar.Columns[1].HeaderText = "Fecha de Nacimiento";
            this.dtgListar.Columns[2].HeaderText = "Sexo";
            this.dtgListar.Columns[3].HeaderText = "Edad";
            this.dtgListar.Columns[4].HeaderText = "Vuelo";
            this.dtgListar.Columns[5].HeaderText = "Pasaje";
            this.dtgListar.Columns[6].HeaderText = "Lleva equipaje";
            this.dtgListar.Columns[7].HeaderText = "Apellido";
            this.dtgListar.Columns[8].HeaderText = "Nombre";

        }

        private void MostrarControles(string categoriaSeleccionada)
        {

            switch (categoriaSeleccionada)
            {
                case "Pasajero":
                case "Avion":
                case "Vuelo":
                    this.panelBotones.Visible = true;
                    this.dtgListar.Visible = true;
                    this.pctBxImagenPAraMostrar.Visible = true;
                    break;
                case "Inicio":
                case "Listados":
                    this.panelBotones.Visible = false;
                    this.pctBxImagenPAraMostrar.Visible = false;
                    break;
            }

        }

        private void LimpiarDatagrid()
        {
            dtgListar.DataSource = null;
            dtgListar.Rows.Clear();
        }

        private void ventaDePasajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje formularioVentaDePasaje = new FrmVentaPasaje();
            if (formularioVentaDePasaje.ShowDialog() == DialogResult.OK)
            {
                //Vuelo vueloSeleccionado = formularioBuscarVuelo.Vuelo;
            }

        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea salir de la aplicación?", "Cierre de sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
                this.formularioLogin.Show();
                this.formularioLogin.LimpiarPantalla();
            }
            else
            {
                e.Cancel = true;
            }
        }



        private void dtgListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (categoriaSeleccionada)
            {
                case "Pasajero":
                    // Verificar si se hizo clic en una fila válida
                    if (e.RowIndex >= 0 && e.RowIndex < dtgListar.Rows.Count)
                    {
                        // Obtener el objeto seleccionado en el datagrid
                        this.pasajero = dtgListar.Rows[e.RowIndex].DataBoundItem as Pasajero;

                        // Actualizo la variable fila
                        this.filaSeleccionada = true;
                    }
                    break;

                case "Vuelo":
                    if (e.RowIndex >= 0 && e.RowIndex < dtgListar.Rows.Count)
                    {

                        this.vuelo = dtgListar.Rows[e.RowIndex].DataBoundItem as Vuelo;


                        this.filaSeleccionada = true;
                    }
                    break;

                case "Avion":
                    if (e.RowIndex >= 0 && e.RowIndex < dtgListar.Rows.Count)
                    {

                        this.avion = dtgListar.Rows[e.RowIndex].DataBoundItem as Avion;


                        this.filaSeleccionada = true;
                    }
                    break;
            }

        }
        private void MostrarDatosAviones()
        {
            this.LimpiarDatagrid();
            this.dtgListar.DataSource = Empresa.ListarAviones();
            this.DatosColumnaDataGridAviones();
            this.lblTitulo.Visible = true;
            this.lblTitulo.Text = "Categoría: Aviones";
            this.categoriaSeleccionada = "Avion";
            this.MostrarControles(categoriaSeleccionada);
        }
        private void MostrarDatosClientes()
        {
            this.LimpiarDatagrid();
            this.dtgListar.DataSource = Empresa.ListarPasajeros();
            this.lblTitulo.Visible = true;
            this.lblTitulo.Text = "Categoría: Pasajeros";
            this.categoriaSeleccionada = "Pasajero";
            this.MostrarControles(categoriaSeleccionada);
            this.DatosCloumnaDataGridPasajeros();
        }

        private void MostrarDatosVuelos()
        {
            this.LimpiarDatagrid();
            this.dtgListar.DataSource = Empresa.ListarVuelos();
            this.DatosColumnaDataGridVuelo();
            this.dtgListar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.lblTitulo.Visible = true;
            this.lblTitulo.Text = "Categoría: Vuelos";

            this.categoriaSeleccionada = "Vuelo";
            this.MostrarControles(categoriaSeleccionada);
        }
        private void MostrarDatosInicio()
        {
            this.categoriaSeleccionada = "Inicio";
            this.dtgListar.Visible = false; //preguntar si se tienen que ver vuelos
            this.lblTitulo.Visible = false;
            this.MostrarControles(categoriaSeleccionada);
        }
    }
}

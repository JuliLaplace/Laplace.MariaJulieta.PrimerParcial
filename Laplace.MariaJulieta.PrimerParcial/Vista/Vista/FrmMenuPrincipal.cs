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



        public FrmMenuPrincipal(Usuario usuario, FrmLogin login)
        {
            InitializeComponent();
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
            this.categoriaSeleccionada = "Inicio";
            this.dtgListar.Visible = false;
            this.lblTitulo.Visible = false;
            this.dtgListar.ReadOnly = true;
            this.IsMdiContainer = true;
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

            }
            else if (usuarioLogueado.Perfil == "administrador")
            {
                //this.btnListar.Enabled = false;
                //this.ventaDePasajesToolStripMenuItem.Enabled = false;
                //this.estadisticasHistoricasToolStripMenuItem.Enabled = false;
                //this.clientesToolStripMenuItem.Enabled = false;
                //VOLVER A PONER CUANDO FUNCIONE TODO

            }

        }


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.categoriaSeleccionada = "Inicio";
            this.MostrarControles(categoriaSeleccionada);
            this.dtgListar.Visible = false; //preguntar si se tienen que ver vuelos
            this.lblTitulo.Visible = false;
        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarControles(categoriaSeleccionada);
            this.LimpiarDatagrid();
            this.dtgListar.DataSource = Empresa.ListarAviones();
            this.DatosColumnaDataGridAviones();
            this.dtgListar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.lblTitulo.Text = "Categoría: Aviones";
            this.categoriaSeleccionada = "Avion";



        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.MostrarControles(categoriaSeleccionada);
            this.LimpiarDatagrid();
            //this.DatosCloumnaDataGridPasajeros();
            this.dtgListar.DataSource = Empresa.ListarPasajeros();
            this.lblTitulo.Text = "Categoría: Pasajeros";
            this.categoriaSeleccionada = "Pasajero";
            this.pctBxImagenPAraMostrar.Visible = true;
            this.dtgListar.CurrentCell = dtgListar.Rows[0].Cells[0]; //MODIFICAR

            // poner primer pasajero - forzado

        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LimpiarDatagrid();
            this.MostrarControles(categoriaSeleccionada);
            this.dtgListar.ClearSelection();
            this.dtgListar.DataSource = Empresa.ListarVuelos();
            this.DatosColumnaDataGridVuelo();
            this.dtgListar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.lblTitulo.Text = "Categoría: Vuelos";
            this.categoriaSeleccionada = "Vuelo";
            this.pctBxImagenPAraMostrar.Visible = true;


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

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    if (eliminarVueloForm.ShowDialog() != DialogResult.OK)
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


            this.dtgListar.Columns[1].HeaderText = "DNI";
            this.dtgListar.Columns[2].HeaderText = "Sexo";
            this.dtgListar.Columns[3].HeaderText = "Edad";
            this.dtgListar.Columns[4].HeaderText = "Vuelo";
            this.dtgListar.Columns[5].HeaderText = "Pasaje";
            this.dtgListar.Columns[6].HeaderText = "Lleva equipaje";
            //this.dtgListar.Columns[7].HeaderText = "Apellido";
            //this.dtgListar.Columns[8].HeaderText = "Nombre";
            //this.dtgListar.Columns[9].HeaderText = "Nombre";
        }

        private void MostrarControles(string categoriaSeleccionada)
        {
            if (categoriaSeleccionada == "Pasajero" || categoriaSeleccionada == "Avion" || categoriaSeleccionada == "Vuelo")
            {
                this.dtgListar.Visible = true;
                //this.pctbxImagenMenuPpal.Visible = false;
                this.btnModificar.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnAgregar.Visible = true;
                this.panelBotones.Visible = true;
                this.pctBxImagenPAraMostrar.Visible = true;
            }
            else if (categoriaSeleccionada == "Inicio" || categoriaSeleccionada == "Listados")
            {
                //this.pctbxImagenMenuPpal.Visible = true;
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

        private void ventaDePasajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje formularioVentaDePasaje = new FrmVentaPasaje();
            if (formularioVentaDePasaje.ShowDialog() == DialogResult.OK)
            {
                //Vuelo vueloSeleccionado = formularioBuscarVuelo.VueloSeleccionado;
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
                        // Obtener el pasajero seleccionado
                        pasajero = dtgListar.Rows[e.RowIndex].DataBoundItem as Pasajero;


                    }

                    break;
                case "Vuelo":

                    if (e.RowIndex >= 0 && e.RowIndex < dtgListar.Rows.Count)
                    {
                        // Obtener el vuelo seleccionado
                        vuelo = dtgListar.Rows[e.RowIndex].DataBoundItem as Vuelo;
                    }

                    break;
                case "Avion":
                    if (e.RowIndex >= 0 && e.RowIndex < dtgListar.Rows.Count)
                    {
                        // Obtener el avion seleccionado
                        avion = dtgListar.Rows[e.RowIndex].DataBoundItem as Avion;
                    }

                    break;

            }
        }
    }
}

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
    public partial class FrmAgregarAvion : Form
    {
        public FrmAgregarAvion()
        {
            InitializeComponent();
        }

        private void FormAgregarAvion_Load(object sender, EventArgs e)
        {
            this.cboAviones.DataSource = Enum.GetValues(typeof(EAvion));
            this.cboAviones.SelectedIndex = 0;
            this.domUpDownAsientos.Items.Add(200);
            this.domUpDownAsientos.Items.Add(150);
            this.domUpDownAsientos.Items.Add(100);
            this.domUpDownCantidadBanios.Items.Add(4);
            this.domUpDownCantidadBanios.Items.Add(2);
            this.domUpDownCapacidadMaxima.Items.Add(200.6);
            this.domUpDownCapacidadMaxima.Items.Add(150.5);
            this.domUpDownCapacidadMaxima.Items.Add(100.3);

            this.domUpDownAsientos.SelectedItem = 200;
            this.domUpDownCapacidadMaxima.SelectedItem = 100.3;
            this.domUpDownCantidadBanios.SelectedItem = 2;
            this.btnBoton1.Text = "Agregar";
        }



        private void txtMatriculaAvion_TextChanged(object sender, EventArgs e)
        {

            if (this.txtMatriculaAvion.Text.Length > 8)
            {
                MessageBox.Show("La matrícula no puede tener más de 8 caracteres.");
                this.txtMatriculaAvion.Clear();
            }
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnBoton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMatriculaAvion.Text))
            {
                MessageBox.Show("Debe ingresar una matrícula para el avión.");
                return; //cancela el agregarAvion
            }
            int cantidadAsientos = Convert.ToInt32(this.domUpDownAsientos.SelectedItem); //devuelve tipo objetc
            int cantidadBanios = Convert.ToInt32(this.domUpDownCantidadBanios.SelectedItem);//devuelve tipo object
            float capacidadMaximaBodega = Convert.ToSingle(this.domUpDownCapacidadMaxima.SelectedItem);
            string matricula = this.txtMatriculaAvion.Text;
            EAvion avionSeleccionado = (EAvion)this.cboAviones.SelectedValue;

            Empresa.AgregarAvion(avionSeleccionado, matricula, cantidadAsientos, cantidadBanios, capacidadMaximaBodega);
            MessageBox.Show("Avion agregado con exito.");
            this.DialogResult = DialogResult.OK;
        }
    }
}

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
    public partial class FrmCargarEquipaje : Form
    {
        Equipaje equipajeCargado;
        int cantidadValijas;
        float pesoValija1;
        float pesoValija2;
        bool equipajeMano;
        ETipoPasaje tipoPasaje;

        public FrmCargarEquipaje()
        {
            InitializeComponent();
            equipajeCargado = new Equipaje();
        }
        public Equipaje EquipajeCargado
        {
            get { return equipajeCargado; }
        }

        private void FrmCargarEquipaje_Load(object sender, EventArgs e)
        {
            this.lblErrorPeso.Visible = false;


            if (tipoPasaje == ETipoPasaje.Turista)
            {
                this.cboCantidadValijas.Items.Add(1);
                this.txtPesoValija2.Visible = false;
                this.pesoValija2 = 0;
            }
            else
            {
                cboCantidadValijas.Items.Add(1);
                cboCantidadValijas.Items.Add(2);
            }
        }

        private void cboCantidadValijas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cantidadValijas = int.Parse(cboCantidadValijas.Text);
            if (cantidadValijas == 2)
            {
                this.txtPesoValija2.Visible = true;
            }
        }

        private void radEquipajeManoSi_CheckedChanged(object sender, EventArgs e)
        {
            this.equipajeMano = true;
        }

        private void radEquipajeManoNo_CheckedChanged(object sender, EventArgs e)
        {
            this.equipajeMano = false;
        }

        private void btnCargaEquipaje_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

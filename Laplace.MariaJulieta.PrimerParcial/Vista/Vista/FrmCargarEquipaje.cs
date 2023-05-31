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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmCargarEquipaje : Form
    {
        Equipaje equipajeCargado;
        Pasaje pasajeAVender;
        Vuelo vueloSeleccionado;
        int cantidadValijas;
        float pesoValija1;
        float pesoValija2;
        bool equipajeMano;
        double precio;


        public FrmCargarEquipaje(Vuelo vueloRecibido)
        {
            InitializeComponent();
            this.equipajeCargado = new Equipaje();
            this.vueloSeleccionado = vueloRecibido;
            this.pasajeAVender = new Pasaje(ETipoPasaje.Turista, this.vueloSeleccionado);
        }
        public Equipaje EquipajeCargado
        {
            get { return equipajeCargado; }
        }
        public Pasaje PasajeAVender
        {
            get { return this.pasajeAVender; }
        }
        public bool EquipajeMano { get { return this.equipajeMano; } }

        private void FrmCargarEquipaje_Load(object sender, EventArgs e)
        {
            this.lblErrorPeso.Visible = false;
            this.cmbEnumTipoPasajes.DataSource = Enum.GetValues(typeof(ETipoPasaje));
            this.cmbEnumTipoPasajes.SelectedIndex = 0;
            this.cmbEnumTipoPasajes.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCantidadValijas.DropDownStyle = ComboBoxStyle.DropDownList;
            Color colorPersonalizado = ColorTranslator.FromHtml("#275248");
            this.BackColor = colorPersonalizado;

        }
        private void cmbEnumTipoPasajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pasajeAVender = new Pasaje((ETipoPasaje)this.cmbEnumTipoPasajes.SelectedValue, this.vueloSeleccionado);
            this.cmbCantidadValijas.Items.Clear();
            this.cmbCantidadValijas.Items.Add(1);
            ActualizarPrecio();
            MostrarPrecioNetoYPercioBruto();

            if (this.pasajeAVender.TipoDePasaje == ETipoPasaje.Premium)
            {
                this.cmbCantidadValijas.Items.Add(2);
                this.txtPesoValija2.Visible = true;
            }
            else
            {

                this.txtPesoValija2.Visible = false;

            }

            this.cmbCantidadValijas.SelectedIndex = 0;

        }



        private void cmbCantidadValijas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cantidadValijas = int.Parse(cmbCantidadValijas.Text);
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
        private void btnCargar_Click(object sender, EventArgs e)
        {



            if (this.pasajeAVender.TipoDePasaje == ETipoPasaje.Turista)
            {
                if (float.Parse(this.txtPesoValija1.Text) <= 25 && float.Parse(this.txtPesoValija1.Text) > 0)
                {
                    this.pesoValija1 = float.Parse(this.txtPesoValija1.Text);
                    this.pesoValija2 = 0;
                }
                else
                {
                    MessageBox.Show("Peso erroneo, la valija debe pesar menos de 25kg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPesoValija1.Text = "0";
                    this.txtPesoValija2.Text = "0";
                    return;

                }
            }
            else
            {
                if (this.cantidadValijas == 1)
                {
                    if (float.Parse(this.txtPesoValija1.Text) <= 21 && float.Parse(this.txtPesoValija1.Text) > 0)
                    {
                        pesoValija1 = float.Parse(txtPesoValija1.Text);
                        pesoValija2 = 0;

                    }
                    else
                    {

                        MessageBox.Show("Peso erroneo, la valija debe pesar menos de 21kg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPesoValija1.Text = "0";
                        this.txtPesoValija2.Text = "0";
                        return;

                    }
                }
                else
                {

                    if (float.Parse(this.txtPesoValija1.Text) <= 21 && float.Parse(this.txtPesoValija1.Text) > 0)
                    {
                        pesoValija1 = float.Parse(this.txtPesoValija1.Text);

                    }
                    else
                    {
                        MessageBox.Show("Peso erroneo, la valija debe pesar menos de 21kg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPesoValija1.Text = "0";
                        this.txtPesoValija2.Text = "0";
                        return;

                    }

                    if (float.Parse(this.txtPesoValija2.Text) <= 21 && float.Parse(this.txtPesoValija2.Text) > 0)
                    {
                        this.pesoValija2 = float.Parse(this.txtPesoValija2.Text);

                    }
                    else
                    {
                        MessageBox.Show("Peso erroneo, la valija debe pesar menos de 21kg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtPesoValija1.Text = "0";
                        this.txtPesoValija2.Text = "0";
                        return;

                    }
                }
            }

            this.equipajeCargado.PesoTotalValija = this.pesoValija1 + this.pesoValija2;
            this.equipajeCargado.CantidadValijas = this.cantidadValijas;
            this.DialogResult = DialogResult.OK;


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MostrarPrecioNetoYPercioBruto()
        {
            this.txtPrecioBruto.Text = this.precio.ToString("C2");
            this.txtPrecioNeto.Text = (this.precio * 1.21).ToString("C2");
        }
        private void ActualizarPrecio()
        {
            this.precio = this.pasajeAVender.PrecioPasajeBruto();
        }

    }
}

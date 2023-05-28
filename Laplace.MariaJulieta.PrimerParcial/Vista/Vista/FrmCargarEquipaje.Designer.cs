namespace Vista
{
    partial class FrmCargarEquipaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarEquipaje));
            pctboxImagen = new PictureBox();
            btnCancelar = new Button();
            btnCargaEquipaje = new Button();
            grpEquipajeDeMano = new GroupBox();
            radEquipajeManoNo = new RadioButton();
            radEquipajeManoSi = new RadioButton();
            lblLlevaEquipajeMano = new Label();
            grpValijas = new GroupBox();
            lblErrorPeso = new Label();
            txtPesoValija2 = new TextBox();
            cboCantidadValijas = new ComboBox();
            txtPesoValija1 = new TextBox();
            lblPesoValija1 = new Label();
            lblCantidadValijas = new Label();
            grpDatosPasaje = new GroupBox();
            cboEnumTipoPasajes = new ComboBox();
            txtPrecioNeto = new TextBox();
            label1 = new Label();
            lblMensajeError = new Label();
            lblPrecio = new Label();
            lblTipoPasaje = new Label();
            txtPrecioBruto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pctboxImagen).BeginInit();
            grpEquipajeDeMano.SuspendLayout();
            grpValijas.SuspendLayout();
            grpDatosPasaje.SuspendLayout();
            SuspendLayout();
            // 
            // pctboxImagen
            // 
            pctboxImagen.Image = (Image)resources.GetObject("pctboxImagen.Image");
            pctboxImagen.Location = new Point(-1, 0);
            pctboxImagen.Name = "pctboxImagen";
            pctboxImagen.Size = new Size(1226, 618);
            pctboxImagen.TabIndex = 0;
            pctboxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(665, 441);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCargaEquipaje
            // 
            btnCargaEquipaje.Location = new Point(492, 441);
            btnCargaEquipaje.Name = "btnCargaEquipaje";
            btnCargaEquipaje.Size = new Size(75, 23);
            btnCargaEquipaje.TabIndex = 6;
            btnCargaEquipaje.Text = "Cargar Equipaje";
            btnCargaEquipaje.UseVisualStyleBackColor = true;
            btnCargaEquipaje.Click += btnCargaEquipaje_Click;
            // 
            // grpEquipajeDeMano
            // 
            grpEquipajeDeMano.Controls.Add(radEquipajeManoNo);
            grpEquipajeDeMano.Controls.Add(radEquipajeManoSi);
            grpEquipajeDeMano.Controls.Add(lblLlevaEquipajeMano);
            grpEquipajeDeMano.Location = new Point(559, 230);
            grpEquipajeDeMano.Name = "grpEquipajeDeMano";
            grpEquipajeDeMano.Size = new Size(488, 84);
            grpEquipajeDeMano.TabIndex = 5;
            grpEquipajeDeMano.TabStop = false;
            grpEquipajeDeMano.Text = "Equipaje de mano";
            // 
            // radEquipajeManoNo
            // 
            radEquipajeManoNo.AutoSize = true;
            radEquipajeManoNo.Location = new Point(298, 45);
            radEquipajeManoNo.Name = "radEquipajeManoNo";
            radEquipajeManoNo.Size = new Size(41, 19);
            radEquipajeManoNo.TabIndex = 2;
            radEquipajeManoNo.TabStop = true;
            radEquipajeManoNo.Text = "No";
            radEquipajeManoNo.UseVisualStyleBackColor = true;
            radEquipajeManoNo.CheckedChanged += radEquipajeManoNo_CheckedChanged;
            // 
            // radEquipajeManoSi
            // 
            radEquipajeManoSi.AutoSize = true;
            radEquipajeManoSi.Location = new Point(233, 45);
            radEquipajeManoSi.Name = "radEquipajeManoSi";
            radEquipajeManoSi.Size = new Size(34, 19);
            radEquipajeManoSi.TabIndex = 1;
            radEquipajeManoSi.TabStop = true;
            radEquipajeManoSi.Text = "Si";
            radEquipajeManoSi.UseVisualStyleBackColor = true;
            radEquipajeManoSi.CheckedChanged += radEquipajeManoSi_CheckedChanged;
            // 
            // lblLlevaEquipajeMano
            // 
            lblLlevaEquipajeMano.AutoSize = true;
            lblLlevaEquipajeMano.Location = new Point(30, 47);
            lblLlevaEquipajeMano.Name = "lblLlevaEquipajeMano";
            lblLlevaEquipajeMano.Size = new Size(132, 15);
            lblLlevaEquipajeMano.TabIndex = 0;
            lblLlevaEquipajeMano.Text = "Lleva equipaje de mano";
            // 
            // grpValijas
            // 
            grpValijas.Controls.Add(lblErrorPeso);
            grpValijas.Controls.Add(txtPesoValija2);
            grpValijas.Controls.Add(cboCantidadValijas);
            grpValijas.Controls.Add(txtPesoValija1);
            grpValijas.Controls.Add(lblPesoValija1);
            grpValijas.Controls.Add(lblCantidadValijas);
            grpValijas.Location = new Point(44, 225);
            grpValijas.Name = "grpValijas";
            grpValijas.Size = new Size(488, 170);
            grpValijas.TabIndex = 4;
            grpValijas.TabStop = false;
            grpValijas.Text = "Valijas";
            // 
            // lblErrorPeso
            // 
            lblErrorPeso.AutoSize = true;
            lblErrorPeso.Location = new Point(89, 134);
            lblErrorPeso.Name = "lblErrorPeso";
            lblErrorPeso.Size = new Size(76, 15);
            lblErrorPeso.TabIndex = 5;
            lblErrorPeso.Text = "MensajeError";
            // 
            // txtPesoValija2
            // 
            txtPesoValija2.Location = new Point(270, 94);
            txtPesoValija2.Name = "txtPesoValija2";
            txtPesoValija2.PlaceholderText = "Ingrese peso de valija";
            txtPesoValija2.Size = new Size(159, 23);
            txtPesoValija2.TabIndex = 4;
            // 
            // cboCantidadValijas
            // 
            cboCantidadValijas.FormattingEnabled = true;
            cboCantidadValijas.Location = new Point(270, 21);
            cboCantidadValijas.Name = "cboCantidadValijas";
            cboCantidadValijas.Size = new Size(121, 23);
            cboCantidadValijas.TabIndex = 3;
            cboCantidadValijas.SelectedIndexChanged += cboCantidadValijas_SelectedIndexChanged;
            // 
            // txtPesoValija1
            // 
            txtPesoValija1.Location = new Point(270, 66);
            txtPesoValija1.Name = "txtPesoValija1";
            txtPesoValija1.PlaceholderText = "Ingrese peso de valija";
            txtPesoValija1.Size = new Size(159, 23);
            txtPesoValija1.TabIndex = 2;
            // 
            // lblPesoValija1
            // 
            lblPesoValija1.AutoSize = true;
            lblPesoValija1.Location = new Point(6, 71);
            lblPesoValija1.Name = "lblPesoValija1";
            lblPesoValija1.Size = new Size(72, 15);
            lblPesoValija1.TabIndex = 1;
            lblPesoValija1.Text = "Peso valija/s";
            // 
            // lblCantidadValijas
            // 
            lblCantidadValijas.AutoSize = true;
            lblCantidadValijas.Location = new Point(6, 28);
            lblCantidadValijas.Name = "lblCantidadValijas";
            lblCantidadValijas.Size = new Size(184, 15);
            lblCantidadValijas.TabIndex = 0;
            lblCantidadValijas.Text = "Cantidad de valijas por despachar";
            // 
            // grpDatosPasaje
            // 
            grpDatosPasaje.Controls.Add(cboEnumTipoPasajes);
            grpDatosPasaje.Controls.Add(txtPrecioNeto);
            grpDatosPasaje.Controls.Add(label1);
            grpDatosPasaje.Controls.Add(txtPrecioBruto);
            grpDatosPasaje.Controls.Add(lblMensajeError);
            grpDatosPasaje.Controls.Add(lblPrecio);
            grpDatosPasaje.Controls.Add(lblTipoPasaje);
            grpDatosPasaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatosPasaje.Location = new Point(44, 43);
            grpDatosPasaje.Name = "grpDatosPasaje";
            grpDatosPasaje.Size = new Size(865, 170);
            grpDatosPasaje.TabIndex = 8;
            grpDatosPasaje.TabStop = false;
            grpDatosPasaje.Text = "Pasaje";
            // 
            // cboEnumTipoPasajes
            // 
            cboEnumTipoPasajes.FormattingEnabled = true;
            cboEnumTipoPasajes.Location = new Point(131, 54);
            cboEnumTipoPasajes.Name = "cboEnumTipoPasajes";
            cboEnumTipoPasajes.Size = new Size(121, 25);
            cboEnumTipoPasajes.TabIndex = 33;
            // 
            // txtPrecioNeto
            // 
            txtPrecioNeto.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPrecioNeto.Location = new Point(663, 117);
            txtPrecioNeto.Name = "txtPrecioNeto";
            txtPrecioNeto.Size = new Size(162, 22);
            txtPrecioNeto.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 117);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 31;
            label1.Text = "Precio Neto";
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.Location = new Point(6, 132);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(360, 17);
            lblMensajeError.TabIndex = 24;
            lblMensajeError.Text = "La cantidad de pasajes seleccionados no estan disponibles";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(574, 60);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(83, 17);
            lblPrecio.TabIndex = 23;
            lblPrecio.Text = "Precio Bruto ";
            // 
            // lblTipoPasaje
            // 
            lblTipoPasaje.AutoSize = true;
            lblTipoPasaje.ImeMode = ImeMode.NoControl;
            lblTipoPasaje.Location = new Point(6, 54);
            lblTipoPasaje.Name = "lblTipoPasaje";
            lblTipoPasaje.Size = new Size(106, 17);
            lblTipoPasaje.TabIndex = 18;
            lblTipoPasaje.Text = "Clase del pasaje";
            // 
            // txtPrecioBruto
            // 
            txtPrecioBruto.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPrecioBruto.Location = new Point(663, 57);
            txtPrecioBruto.Name = "txtPrecioBruto";
            txtPrecioBruto.Size = new Size(162, 22);
            txtPrecioBruto.TabIndex = 30;
            // 
            // FrmCargarEquipaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 617);
            Controls.Add(grpDatosPasaje);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargaEquipaje);
            Controls.Add(grpEquipajeDeMano);
            Controls.Add(grpValijas);
            Controls.Add(pctboxImagen);
            Name = "FrmCargarEquipaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Equipaje";
            Load += FrmCargarEquipaje_Load;
            ((System.ComponentModel.ISupportInitialize)pctboxImagen).EndInit();
            grpEquipajeDeMano.ResumeLayout(false);
            grpEquipajeDeMano.PerformLayout();
            grpValijas.ResumeLayout(false);
            grpValijas.PerformLayout();
            grpDatosPasaje.ResumeLayout(false);
            grpDatosPasaje.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctboxImagen;
        private Button btnCancelar;
        private Button btnCargaEquipaje;
        private GroupBox grpEquipajeDeMano;
        private RadioButton radEquipajeManoNo;
        private RadioButton radEquipajeManoSi;
        private Label lblLlevaEquipajeMano;
        private GroupBox grpValijas;
        private Label lblErrorPeso;
        private TextBox txtPesoValija2;
        private ComboBox cboCantidadValijas;
        private TextBox txtPesoValija1;
        private Label lblPesoValija1;
        private Label lblCantidadValijas;
        private GroupBox grpDatosPasaje;
        private ComboBox cboEnumTipoPasajes;
        private TextBox txtPrecioNeto;
        private Label label1;
        private TextBox txtPrecioBruto;
        private Label lblMensajeError;
        private Label lblPrecio;
        private Label lblTipoPasaje;
    }
}
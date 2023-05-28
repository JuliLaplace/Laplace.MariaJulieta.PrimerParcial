namespace Vista
{
    partial class FrmVentaPasaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaPasaje));
            btnBuscarVuelo = new Button();
            btnCargarPasajero = new Button();
            btnCargarEquipaje = new Button();
            btnFactura = new Button();
            btnCargarOtroPasajero = new Button();
            btnVender = new Button();
            btnCancelar = new Button();
            pctbxImagenFondo = new PictureBox();
            dtgListaPasajesPorVender = new DataGridView();
            comboBox1 = new ComboBox();
            btnSeleccionTipoPasaje = new Button();
            rtbDatosVuelo = new RichTextBox();
            rtbDatosPasajero = new RichTextBox();
            rtbDatosEquipaje = new RichTextBox();
            rtbDatosFactura = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.ImageAlign = ContentAlignment.TopCenter;
            btnBuscarVuelo.Location = new Point(90, 64);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(163, 64);
            btnBuscarVuelo.TabIndex = 0;
            btnBuscarVuelo.Text = "Buscar Vuelo";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // btnCargarPasajero
            // 
            btnCargarPasajero.Location = new Point(525, 80);
            btnCargarPasajero.Name = "btnCargarPasajero";
            btnCargarPasajero.Size = new Size(132, 48);
            btnCargarPasajero.TabIndex = 1;
            btnCargarPasajero.Text = "Cargar Pasajero";
            btnCargarPasajero.UseVisualStyleBackColor = true;
            btnCargarPasajero.Click += btnCargarPasajero_Click;
            // 
            // btnCargarEquipaje
            // 
            btnCargarEquipaje.Location = new Point(755, 84);
            btnCargarEquipaje.Name = "btnCargarEquipaje";
            btnCargarEquipaje.Size = new Size(139, 44);
            btnCargarEquipaje.TabIndex = 2;
            btnCargarEquipaje.Text = "Cargar Equipaje";
            btnCargarEquipaje.UseVisualStyleBackColor = true;
            btnCargarEquipaje.Click += btnCargarEquipaje_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(1025, 84);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(127, 44);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Realizar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnCargarOtroPasajero
            // 
            btnCargarOtroPasajero.Location = new Point(28, 634);
            btnCargarOtroPasajero.Name = "btnCargarOtroPasajero";
            btnCargarOtroPasajero.Size = new Size(138, 57);
            btnCargarOtroPasajero.TabIndex = 8;
            btnCargarOtroPasajero.Text = "Cargar Otro Pasajero";
            btnCargarOtroPasajero.UseVisualStyleBackColor = true;
            btnCargarOtroPasajero.Click += btnCargarOtroPasajero_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(836, 634);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(128, 53);
            btnVender.TabIndex = 9;
            btnVender.Text = "Realizar Venta";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1079, 636);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 53);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar venta";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pctbxImagenFondo
            // 
            pctbxImagenFondo.Image = (Image)resources.GetObject("pctbxImagenFondo.Image");
            pctbxImagenFondo.Location = new Point(1, 0);
            pctbxImagenFondo.Name = "pctbxImagenFondo";
            pctbxImagenFondo.Size = new Size(1239, 644);
            pctbxImagenFondo.TabIndex = 11;
            pctbxImagenFondo.TabStop = false;
            // 
            // dtgListaPasajesPorVender
            // 
            dtgListaPasajesPorVender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaPasajesPorVender.Location = new Point(35, 453);
            dtgListaPasajesPorVender.Name = "dtgListaPasajesPorVender";
            dtgListaPasajesPorVender.RowTemplate.Height = 25;
            dtgListaPasajesPorVender.Size = new Size(1154, 143);
            dtgListaPasajesPorVender.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(300, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 17;
            // 
            // btnSeleccionTipoPasaje
            // 
            btnSeleccionTipoPasaje.Location = new Point(309, 78);
            btnSeleccionTipoPasaje.Name = "btnSeleccionTipoPasaje";
            btnSeleccionTipoPasaje.Size = new Size(103, 52);
            btnSeleccionTipoPasaje.TabIndex = 18;
            btnSeleccionTipoPasaje.Text = "Cargar Tipo de pasaje";
            btnSeleccionTipoPasaje.UseVisualStyleBackColor = true;
            // 
            // rtbDatosVuelo
            // 
            rtbDatosVuelo.Location = new Point(76, 206);
            rtbDatosVuelo.Name = "rtbDatosVuelo";
            rtbDatosVuelo.Size = new Size(201, 198);
            rtbDatosVuelo.TabIndex = 19;
            rtbDatosVuelo.Text = "";
            // 
            // rtbDatosPasajero
            // 
            rtbDatosPasajero.Location = new Point(487, 206);
            rtbDatosPasajero.Name = "rtbDatosPasajero";
            rtbDatosPasajero.Size = new Size(199, 198);
            rtbDatosPasajero.TabIndex = 20;
            rtbDatosPasajero.Text = "";
            // 
            // rtbDatosEquipaje
            // 
            rtbDatosEquipaje.Location = new Point(733, 206);
            rtbDatosEquipaje.Name = "rtbDatosEquipaje";
            rtbDatosEquipaje.Size = new Size(194, 198);
            rtbDatosEquipaje.TabIndex = 21;
            rtbDatosEquipaje.Text = "";
            // 
            // rtbDatosFactura
            // 
            rtbDatosFactura.Location = new Point(989, 206);
            rtbDatosFactura.Name = "rtbDatosFactura";
            rtbDatosFactura.Size = new Size(214, 198);
            rtbDatosFactura.TabIndex = 22;
            rtbDatosFactura.Text = "";
            // 
            // FrmVentaPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 692);
            Controls.Add(rtbDatosFactura);
            Controls.Add(rtbDatosEquipaje);
            Controls.Add(rtbDatosPasajero);
            Controls.Add(rtbDatosVuelo);
            Controls.Add(btnSeleccionTipoPasaje);
            Controls.Add(comboBox1);
            Controls.Add(dtgListaPasajesPorVender);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(btnCargarOtroPasajero);
            Controls.Add(btnFactura);
            Controls.Add(btnCargarEquipaje);
            Controls.Add(btnCargarPasajero);
            Controls.Add(btnBuscarVuelo);
            Controls.Add(pctbxImagenFondo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVentaPasaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta pasaje";
            ((System.ComponentModel.ISupportInitialize)pctbxImagenFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarVuelo;
        private Button btnCargarPasajero;
        private Button btnCargarEquipaje;
        private Button btnFactura;
        private Button btnCargarOtroPasajero;
        private Button btnVender;
        private Button btnCancelar;
        private PictureBox pctbxImagenFondo;
        private DataGridView dtgListaPasajesPorVender;
        private ComboBox comboBox1;
        private Button btnSeleccionTipoPasaje;
        private RichTextBox rtbDatosVuelo;
        private RichTextBox rtbDatosPasajero;
        private RichTextBox rtbDatosEquipaje;
        private RichTextBox rtbDatosFactura;
    }
}
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
            rtbDatosVuelo = new RichTextBox();
            rtbDatosPasajero = new RichTextBox();
            rtbDatosEquipaje = new RichTextBox();
            rtbDatosFactura = new RichTextBox();
            btnAgregarPasajero = new Button();
            btnEliminarPasajero = new Button();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.ImageAlign = ContentAlignment.TopCenter;
            btnBuscarVuelo.Location = new Point(109, 88);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(163, 64);
            btnBuscarVuelo.TabIndex = 0;
            btnBuscarVuelo.Text = "Buscar Vuelo";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // btnCargarPasajero
            // 
            btnCargarPasajero.Location = new Point(416, 88);
            btnCargarPasajero.Name = "btnCargarPasajero";
            btnCargarPasajero.Size = new Size(132, 48);
            btnCargarPasajero.TabIndex = 1;
            btnCargarPasajero.Text = "Cargar Pasajero";
            btnCargarPasajero.UseVisualStyleBackColor = true;
            btnCargarPasajero.Click += btnCargarPasajero_Click;
            // 
            // btnCargarEquipaje
            // 
            btnCargarEquipaje.Location = new Point(695, 98);
            btnCargarEquipaje.Name = "btnCargarEquipaje";
            btnCargarEquipaje.Size = new Size(139, 44);
            btnCargarEquipaje.TabIndex = 2;
            btnCargarEquipaje.Text = "Cargar Equipaje";
            btnCargarEquipaje.UseVisualStyleBackColor = true;
            btnCargarEquipaje.Click += btnCargarEquipaje_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(967, 98);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(127, 44);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Realizar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnCargarOtroPasajero
            // 
            btnCargarOtroPasajero.Location = new Point(285, 623);
            btnCargarOtroPasajero.Name = "btnCargarOtroPasajero";
            btnCargarOtroPasajero.Size = new Size(138, 57);
            btnCargarOtroPasajero.TabIndex = 8;
            btnCargarOtroPasajero.Text = "Cargar Otro Pasajero";
            btnCargarOtroPasajero.UseVisualStyleBackColor = true;
            btnCargarOtroPasajero.Click += btnCargarOtroPasajero_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(833, 623);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(128, 53);
            btnVender.TabIndex = 9;
            btnVender.Text = "Realizar Venta";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1065, 625);
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
            pctbxImagenFondo.Location = new Point(1, -1);
            pctbxImagenFondo.Name = "pctbxImagenFondo";
            pctbxImagenFondo.Size = new Size(1238, 692);
            pctbxImagenFondo.TabIndex = 11;
            pctbxImagenFondo.TabStop = false;
            // 
            // dtgListaPasajesPorVender
            // 
            dtgListaPasajesPorVender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaPasajesPorVender.Location = new Point(35, 453);
            dtgListaPasajesPorVender.Name = "dtgListaPasajesPorVender";
            dtgListaPasajesPorVender.ReadOnly = true;
            dtgListaPasajesPorVender.RowTemplate.Height = 25;
            dtgListaPasajesPorVender.Size = new Size(1154, 143);
            dtgListaPasajesPorVender.TabIndex = 12;
            dtgListaPasajesPorVender.CellClick += dtgListaPasajesPorVender_CellClick;
            // 
            // rtbDatosVuelo
            // 
            rtbDatosVuelo.Location = new Point(92, 206);
            rtbDatosVuelo.Name = "rtbDatosVuelo";
            rtbDatosVuelo.Size = new Size(201, 198);
            rtbDatosVuelo.TabIndex = 19;
            rtbDatosVuelo.Text = "";
            // 
            // rtbDatosPasajero
            // 
            rtbDatosPasajero.Location = new Point(383, 206);
            rtbDatosPasajero.Name = "rtbDatosPasajero";
            rtbDatosPasajero.Size = new Size(199, 198);
            rtbDatosPasajero.TabIndex = 20;
            rtbDatosPasajero.Text = "";
            // 
            // rtbDatosEquipaje
            // 
            rtbDatosEquipaje.Location = new Point(669, 206);
            rtbDatosEquipaje.Name = "rtbDatosEquipaje";
            rtbDatosEquipaje.Size = new Size(194, 198);
            rtbDatosEquipaje.TabIndex = 21;
            rtbDatosEquipaje.Text = "";
            // 
            // rtbDatosFactura
            // 
            rtbDatosFactura.Location = new Point(925, 206);
            rtbDatosFactura.Name = "rtbDatosFactura";
            rtbDatosFactura.Size = new Size(214, 198);
            rtbDatosFactura.TabIndex = 22;
            rtbDatosFactura.Text = "";
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(35, 619);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(138, 57);
            btnAgregarPasajero.TabIndex = 23;
            btnAgregarPasajero.Text = "Agregar Pasajero";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.Location = new Point(549, 621);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(146, 59);
            btnEliminarPasajero.TabIndex = 24;
            btnEliminarPasajero.Text = "Eliminar Pasajero";
            btnEliminarPasajero.UseVisualStyleBackColor = true;
            btnEliminarPasajero.Click += btnEliminarPasajero_Click;
            // 
            // FrmVentaPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 692);
            Controls.Add(btnEliminarPasajero);
            Controls.Add(btnAgregarPasajero);
            Controls.Add(rtbDatosFactura);
            Controls.Add(rtbDatosEquipaje);
            Controls.Add(rtbDatosPasajero);
            Controls.Add(rtbDatosVuelo);
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
            Load += FrmVentaPasaje_Load;
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
        private RichTextBox rtbDatosVuelo;
        private RichTextBox rtbDatosPasajero;
        private RichTextBox rtbDatosEquipaje;
        private RichTextBox rtbDatosFactura;
        private Button btnAgregarPasajero;
        private Button btnEliminarPasajero;
    }
}
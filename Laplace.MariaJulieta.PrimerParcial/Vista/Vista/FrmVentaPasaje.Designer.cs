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
            btnBuscarPasajero = new Button();
            btnEmitirPasaje = new Button();
            btnFactura = new Button();
            btnVender = new Button();
            btnCancelar = new Button();
            dtgListaPasajesPorVender = new DataGridView();
            rtbDatosVuelo = new RichTextBox();
            rtbDatosPasajero = new RichTextBox();
            rtbDatosEquipaje = new RichTextBox();
            rtbDatosFactura = new RichTextBox();
            btnAgregarPasajero = new Button();
            btnEliminarPasajero = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.ImageAlign = ContentAlignment.TopCenter;
            btnBuscarVuelo.Location = new Point(92, 47);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(163, 64);
            btnBuscarVuelo.TabIndex = 0;
            btnBuscarVuelo.Text = "Buscar Vuelo";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // btnBuscarPasajero
            // 
            btnBuscarPasajero.Location = new Point(401, 47);
            btnBuscarPasajero.Name = "btnBuscarPasajero";
            btnBuscarPasajero.Size = new Size(163, 64);
            btnBuscarPasajero.TabIndex = 1;
            btnBuscarPasajero.Text = "Buscar Pasajero";
            btnBuscarPasajero.UseVisualStyleBackColor = true;
            btnBuscarPasajero.Click += btnBuscarPasajero_Click;
            // 
            // btnEmitirPasaje
            // 
            btnEmitirPasaje.Location = new Point(701, 47);
            btnEmitirPasaje.Name = "btnEmitirPasaje";
            btnEmitirPasaje.Size = new Size(163, 64);
            btnEmitirPasaje.TabIndex = 2;
            btnEmitirPasaje.Text = "Emitir Pasaje";
            btnEmitirPasaje.UseVisualStyleBackColor = true;
            btnEmitirPasaje.Click += btnEmitirPasaje_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(957, 47);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(163, 64);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Realizar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(515, 612);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(163, 64);
            btnVender.TabIndex = 9;
            btnVender.Text = "Realizar Venta";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(841, 612);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 64);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar venta";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            rtbDatosVuelo.Location = new Point(66, 146);
            rtbDatosVuelo.Name = "rtbDatosVuelo";
            rtbDatosVuelo.Size = new Size(214, 198);
            rtbDatosVuelo.TabIndex = 19;
            rtbDatosVuelo.Text = "";
            // 
            // rtbDatosPasajero
            // 
            rtbDatosPasajero.Location = new Point(377, 146);
            rtbDatosPasajero.Name = "rtbDatosPasajero";
            rtbDatosPasajero.Size = new Size(214, 198);
            rtbDatosPasajero.TabIndex = 20;
            rtbDatosPasajero.Text = "";
            // 
            // rtbDatosEquipaje
            // 
            rtbDatosEquipaje.Location = new Point(672, 146);
            rtbDatosEquipaje.Name = "rtbDatosEquipaje";
            rtbDatosEquipaje.Size = new Size(214, 198);
            rtbDatosEquipaje.TabIndex = 21;
            rtbDatosEquipaje.Text = "";
            // 
            // rtbDatosFactura
            // 
            rtbDatosFactura.Location = new Point(942, 146);
            rtbDatosFactura.Name = "rtbDatosFactura";
            rtbDatosFactura.Size = new Size(214, 198);
            rtbDatosFactura.TabIndex = 22;
            rtbDatosFactura.Text = "";
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(532, 366);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(163, 64);
            btnAgregarPasajero.TabIndex = 23;
            btnAgregarPasajero.Text = "Agregar Pasajero";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.Location = new Point(185, 612);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(163, 64);
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
            Controls.Add(btnFactura);
            Controls.Add(btnEmitirPasaje);
            Controls.Add(btnBuscarPasajero);
            Controls.Add(btnBuscarVuelo);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVentaPasaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta pasaje";
            Load += FrmVentaPasaje_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarVuelo;
        private Button btnBuscarPasajero;
        private Button btnEmitirPasaje;
        private Button btnFactura;
        private Button btnVender;
        private Button btnCancelar;
        private DataGridView dtgListaPasajesPorVender;
        private RichTextBox rtbDatosVuelo;
        private RichTextBox rtbDatosPasajero;
        private RichTextBox rtbDatosEquipaje;
        private RichTextBox rtbDatosFactura;
        private Button btnAgregarPasajero;
        private Button btnEliminarPasajero;
    }
}
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
            lstDatosVueloSeleccionado = new ListBox();
            lstDatosPasajero = new ListBox();
            lstDatosEquipaje = new ListBox();
            lstFactura = new ListBox();
            btnCargarOtroPasajero = new Button();
            btnVender = new Button();
            btnCancelar = new Button();
            pctbxImagenFondo = new PictureBox();
            dtgListaPasajesPorVender = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaPasajesPorVender).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.ImageAlign = ContentAlignment.TopCenter;
            btnBuscarVuelo.Location = new Point(85, 25);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(163, 64);
            btnBuscarVuelo.TabIndex = 0;
            btnBuscarVuelo.Text = "Buscar Vuelo";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // btnCargarPasajero
            // 
            btnCargarPasajero.Location = new Point(432, 23);
            btnCargarPasajero.Name = "btnCargarPasajero";
            btnCargarPasajero.Size = new Size(125, 48);
            btnCargarPasajero.TabIndex = 1;
            btnCargarPasajero.Text = "Cargar Pasajero";
            btnCargarPasajero.UseVisualStyleBackColor = true;
            btnCargarPasajero.Click += btnCargarPasajero_Click;
            // 
            // btnCargarEquipaje
            // 
            btnCargarEquipaje.Location = new Point(711, 23);
            btnCargarEquipaje.Name = "btnCargarEquipaje";
            btnCargarEquipaje.Size = new Size(118, 43);
            btnCargarEquipaje.TabIndex = 2;
            btnCargarEquipaje.Text = "Cargar Equipaje";
            btnCargarEquipaje.UseVisualStyleBackColor = true;
            btnCargarEquipaje.Click += btnCargarEquipaje_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(999, 25);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(127, 44);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Realizar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // lstDatosVueloSeleccionado
            // 
            lstDatosVueloSeleccionado.FormattingEnabled = true;
            lstDatosVueloSeleccionado.ItemHeight = 17;
            lstDatosVueloSeleccionado.Location = new Point(85, 108);
            lstDatosVueloSeleccionado.Name = "lstDatosVueloSeleccionado";
            lstDatosVueloSeleccionado.Size = new Size(207, 310);
            lstDatosVueloSeleccionado.TabIndex = 4;
            // 
            // lstDatosPasajero
            // 
            lstDatosPasajero.FormattingEnabled = true;
            lstDatosPasajero.ItemHeight = 17;
            lstDatosPasajero.Location = new Point(395, 108);
            lstDatosPasajero.Name = "lstDatosPasajero";
            lstDatosPasajero.Size = new Size(205, 310);
            lstDatosPasajero.TabIndex = 5;
            // 
            // lstDatosEquipaje
            // 
            lstDatosEquipaje.FormattingEnabled = true;
            lstDatosEquipaje.ItemHeight = 17;
            lstDatosEquipaje.Location = new Point(677, 108);
            lstDatosEquipaje.Name = "lstDatosEquipaje";
            lstDatosEquipaje.Size = new Size(192, 310);
            lstDatosEquipaje.TabIndex = 6;
            // 
            // lstFactura
            // 
            lstFactura.FormattingEnabled = true;
            lstFactura.ItemHeight = 17;
            lstFactura.Location = new Point(974, 108);
            lstFactura.Name = "lstFactura";
            lstFactura.Size = new Size(179, 310);
            lstFactura.TabIndex = 7;
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
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1079, 636);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 53);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar venta";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pctbxImagenFondo
            // 
            pctbxImagenFondo.Image = (Image)resources.GetObject("pctbxImagenFondo.Image");
            pctbxImagenFondo.Location = new Point(1, -2);
            pctbxImagenFondo.Name = "pctbxImagenFondo";
            pctbxImagenFondo.Size = new Size(1232, 693);
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
            // FrmVentaPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 692);
            Controls.Add(dtgListaPasajesPorVender);
            Controls.Add(btnCancelar);
            Controls.Add(btnVender);
            Controls.Add(btnCargarOtroPasajero);
            Controls.Add(lstFactura);
            Controls.Add(lstDatosEquipaje);
            Controls.Add(lstDatosPasajero);
            Controls.Add(lstDatosVueloSeleccionado);
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
        private ListBox lstDatosVueloSeleccionado;
        private ListBox lstDatosPasajero;
        private ListBox lstDatosEquipaje;
        private ListBox lstFactura;
        private Button btnCargarOtroPasajero;
        private Button btnVender;
        private Button btnCancelar;
        private PictureBox pctbxImagenFondo;
        private DataGridView dtgListaPasajesPorVender;
    }
}
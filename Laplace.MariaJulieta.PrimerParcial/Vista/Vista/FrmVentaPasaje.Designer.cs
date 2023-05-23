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
            SuspendLayout();
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.Location = new Point(58, 57);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(122, 34);
            btnBuscarVuelo.TabIndex = 0;
            btnBuscarVuelo.Text = "Buscar Vuelo";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // btnCargarPasajero
            // 
            btnCargarPasajero.Location = new Point(301, 54);
            btnCargarPasajero.Name = "btnCargarPasajero";
            btnCargarPasajero.Size = new Size(125, 42);
            btnCargarPasajero.TabIndex = 1;
            btnCargarPasajero.Text = "Cargar Pasajero";
            btnCargarPasajero.UseVisualStyleBackColor = true;
            btnCargarPasajero.Click += btnCargarPasajero_Click;
            // 
            // btnCargarEquipaje
            // 
            btnCargarEquipaje.Location = new Point(592, 58);
            btnCargarEquipaje.Name = "btnCargarEquipaje";
            btnCargarEquipaje.Size = new Size(118, 38);
            btnCargarEquipaje.TabIndex = 2;
            btnCargarEquipaje.Text = "Cargar Equipaje";
            btnCargarEquipaje.UseVisualStyleBackColor = true;
            btnCargarEquipaje.Click += btnCargarEquipaje_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(894, 58);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(127, 39);
            btnFactura.TabIndex = 3;
            btnFactura.Text = "Realizar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // lstDatosVueloSeleccionado
            // 
            lstDatosVueloSeleccionado.FormattingEnabled = true;
            lstDatosVueloSeleccionado.ItemHeight = 15;
            lstDatosVueloSeleccionado.Location = new Point(30, 128);
            lstDatosVueloSeleccionado.Name = "lstDatosVueloSeleccionado";
            lstDatosVueloSeleccionado.Size = new Size(181, 259);
            lstDatosVueloSeleccionado.TabIndex = 4;
            // 
            // lstDatosPasajero
            // 
            lstDatosPasajero.FormattingEnabled = true;
            lstDatosPasajero.ItemHeight = 15;
            lstDatosPasajero.Location = new Point(280, 128);
            lstDatosPasajero.Name = "lstDatosPasajero";
            lstDatosPasajero.Size = new Size(193, 259);
            lstDatosPasajero.TabIndex = 5;
            // 
            // lstDatosEquipaje
            // 
            lstDatosEquipaje.FormattingEnabled = true;
            lstDatosEquipaje.ItemHeight = 15;
            lstDatosEquipaje.Location = new Point(570, 128);
            lstDatosEquipaje.Name = "lstDatosEquipaje";
            lstDatosEquipaje.Size = new Size(175, 259);
            lstDatosEquipaje.TabIndex = 6;
            // 
            // lstFactura
            // 
            lstFactura.FormattingEnabled = true;
            lstFactura.ItemHeight = 15;
            lstFactura.Location = new Point(872, 128);
            lstFactura.Name = "lstFactura";
            lstFactura.Size = new Size(179, 274);
            lstFactura.TabIndex = 7;
            // 
            // btnCargarOtroPasajero
            // 
            btnCargarOtroPasajero.Location = new Point(30, 527);
            btnCargarOtroPasajero.Name = "btnCargarOtroPasajero";
            btnCargarOtroPasajero.Size = new Size(138, 50);
            btnCargarOtroPasajero.TabIndex = 8;
            btnCargarOtroPasajero.Text = "Cargar Otro Pasajero";
            btnCargarOtroPasajero.UseVisualStyleBackColor = true;
            btnCargarOtroPasajero.Click += btnCargarOtroPasajero_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(838, 530);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(128, 47);
            btnVender.TabIndex = 9;
            btnVender.Text = "Realizar Venta";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1080, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 47);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar venta";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmVentaPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 609);
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
            Name = "FrmVentaPasaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentaPasaje";
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
    }
}
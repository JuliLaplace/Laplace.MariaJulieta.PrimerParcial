namespace Vista
{
    partial class FrmBusquedaVuelo
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
            gpbDatosFiltroViaje = new GroupBox();
            chkbOfreceWifi = new CheckBox();
            chkbOfreceComida = new CheckBox();
            lblSeleccionWifi = new Label();
            lblServicioDeComida = new Label();
            calendarSeleccionFechaDeViaje = new MonthCalendar();
            lblFechaSalida = new Label();
            cboSeleccionDestino = new ComboBox();
            lblDestino = new Label();
            cboSeleccionOrigen = new ComboBox();
            lblOrigen = new Label();
            cboSeleccionTipoDeViaje = new ComboBox();
            lblTipoDeVuelo = new Label();
            dtgListaVuelosFiltrados = new DataGridView();
            btnBuscarVuelo = new Button();
            lblMensajeError = new Label();
            btnCargarVueloSeleccionado = new Button();
            btnLimpiar = new Button();
            gpbDatosFiltroViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaVuelosFiltrados).BeginInit();
            SuspendLayout();
            // 
            // gpbDatosFiltroViaje
            // 
            gpbDatosFiltroViaje.Controls.Add(chkbOfreceWifi);
            gpbDatosFiltroViaje.Controls.Add(chkbOfreceComida);
            gpbDatosFiltroViaje.Controls.Add(lblSeleccionWifi);
            gpbDatosFiltroViaje.Controls.Add(lblServicioDeComida);
            gpbDatosFiltroViaje.Controls.Add(calendarSeleccionFechaDeViaje);
            gpbDatosFiltroViaje.Controls.Add(lblFechaSalida);
            gpbDatosFiltroViaje.Controls.Add(cboSeleccionDestino);
            gpbDatosFiltroViaje.Controls.Add(lblDestino);
            gpbDatosFiltroViaje.Controls.Add(cboSeleccionOrigen);
            gpbDatosFiltroViaje.Controls.Add(lblOrigen);
            gpbDatosFiltroViaje.Controls.Add(cboSeleccionTipoDeViaje);
            gpbDatosFiltroViaje.Controls.Add(lblTipoDeVuelo);
            gpbDatosFiltroViaje.Location = new Point(54, 36);
            gpbDatosFiltroViaje.Name = "gpbDatosFiltroViaje";
            gpbDatosFiltroViaje.Size = new Size(1117, 228);
            gpbDatosFiltroViaje.TabIndex = 0;
            gpbDatosFiltroViaje.TabStop = false;
            gpbDatosFiltroViaje.Text = "Datos de viaje a buscar";
            // 
            // chkbOfreceWifi
            // 
            chkbOfreceWifi.AutoSize = true;
            chkbOfreceWifi.Location = new Point(929, 151);
            chkbOfreceWifi.Name = "chkbOfreceWifi";
            chkbOfreceWifi.Size = new Size(69, 19);
            chkbOfreceWifi.TabIndex = 17;
            chkbOfreceWifi.Text = "Incluido";
            chkbOfreceWifi.UseVisualStyleBackColor = true;
            chkbOfreceWifi.CheckedChanged += chkbOfreceWifi_CheckedChanged;
            // 
            // chkbOfreceComida
            // 
            chkbOfreceComida.AutoSize = true;
            chkbOfreceComida.Location = new Point(929, 79);
            chkbOfreceComida.Name = "chkbOfreceComida";
            chkbOfreceComida.Size = new Size(69, 19);
            chkbOfreceComida.TabIndex = 16;
            chkbOfreceComida.Text = "Incluido";
            chkbOfreceComida.UseVisualStyleBackColor = true;
            chkbOfreceComida.CheckedChanged += chkbOfreceComida_CheckedChanged;
            // 
            // lblSeleccionWifi
            // 
            lblSeleccionWifi.Anchor = AnchorStyles.None;
            lblSeleccionWifi.AutoSize = true;
            lblSeleccionWifi.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccionWifi.Location = new Point(737, 153);
            lblSeleccionWifi.Name = "lblSeleccionWifi";
            lblSeleccionWifi.Size = new Size(102, 17);
            lblSeleccionWifi.TabIndex = 15;
            lblSeleccionWifi.Text = "Servicio de Wifi";
            // 
            // lblServicioDeComida
            // 
            lblServicioDeComida.Anchor = AnchorStyles.None;
            lblServicioDeComida.AutoSize = true;
            lblServicioDeComida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicioDeComida.Location = new Point(737, 81);
            lblServicioDeComida.Name = "lblServicioDeComida";
            lblServicioDeComida.Size = new Size(125, 17);
            lblServicioDeComida.TabIndex = 13;
            lblServicioDeComida.Text = "Servicio de comida";
            // 
            // calendarSeleccionFechaDeViaje
            // 
            calendarSeleccionFechaDeViaje.Anchor = AnchorStyles.None;
            calendarSeleccionFechaDeViaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendarSeleccionFechaDeViaje.Location = new Point(441, 42);
            calendarSeleccionFechaDeViaje.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            calendarSeleccionFechaDeViaje.MinDate = new DateTime(2023, 5, 4, 0, 0, 0, 0);
            calendarSeleccionFechaDeViaje.Name = "calendarSeleccionFechaDeViaje";
            calendarSeleccionFechaDeViaje.ShowTodayCircle = false;
            calendarSeleccionFechaDeViaje.TabIndex = 12;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.Anchor = AnchorStyles.None;
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaSalida.Location = new Point(504, 16);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(102, 17);
            lblFechaSalida.TabIndex = 11;
            lblFechaSalida.Text = "Fecha de salida";
            // 
            // cboSeleccionDestino
            // 
            cboSeleccionDestino.Anchor = AnchorStyles.None;
            cboSeleccionDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeleccionDestino.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionDestino.FormattingEnabled = true;
            cboSeleccionDestino.Location = new Point(145, 179);
            cboSeleccionDestino.Name = "cboSeleccionDestino";
            cboSeleccionDestino.Size = new Size(228, 25);
            cboSeleccionDestino.TabIndex = 10;
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(28, 183);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(47, 15);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Destino";
            // 
            // cboSeleccionOrigen
            // 
            cboSeleccionOrigen.Anchor = AnchorStyles.None;
            cboSeleccionOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeleccionOrigen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionOrigen.FormattingEnabled = true;
            cboSeleccionOrigen.Location = new Point(145, 109);
            cboSeleccionOrigen.Name = "cboSeleccionOrigen";
            cboSeleccionOrigen.Size = new Size(228, 25);
            cboSeleccionOrigen.TabIndex = 9;
            // 
            // lblOrigen
            // 
            lblOrigen.Anchor = AnchorStyles.None;
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigen.Location = new Point(27, 112);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(48, 17);
            lblOrigen.TabIndex = 8;
            lblOrigen.Text = "Origen";
            // 
            // cboSeleccionTipoDeViaje
            // 
            cboSeleccionTipoDeViaje.Anchor = AnchorStyles.None;
            cboSeleccionTipoDeViaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeleccionTipoDeViaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionTipoDeViaje.FormattingEnabled = true;
            cboSeleccionTipoDeViaje.Location = new Point(145, 42);
            cboSeleccionTipoDeViaje.Name = "cboSeleccionTipoDeViaje";
            cboSeleccionTipoDeViaje.Size = new Size(228, 25);
            cboSeleccionTipoDeViaje.TabIndex = 7;
            cboSeleccionTipoDeViaje.SelectedIndexChanged += cboSeleccionTipoDeViaje_SelectedIndexChanged;
            // 
            // lblTipoDeVuelo
            // 
            lblTipoDeVuelo.Anchor = AnchorStyles.None;
            lblTipoDeVuelo.AutoSize = true;
            lblTipoDeVuelo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoDeVuelo.Location = new Point(28, 50);
            lblTipoDeVuelo.Name = "lblTipoDeVuelo";
            lblTipoDeVuelo.Size = new Size(88, 17);
            lblTipoDeVuelo.TabIndex = 1;
            lblTipoDeVuelo.Text = "Tipo de vuelo";
            // 
            // dtgListaVuelosFiltrados
            // 
            dtgListaVuelosFiltrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaVuelosFiltrados.Location = new Point(54, 343);
            dtgListaVuelosFiltrados.Name = "dtgListaVuelosFiltrados";
            dtgListaVuelosFiltrados.RowTemplate.Height = 25;
            dtgListaVuelosFiltrados.Size = new Size(1117, 211);
            dtgListaVuelosFiltrados.TabIndex = 1;
            dtgListaVuelosFiltrados.CellContentClick += dtgListaVuelosFiltrados_CellContentClick;
            // 
            // btnBuscarVuelo
            // 
            btnBuscarVuelo.Location = new Point(599, 287);
            btnBuscarVuelo.Name = "btnBuscarVuelo";
            btnBuscarVuelo.Size = new Size(75, 23);
            btnBuscarVuelo.TabIndex = 17;
            btnBuscarVuelo.Text = "Buscar";
            btnBuscarVuelo.UseVisualStyleBackColor = true;
            btnBuscarVuelo.Click += btnBuscarVuelo_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.Location = new Point(54, 278);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(79, 15);
            lblMensajeError.TabIndex = 18;
            lblMensajeError.Text = "Mensaje Error";
            // 
            // btnCargarVueloSeleccionado
            // 
            btnCargarVueloSeleccionado.Location = new Point(477, 571);
            btnCargarVueloSeleccionado.Name = "btnCargarVueloSeleccionado";
            btnCargarVueloSeleccionado.Size = new Size(169, 23);
            btnCargarVueloSeleccionado.TabIndex = 19;
            btnCargarVueloSeleccionado.Text = "Cargar Vuelo Seleccionado";
            btnCargarVueloSeleccionado.UseVisualStyleBackColor = true;
            btnCargarVueloSeleccionado.Click += btnCargarVueloSeleccionado_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(440, 287);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmBusquedaVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 617);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCargarVueloSeleccionado);
            Controls.Add(lblMensajeError);
            Controls.Add(btnBuscarVuelo);
            Controls.Add(dtgListaVuelosFiltrados);
            Controls.Add(gpbDatosFiltroViaje);
            Name = "FrmBusquedaVuelo";
            Text = "FrmVentaPasaje";
            gpbDatosFiltroViaje.ResumeLayout(false);
            gpbDatosFiltroViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListaVuelosFiltrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbDatosFiltroViaje;
        private Label lblTipoDeVuelo;
        private ComboBox cboSeleccionTipoDeViaje;
        private Label lblOrigen;
        private ComboBox cboSeleccionOrigen;
        private Label lblDestino;
        private ComboBox cboSeleccionDestino;
        private Label lblFechaSalida;
        private MonthCalendar calendarSeleccionFechaDeViaje;
        private Label lblServicioDeComida;
        private Label lblSeleccionWifi;
        private DataGridView dtgListaVuelosFiltrados;
        private Button btnBuscarVuelo;
        private Label lblMensajeError;
        private CheckBox chkbOfreceWifi;
        private CheckBox chkbOfreceComida;
        private Button btnCargarVueloSeleccionado;
        private Button btnLimpiar;
    }
}
namespace Vista
{
    partial class FormAgregarVuelo
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
            panelContenedor = new TableLayoutPanel();
            lblTipoDeVuelo = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();
            lvlAvion = new Label();
            lblFechaSalida = new Label();
            lblServicioDeComida = new Label();
            cboSeleccionTipoDeViaje = new ComboBox();
            cboSeleccionOrigen = new ComboBox();
            cboSeleccionDestino = new ComboBox();
            cboSeleccionServicioComida = new ComboBox();
            cboSeleccionAvion = new ComboBox();
            calendarSeleccionFechaDeViaje = new MonthCalendar();
            lblMensajeError = new Label();
            btnAgregarVuelo = new Button();
            btnCancelar = new Button();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.ColumnCount = 4;
            panelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.8064518F));
            panelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.19355F));
            panelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            panelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 354F));
            panelContenedor.Controls.Add(lblTipoDeVuelo, 0, 0);
            panelContenedor.Controls.Add(lblOrigen, 0, 1);
            panelContenedor.Controls.Add(lblDestino, 0, 2);
            panelContenedor.Controls.Add(lvlAvion, 2, 0);
            panelContenedor.Controls.Add(lblFechaSalida, 2, 1);
            panelContenedor.Controls.Add(lblServicioDeComida, 2, 2);
            panelContenedor.Controls.Add(cboSeleccionTipoDeViaje, 1, 0);
            panelContenedor.Controls.Add(cboSeleccionOrigen, 1, 1);
            panelContenedor.Controls.Add(cboSeleccionDestino, 1, 2);
            panelContenedor.Controls.Add(cboSeleccionServicioComida, 3, 2);
            panelContenedor.Controls.Add(cboSeleccionAvion, 3, 0);
            panelContenedor.Controls.Add(calendarSeleccionFechaDeViaje, 3, 1);
            panelContenedor.Location = new Point(30, 28);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.RowCount = 3;
            panelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 32.09169F));
            panelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 67.90831F));
            panelContenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            panelContenedor.Size = new Size(841, 419);
            panelContenedor.TabIndex = 0;
            // 
            // lblTipoDeVuelo
            // 
            lblTipoDeVuelo.Anchor = AnchorStyles.None;
            lblTipoDeVuelo.AutoSize = true;
            lblTipoDeVuelo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoDeVuelo.Location = new Point(4, 42);
            lblTipoDeVuelo.Name = "lblTipoDeVuelo";
            lblTipoDeVuelo.Size = new Size(88, 17);
            lblTipoDeVuelo.TabIndex = 0;
            lblTipoDeVuelo.Text = "Tipo de vuelo";
            // 
            // lblOrigen
            // 
            lblOrigen.Anchor = AnchorStyles.None;
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrigen.Location = new Point(24, 200);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(48, 17);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(24, 360);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(47, 15);
            lblDestino.TabIndex = 2;
            lblDestino.Text = "Destino";
            // 
            // lvlAvion
            // 
            lvlAvion.Anchor = AnchorStyles.None;
            lvlAvion.AutoSize = true;
            lvlAvion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvlAvion.Location = new Point(407, 42);
            lvlAvion.Name = "lvlAvion";
            lvlAvion.Size = new Size(43, 17);
            lvlAvion.TabIndex = 3;
            lvlAvion.Text = "Avión";
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.Anchor = AnchorStyles.None;
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaSalida.Location = new Point(378, 200);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new Size(102, 17);
            lblFechaSalida.TabIndex = 4;
            lblFechaSalida.Text = "Fecha de salida";
            // 
            // lblServicioDeComida
            // 
            lblServicioDeComida.Anchor = AnchorStyles.None;
            lblServicioDeComida.AutoSize = true;
            lblServicioDeComida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicioDeComida.Location = new Point(389, 350);
            lblServicioDeComida.Name = "lblServicioDeComida";
            lblServicioDeComida.Size = new Size(79, 34);
            lblServicioDeComida.TabIndex = 5;
            lblServicioDeComida.Text = "Servicio de comida";
            // 
            // cboSeleccionTipoDeViaje
            // 
            cboSeleccionTipoDeViaje.Anchor = AnchorStyles.None;
            cboSeleccionTipoDeViaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionTipoDeViaje.FormattingEnabled = true;
            cboSeleccionTipoDeViaje.Location = new Point(120, 38);
            cboSeleccionTipoDeViaje.Name = "cboSeleccionTipoDeViaje";
            cboSeleccionTipoDeViaje.Size = new Size(228, 25);
            cboSeleccionTipoDeViaje.TabIndex = 6;
            // 
            // cboSeleccionOrigen
            // 
            cboSeleccionOrigen.Anchor = AnchorStyles.None;
            cboSeleccionOrigen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionOrigen.FormattingEnabled = true;
            cboSeleccionOrigen.Location = new Point(122, 196);
            cboSeleccionOrigen.Name = "cboSeleccionOrigen";
            cboSeleccionOrigen.Size = new Size(224, 25);
            cboSeleccionOrigen.TabIndex = 7;
            cboSeleccionOrigen.Text = "Seleccione origen";
            // 
            // cboSeleccionDestino
            // 
            cboSeleccionDestino.Anchor = AnchorStyles.None;
            cboSeleccionDestino.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionDestino.FormattingEnabled = true;
            cboSeleccionDestino.Location = new Point(125, 355);
            cboSeleccionDestino.Name = "cboSeleccionDestino";
            cboSeleccionDestino.Size = new Size(217, 25);
            cboSeleccionDestino.TabIndex = 8;
            cboSeleccionDestino.Text = "Seleccione destino";
            // 
            // cboSeleccionServicioComida
            // 
            cboSeleccionServicioComida.Anchor = AnchorStyles.None;
            cboSeleccionServicioComida.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionServicioComida.FormattingEnabled = true;
            cboSeleccionServicioComida.Items.AddRange(new object[] { "Si", "No" });
            cboSeleccionServicioComida.Location = new Point(529, 355);
            cboSeleccionServicioComida.Name = "cboSeleccionServicioComida";
            cboSeleccionServicioComida.Size = new Size(268, 25);
            cboSeleccionServicioComida.TabIndex = 9;
            cboSeleccionServicioComida.Text = "Seleccione servicio de comida";
            // 
            // cboSeleccionAvion
            // 
            cboSeleccionAvion.Anchor = AnchorStyles.None;
            cboSeleccionAvion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSeleccionAvion.FormattingEnabled = true;
            cboSeleccionAvion.Location = new Point(562, 38);
            cboSeleccionAvion.Name = "cboSeleccionAvion";
            cboSeleccionAvion.Size = new Size(203, 25);
            cboSeleccionAvion.TabIndex = 10;
            cboSeleccionAvion.Text = "Seleccione avión";
            // 
            // calendarSeleccionFechaDeViaje
            // 
            calendarSeleccionFechaDeViaje.Anchor = AnchorStyles.None;
            calendarSeleccionFechaDeViaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendarSeleccionFechaDeViaje.Location = new Point(539, 127);
            calendarSeleccionFechaDeViaje.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            calendarSeleccionFechaDeViaje.MinDate = new DateTime(2023, 5, 4, 0, 0, 0, 0);
            calendarSeleccionFechaDeViaje.Name = "calendarSeleccionFechaDeViaje";
            calendarSeleccionFechaDeViaje.ShowTodayCircle = false;
            calendarSeleccionFechaDeViaje.TabIndex = 11;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(36, 464);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(87, 17);
            lblMensajeError.TabIndex = 1;
            lblMensajeError.Text = "Mensaje Error";
            // 
            // btnAgregarVuelo
            // 
            btnAgregarVuelo.Location = new Point(303, 479);
            btnAgregarVuelo.Name = "btnAgregarVuelo";
            btnAgregarVuelo.Size = new Size(75, 23);
            btnAgregarVuelo.TabIndex = 2;
            btnAgregarVuelo.Text = "Agregar ";
            btnAgregarVuelo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(534, 479);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAgregarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 524);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarVuelo);
            Controls.Add(lblMensajeError);
            Controls.Add(panelContenedor);
            Name = "FormAgregarVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Vuelo";
            Load += FormAgregarVuelo_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel panelContenedor;
        private Label lblTipoDeVuelo;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lvlAvion;
        private Label lblFechaSalida;
        private Label lblServicioDeComida;
        private ComboBox cboSeleccionTipoDeViaje;
        private ComboBox cboSeleccionOrigen;
        private ComboBox cboSeleccionDestino;
        private ComboBox cboSeleccionServicioComida;
        private ComboBox cboSeleccionAvion;
        private Label lblMensajeError;
        private Button btnAgregarVuelo;
        private Button btnCancelar;
        private MonthCalendar calendarSeleccionFechaDeViaje;
    }
}
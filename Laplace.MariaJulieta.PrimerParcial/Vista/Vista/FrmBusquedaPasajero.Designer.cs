namespace Vista
{
    partial class FrmBusquedaPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaPasajero));
            grpDatosPasajero = new GroupBox();
            txtBusquedaPorDni = new TextBox();
            txtBusquedaPorApellido = new TextBox();
            txtBusquedaPorNombre = new TextBox();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            dtgListarPasajeros = new DataGridView();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnAgregarPasajero = new Button();
            btnSeleccionPasajero = new Button();
            pictureBox1 = new PictureBox();
            grpDatosPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListarPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpDatosPasajero
            // 
            grpDatosPasajero.Controls.Add(txtBusquedaPorDni);
            grpDatosPasajero.Controls.Add(txtBusquedaPorApellido);
            grpDatosPasajero.Controls.Add(txtBusquedaPorNombre);
            grpDatosPasajero.Controls.Add(lblDni);
            grpDatosPasajero.Controls.Add(lblApellido);
            grpDatosPasajero.Controls.Add(lblNombre);
            grpDatosPasajero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosPasajero.ForeColor = SystemColors.ButtonFace;
            grpDatosPasajero.Location = new Point(59, 45);
            grpDatosPasajero.Name = "grpDatosPasajero";
            grpDatosPasajero.Size = new Size(642, 166);
            grpDatosPasajero.TabIndex = 0;
            grpDatosPasajero.TabStop = false;
            grpDatosPasajero.Text = "Datos Pasajero";
            // 
            // txtBusquedaPorDni
            // 
            txtBusquedaPorDni.Location = new Point(200, 110);
            txtBusquedaPorDni.Name = "txtBusquedaPorDni";
            txtBusquedaPorDni.Size = new Size(199, 23);
            txtBusquedaPorDni.TabIndex = 5;
            // 
            // txtBusquedaPorApellido
            // 
            txtBusquedaPorApellido.Location = new Point(200, 75);
            txtBusquedaPorApellido.Name = "txtBusquedaPorApellido";
            txtBusquedaPorApellido.Size = new Size(199, 23);
            txtBusquedaPorApellido.TabIndex = 4;
            // 
            // txtBusquedaPorNombre
            // 
            txtBusquedaPorNombre.Location = new Point(200, 36);
            txtBusquedaPorNombre.Name = "txtBusquedaPorNombre";
            txtBusquedaPorNombre.Size = new Size(199, 23);
            txtBusquedaPorNombre.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(36, 110);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(88, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "Buscar por DNI";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(36, 75);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(110, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Buscar por Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Buscar por Nombre";
            // 
            // dtgListarPasajeros
            // 
            dtgListarPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListarPasajeros.Location = new Point(59, 279);
            dtgListarPasajeros.Name = "dtgListarPasajeros";
            dtgListarPasajeros.ReadOnly = true;
            dtgListarPasajeros.RowTemplate.Height = 25;
            dtgListarPasajeros.Size = new Size(951, 150);
            dtgListarPasajeros.TabIndex = 1;
            dtgListarPasajeros.CellClick += dtgListarPasajeros_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(156, 240);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(336, 240);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(521, 240);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(108, 23);
            btnAgregarPasajero.TabIndex = 4;
            btnAgregarPasajero.Text = "Agregar Pasajero";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // btnSeleccionPasajero
            // 
            btnSeleccionPasajero.Location = new Point(465, 447);
            btnSeleccionPasajero.Name = "btnSeleccionPasajero";
            btnSeleccionPasajero.Size = new Size(138, 23);
            btnSeleccionPasajero.TabIndex = 5;
            btnSeleccionPasajero.Text = "Seleccionar pasajero";
            btnSeleccionPasajero.UseVisualStyleBackColor = true;
            btnSeleccionPasajero.Click += btnSeleccionPasajero_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.gifBusquedaCliente;
            pictureBox1.Location = new Point(761, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmBusquedaPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 492);
            Controls.Add(pictureBox1);
            Controls.Add(btnSeleccionPasajero);
            Controls.Add(btnAgregarPasajero);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(dtgListarPasajeros);
            Controls.Add(grpDatosPasajero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBusquedaPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de pasajero";
            Load += FrmBusquedaPasajero_Load;
            grpDatosPasajero.ResumeLayout(false);
            grpDatosPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListarPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPasajero;
        private TextBox txtBusquedaPorDni;
        private TextBox txtBusquedaPorApellido;
        private TextBox txtBusquedaPorNombre;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private DataGridView dtgListarPasajeros;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnAgregarPasajero;
        private Button btnSeleccionPasajero;
        private PictureBox pictureBox1;
    }
}
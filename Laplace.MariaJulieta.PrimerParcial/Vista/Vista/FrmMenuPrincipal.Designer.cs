namespace Vista
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            lblFechaActual = new Label();
            lblBienvenidaUser = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            vuelosToolStripMenuItem = new ToolStripMenuItem();
            ventaDePasajesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            avionesToolStripMenuItem = new ToolStripMenuItem();
            estadisticasHistoricasToolStripMenuItem = new ToolStripMenuItem();
            dtgListar = new DataGridView();
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            panelBotones = new Panel();
            pctBxImagenParaMostrar = new PictureBox();
            pctbxImagenMenuPpal = new PictureBox();
            pctbxLogoUsuario = new PictureBox();
            pctbxImagenCalendario = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).BeginInit();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxImagenParaMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenMenuPpal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxLogoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenCalendario).BeginInit();
            SuspendLayout();
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaActual.ForeColor = SystemColors.Control;
            lblFechaActual.Location = new Point(795, 665);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(75, 25);
            lblFechaActual.TabIndex = 1;
            lblFechaActual.Text = "Fecha";
            // 
            // lblBienvenidaUser
            // 
            lblBienvenidaUser.AutoSize = true;
            lblBienvenidaUser.BackColor = Color.White;
            lblBienvenidaUser.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenidaUser.ForeColor = SystemColors.Control;
            lblBienvenidaUser.Location = new Point(150, 665);
            lblBienvenidaUser.Name = "lblBienvenidaUser";
            lblBienvenidaUser.Size = new Size(180, 25);
            lblBienvenidaUser.TabIndex = 0;
            lblBienvenidaUser.Text = "Bienvenido: User";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, vuelosToolStripMenuItem, ventaDePasajesToolStripMenuItem, clientesToolStripMenuItem, avionesToolStripMenuItem, estadisticasHistoricasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1231, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.ForeColor = SystemColors.Control;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(63, 23);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // vuelosToolStripMenuItem
            // 
            vuelosToolStripMenuItem.ForeColor = SystemColors.Control;
            vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            vuelosToolStripMenuItem.Size = new Size(72, 23);
            vuelosToolStripMenuItem.Text = "Vuelos";
            vuelosToolStripMenuItem.Click += vuelosToolStripMenuItem_Click;
            // 
            // ventaDePasajesToolStripMenuItem
            // 
            ventaDePasajesToolStripMenuItem.ForeColor = SystemColors.Control;
            ventaDePasajesToolStripMenuItem.Name = "ventaDePasajesToolStripMenuItem";
            ventaDePasajesToolStripMenuItem.Size = new Size(153, 23);
            ventaDePasajesToolStripMenuItem.Text = "Venta de Pasajes";
            ventaDePasajesToolStripMenuItem.Click += ventaDePasajesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.ForeColor = SystemColors.Control;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(87, 23);
            clientesToolStripMenuItem.Text = "Pasajero";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // avionesToolStripMenuItem
            // 
            avionesToolStripMenuItem.ForeColor = SystemColors.Control;
            avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            avionesToolStripMenuItem.Size = new Size(82, 23);
            avionesToolStripMenuItem.Text = "Aviones";
            avionesToolStripMenuItem.Click += avionesToolStripMenuItem_Click;
            // 
            // estadisticasHistoricasToolStripMenuItem
            // 
            estadisticasHistoricasToolStripMenuItem.ForeColor = SystemColors.Control;
            estadisticasHistoricasToolStripMenuItem.Name = "estadisticasHistoricasToolStripMenuItem";
            estadisticasHistoricasToolStripMenuItem.Size = new Size(181, 23);
            estadisticasHistoricasToolStripMenuItem.Text = "Estadisticas Historicas";
            estadisticasHistoricasToolStripMenuItem.Click += estadisticasHistoricasToolStripMenuItem_Click;
            // 
            // dtgListar
            // 
            dtgListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListar.Location = new Point(205, 80);
            dtgListar.Name = "dtgListar";
            dtgListar.RowTemplate.Height = 25;
            dtgListar.Size = new Size(1000, 525);
            dtgListar.TabIndex = 2;
            dtgListar.CellClick += dtgListar_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(39, 17);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(0, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 31);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(0, 142);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(178, 31);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 125, 117);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(0, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(175, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = SystemColors.ControlDark;
            panelBotones.Controls.Add(pctBxImagenParaMostrar);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnModificar);
            panelBotones.Location = new Point(12, 80);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(178, 525);
            panelBotones.TabIndex = 7;
            // 
            // pctBxImagenParaMostrar
            // 
            pctBxImagenParaMostrar.BorderStyle = BorderStyle.FixedSingle;
            pctBxImagenParaMostrar.Location = new Point(14, 319);
            pctBxImagenParaMostrar.Name = "pctBxImagenParaMostrar";
            pctBxImagenParaMostrar.Size = new Size(142, 142);
            pctBxImagenParaMostrar.TabIndex = 8;
            pctBxImagenParaMostrar.TabStop = false;
            // 
            // pctbxImagenMenuPpal
            // 
            pctbxImagenMenuPpal.Image = Properties.Resources.Fondo;
            pctbxImagenMenuPpal.Location = new Point(0, 30);
            pctbxImagenMenuPpal.Name = "pctbxImagenMenuPpal";
            pctbxImagenMenuPpal.Size = new Size(1231, 691);
            pctbxImagenMenuPpal.TabIndex = 8;
            pctbxImagenMenuPpal.TabStop = false;
            // 
            // pctbxLogoUsuario
            // 
            pctbxLogoUsuario.BorderStyle = BorderStyle.FixedSingle;
            pctbxLogoUsuario.Image = Properties.Resources.gifUsuario;
            pctbxLogoUsuario.Location = new Point(26, 646);
            pctbxLogoUsuario.Name = "pctbxLogoUsuario";
            pctbxLogoUsuario.Size = new Size(64, 64);
            pctbxLogoUsuario.TabIndex = 9;
            pctbxLogoUsuario.TabStop = false;
            // 
            // pctbxImagenCalendario
            // 
            pctbxImagenCalendario.BorderStyle = BorderStyle.FixedSingle;
            pctbxImagenCalendario.Image = Properties.Resources.gifCalendario;
            pctbxImagenCalendario.Location = new Point(680, 646);
            pctbxImagenCalendario.Name = "pctbxImagenCalendario";
            pctbxImagenCalendario.Size = new Size(64, 64);
            pctbxImagenCalendario.TabIndex = 10;
            pctbxImagenCalendario.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 722);
            Controls.Add(pctbxImagenCalendario);
            Controls.Add(pctbxLogoUsuario);
            Controls.Add(lblBienvenidaUser);
            Controls.Add(lblFechaActual);
            Controls.Add(lblTitulo);
            Controls.Add(dtgListar);
            Controls.Add(menuStrip1);
            Controls.Add(panelBotones);
            Controls.Add(pctbxImagenMenuPpal);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú - Fly Airlines";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FormMenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).EndInit();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBxImagenParaMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenMenuPpal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxLogoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbxImagenCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFechaActual;
        private Label lblBienvenidaUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem vuelosToolStripMenuItem;
        private ToolStripMenuItem ventaDePasajesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem estadisticasHistoricasToolStripMenuItem;
        private DataGridView dtgListar;
        private Label lblTitulo;
        private ToolStripMenuItem avionesToolStripMenuItem;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Panel panelBotones;
        private PictureBox pctBxImagenParaMostrar;
        private PictureBox pctbxImagenMenuPpal;
        private PictureBox pctbxLogoUsuario;
        private PictureBox pctbxImagenCalendario;
    }
}
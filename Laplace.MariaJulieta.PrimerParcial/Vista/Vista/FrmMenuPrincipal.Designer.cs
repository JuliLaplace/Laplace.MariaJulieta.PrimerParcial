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
            panelData = new Panel();
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
            pctBxImagenPAraMostrar = new PictureBox();
            panelData.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).BeginInit();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBxImagenPAraMostrar).BeginInit();
            SuspendLayout();
            // 
            // panelData
            // 
            panelData.Controls.Add(lblFechaActual);
            panelData.Controls.Add(lblBienvenidaUser);
            panelData.Location = new Point(-3, 634);
            panelData.Name = "panelData";
            panelData.Size = new Size(1074, 90);
            panelData.TabIndex = 0;
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Location = new Point(337, 24);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(45, 17);
            lblFechaActual.TabIndex = 1;
            lblFechaActual.Text = "Fecha";
            // 
            // lblBienvenidaUser
            // 
            lblBienvenidaUser.AutoSize = true;
            lblBienvenidaUser.Location = new Point(45, 24);
            lblBienvenidaUser.Name = "lblBienvenidaUser";
            lblBienvenidaUser.Size = new Size(103, 17);
            lblBienvenidaUser.TabIndex = 0;
            lblBienvenidaUser.Text = "Bienvenido User";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, vuelosToolStripMenuItem, ventaDePasajesToolStripMenuItem, clientesToolStripMenuItem, avionesToolStripMenuItem, estadisticasHistoricasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(52, 21);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // vuelosToolStripMenuItem
            // 
            vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            vuelosToolStripMenuItem.Size = new Size(60, 21);
            vuelosToolStripMenuItem.Text = "Vuelos";
            vuelosToolStripMenuItem.Click += vuelosToolStripMenuItem_Click;
            // 
            // ventaDePasajesToolStripMenuItem
            // 
            ventaDePasajesToolStripMenuItem.Name = "ventaDePasajesToolStripMenuItem";
            ventaDePasajesToolStripMenuItem.Size = new Size(123, 21);
            ventaDePasajesToolStripMenuItem.Text = "Venta de Pasajes";
            ventaDePasajesToolStripMenuItem.Click += ventaDePasajesToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(71, 21);
            clientesToolStripMenuItem.Text = "Pasajero";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // avionesToolStripMenuItem
            // 
            avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            avionesToolStripMenuItem.Size = new Size(68, 21);
            avionesToolStripMenuItem.Text = "Aviones";
            avionesToolStripMenuItem.Click += avionesToolStripMenuItem_Click;
            // 
            // estadisticasHistoricasToolStripMenuItem
            // 
            estadisticasHistoricasToolStripMenuItem.Name = "estadisticasHistoricasToolStripMenuItem";
            estadisticasHistoricasToolStripMenuItem.Size = new Size(149, 21);
            estadisticasHistoricasToolStripMenuItem.Text = "Estadisticas Historicas";
            // 
            // dtgListar
            // 
            dtgListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListar.Location = new Point(204, 80);
            dtgListar.Name = "dtgListar";
            dtgListar.RowTemplate.Height = 25;
            dtgListar.Size = new Size(814, 525);
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
            btnAgregar.Location = new Point(45, 49);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(45, 141);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(45, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = SystemColors.ControlDark;
            panelBotones.Controls.Add(pctBxImagenPAraMostrar);
            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnModificar);
            panelBotones.Location = new Point(12, 80);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(178, 525);
            panelBotones.TabIndex = 7;
            // 
            // pctBxImagenPAraMostrar
            // 
            pctBxImagenPAraMostrar.Location = new Point(18, 377);
            pctBxImagenPAraMostrar.Name = "pctBxImagenPAraMostrar";
            pctBxImagenPAraMostrar.Size = new Size(128, 128);
            pctBxImagenPAraMostrar.TabIndex = 8;
            pctBxImagenPAraMostrar.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 722);
            Controls.Add(lblTitulo);
            Controls.Add(dtgListar);
            Controls.Add(panelData);
            Controls.Add(menuStrip1);
            Controls.Add(panelBotones);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú - Fly Airlines";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FormMenuPrincipal_Load;
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).EndInit();
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBxImagenPAraMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelData;
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
        private PictureBox pctBxImagenPAraMostrar;
    }
}
namespace Vista
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            panelData = new Panel();
            btnSalir = new Button();
            lblFechaActual = new Label();
            lblBienvenidaUser = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            vuelosToolStripMenuItem = new ToolStripMenuItem();
            agregarVueloToolStripMenuItem = new ToolStripMenuItem();
            modificarVueloToolStripMenuItem = new ToolStripMenuItem();
            eliminarVueloToolStripMenuItem = new ToolStripMenuItem();
            verListadoDeVuelosDisponiblesToolStripMenuItem = new ToolStripMenuItem();
            ventaDePasajesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            agregarUnClienteToolStripMenuItem = new ToolStripMenuItem();
            verListadoDeClientesToolStripMenuItem = new ToolStripMenuItem();
            eliminarClienteToolStripMenuItem = new ToolStripMenuItem();
            verListadoDeClientesToolStripMenuItem1 = new ToolStripMenuItem();
            estadisticasHistoricasToolStripMenuItem = new ToolStripMenuItem();
            aeronavesToolStripMenuItem = new ToolStripMenuItem();
            crearAeronavesToolStripMenuItem = new ToolStripMenuItem();
            eliminarAeronavesToolStripMenuItem = new ToolStripMenuItem();
            modificarAeronavesToolStripMenuItem = new ToolStripMenuItem();
            listarAeronavesToolStripMenuItem = new ToolStripMenuItem();
            dtgListar = new DataGridView();
            lblTitulo = new Label();
            panelData.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).BeginInit();
            SuspendLayout();
            // 
            // panelData
            // 
            panelData.Controls.Add(btnSalir);
            panelData.Controls.Add(lblFechaActual);
            panelData.Controls.Add(lblBienvenidaUser);
            panelData.Location = new Point(-3, 665);
            panelData.Name = "panelData";
            panelData.Size = new Size(1074, 59);
            panelData.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(958, 15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 26);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, vuelosToolStripMenuItem, ventaDePasajesToolStripMenuItem, clientesToolStripMenuItem, estadisticasHistoricasToolStripMenuItem, aeronavesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // vuelosToolStripMenuItem
            // 
            vuelosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarVueloToolStripMenuItem, modificarVueloToolStripMenuItem, eliminarVueloToolStripMenuItem, verListadoDeVuelosDisponiblesToolStripMenuItem });
            vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            vuelosToolStripMenuItem.Size = new Size(54, 20);
            vuelosToolStripMenuItem.Text = "Vuelos";
            // 
            // agregarVueloToolStripMenuItem
            // 
            agregarVueloToolStripMenuItem.Name = "agregarVueloToolStripMenuItem";
            agregarVueloToolStripMenuItem.Size = new Size(244, 22);
            agregarVueloToolStripMenuItem.Text = "Agregar vuelo";
            agregarVueloToolStripMenuItem.Click += agregarVueloToolStripMenuItem_Click;
            // 
            // modificarVueloToolStripMenuItem
            // 
            modificarVueloToolStripMenuItem.Name = "modificarVueloToolStripMenuItem";
            modificarVueloToolStripMenuItem.Size = new Size(244, 22);
            modificarVueloToolStripMenuItem.Text = "Modificar vuelo";
            // 
            // eliminarVueloToolStripMenuItem
            // 
            eliminarVueloToolStripMenuItem.Name = "eliminarVueloToolStripMenuItem";
            eliminarVueloToolStripMenuItem.Size = new Size(244, 22);
            eliminarVueloToolStripMenuItem.Text = "Eliminar vuelo";
            // 
            // verListadoDeVuelosDisponiblesToolStripMenuItem
            // 
            verListadoDeVuelosDisponiblesToolStripMenuItem.Name = "verListadoDeVuelosDisponiblesToolStripMenuItem";
            verListadoDeVuelosDisponiblesToolStripMenuItem.Size = new Size(244, 22);
            verListadoDeVuelosDisponiblesToolStripMenuItem.Text = "Ver listado de vuelos disponibles";
            verListadoDeVuelosDisponiblesToolStripMenuItem.Click += verListadoDeVuelosDisponiblesToolStripMenuItem_Click;
            // 
            // ventaDePasajesToolStripMenuItem
            // 
            ventaDePasajesToolStripMenuItem.Name = "ventaDePasajesToolStripMenuItem";
            ventaDePasajesToolStripMenuItem.Size = new Size(105, 20);
            ventaDePasajesToolStripMenuItem.Text = "Venta de Pasajes";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarUnClienteToolStripMenuItem, verListadoDeClientesToolStripMenuItem, eliminarClienteToolStripMenuItem, verListadoDeClientesToolStripMenuItem1 });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarUnClienteToolStripMenuItem
            // 
            agregarUnClienteToolStripMenuItem.Name = "agregarUnClienteToolStripMenuItem";
            agregarUnClienteToolStripMenuItem.Size = new Size(189, 22);
            agregarUnClienteToolStripMenuItem.Text = "Agregar un Cliente";
            agregarUnClienteToolStripMenuItem.Click += agregarUnClienteToolStripMenuItem_Click;
            // 
            // verListadoDeClientesToolStripMenuItem
            // 
            verListadoDeClientesToolStripMenuItem.Name = "verListadoDeClientesToolStripMenuItem";
            verListadoDeClientesToolStripMenuItem.Size = new Size(189, 22);
            verListadoDeClientesToolStripMenuItem.Text = "Modificar un Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            eliminarClienteToolStripMenuItem.Size = new Size(189, 22);
            eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // verListadoDeClientesToolStripMenuItem1
            // 
            verListadoDeClientesToolStripMenuItem1.Name = "verListadoDeClientesToolStripMenuItem1";
            verListadoDeClientesToolStripMenuItem1.Size = new Size(189, 22);
            verListadoDeClientesToolStripMenuItem1.Text = "Ver listado de Clientes";
            verListadoDeClientesToolStripMenuItem1.Click += verListadoDeClientesToolStripMenuItem1_Click;
            // 
            // estadisticasHistoricasToolStripMenuItem
            // 
            estadisticasHistoricasToolStripMenuItem.Name = "estadisticasHistoricasToolStripMenuItem";
            estadisticasHistoricasToolStripMenuItem.Size = new Size(134, 20);
            estadisticasHistoricasToolStripMenuItem.Text = "Estadisticas Historicas";
            // 
            // aeronavesToolStripMenuItem
            // 
            aeronavesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearAeronavesToolStripMenuItem, eliminarAeronavesToolStripMenuItem, modificarAeronavesToolStripMenuItem, listarAeronavesToolStripMenuItem });
            aeronavesToolStripMenuItem.Name = "aeronavesToolStripMenuItem";
            aeronavesToolStripMenuItem.Size = new Size(74, 20);
            aeronavesToolStripMenuItem.Text = "Aeronaves";
            // 
            // crearAeronavesToolStripMenuItem
            // 
            crearAeronavesToolStripMenuItem.Name = "crearAeronavesToolStripMenuItem";
            crearAeronavesToolStripMenuItem.Size = new Size(180, 22);
            crearAeronavesToolStripMenuItem.Text = "Agregar aeronave";
            crearAeronavesToolStripMenuItem.Click += crearAeronavesToolStripMenuItem_Click;
            // 
            // eliminarAeronavesToolStripMenuItem
            // 
            eliminarAeronavesToolStripMenuItem.Name = "eliminarAeronavesToolStripMenuItem";
            eliminarAeronavesToolStripMenuItem.Size = new Size(180, 22);
            eliminarAeronavesToolStripMenuItem.Text = "Eliminar aeronave";
            // 
            // modificarAeronavesToolStripMenuItem
            // 
            modificarAeronavesToolStripMenuItem.Name = "modificarAeronavesToolStripMenuItem";
            modificarAeronavesToolStripMenuItem.Size = new Size(180, 22);
            modificarAeronavesToolStripMenuItem.Text = "Modificar aeronave";
            // 
            // listarAeronavesToolStripMenuItem
            // 
            listarAeronavesToolStripMenuItem.Name = "listarAeronavesToolStripMenuItem";
            listarAeronavesToolStripMenuItem.Size = new Size(180, 22);
            listarAeronavesToolStripMenuItem.Text = "Listar aeronaves";
            listarAeronavesToolStripMenuItem.Click += listarAeronavesToolStripMenuItem_Click;
            // 
            // dtgListar
            // 
            dtgListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListar.Location = new Point(54, 143);
            dtgListar.Name = "dtgListar";
            dtgListar.RowTemplate.Height = 25;
            dtgListar.Size = new Size(968, 472);
            dtgListar.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(64, 106);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(39, 17);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 722);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(dtgListar);
            Controls.Add(panelData);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú - Fly Airlines";
            Load += FormMenuPrincipal_Load;
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelData;
        private Button btnSalir;
        private Label lblFechaActual;
        private Label lblBienvenidaUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem vuelosToolStripMenuItem;
        private ToolStripMenuItem verListadoDeVuelosDisponiblesToolStripMenuItem;
        private ToolStripMenuItem agregarVueloToolStripMenuItem;
        private ToolStripMenuItem ventaDePasajesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem estadisticasHistoricasToolStripMenuItem;
        private DataGridView dtgListar;
        private Label lblTitulo;
        private ToolStripMenuItem agregarUnClienteToolStripMenuItem;
        private ToolStripMenuItem verListadoDeClientesToolStripMenuItem;
        private ToolStripMenuItem verListadoDeClientesToolStripMenuItem1;
        private ToolStripMenuItem modificarVueloToolStripMenuItem;
        private ToolStripMenuItem eliminarVueloToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private ToolStripMenuItem aeronavesToolStripMenuItem;
        private ToolStripMenuItem crearAeronavesToolStripMenuItem;
        private ToolStripMenuItem eliminarAeronavesToolStripMenuItem;
        private ToolStripMenuItem modificarAeronavesToolStripMenuItem;
        private ToolStripMenuItem listarAeronavesToolStripMenuItem;

    }
}
namespace Vista
{
    partial class FrmAgregarAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarAvion));
            lblAvion = new Label();
            cboAviones = new ComboBox();
            pictureBox1 = new PictureBox();
            lblMatricula = new Label();
            txtMatriculaAvion = new TextBox();
            panelAvion = new Panel();
            PanelMatricula = new Panel();
            panelBanios = new Panel();
            domUpDownCantidadBanios = new DomainUpDown();
            domUpDownAsientos = new DomainUpDown();
            lblCantidadAsientos = new Label();
            lblCantidadBanios = new Label();
            panel1 = new Panel();
            domUpDownCapacidadMaxima = new DomainUpDown();
            lblCapacidadBodega = new Label();
            btnBoton1 = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAvion.SuspendLayout();
            PanelMatricula.SuspendLayout();
            panelBanios.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAvion
            // 
            lblAvion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAvion.AutoSize = true;
            lblAvion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvion.Location = new Point(22, 31);
            lblAvion.Name = "lblAvion";
            lblAvion.Size = new Size(43, 17);
            lblAvion.TabIndex = 0;
            lblAvion.Text = "Avión";
            // 
            // cboAviones
            // 
            cboAviones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAviones.FormattingEnabled = true;
            cboAviones.Location = new Point(130, 29);
            cboAviones.Name = "cboAviones";
            cboAviones.Size = new Size(121, 23);
            cboAviones.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.gifAvion;
            pictureBox1.Location = new Point(569, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 230);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.Location = new Point(22, 27);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 17);
            lblMatricula.TabIndex = 3;
            lblMatricula.Text = "Matricula";
            // 
            // txtMatriculaAvion
            // 
            txtMatriculaAvion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMatriculaAvion.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMatriculaAvion.Location = new Point(130, 21);
            txtMatriculaAvion.Name = "txtMatriculaAvion";
            txtMatriculaAvion.Size = new Size(121, 22);
            txtMatriculaAvion.TabIndex = 4;
            txtMatriculaAvion.TextChanged += txtMatriculaAvion_TextChanged;
            // 
            // panelAvion
            // 
            panelAvion.Controls.Add(lblAvion);
            panelAvion.Controls.Add(cboAviones);
            panelAvion.Location = new Point(23, 12);
            panelAvion.Name = "panelAvion";
            panelAvion.Size = new Size(529, 79);
            panelAvion.TabIndex = 5;
            // 
            // PanelMatricula
            // 
            PanelMatricula.Controls.Add(lblMatricula);
            PanelMatricula.Controls.Add(txtMatriculaAvion);
            PanelMatricula.Location = new Point(23, 122);
            PanelMatricula.Name = "PanelMatricula";
            PanelMatricula.Size = new Size(529, 79);
            PanelMatricula.TabIndex = 6;
            // 
            // panelBanios
            // 
            panelBanios.Controls.Add(domUpDownCantidadBanios);
            panelBanios.Controls.Add(domUpDownAsientos);
            panelBanios.Controls.Add(lblCantidadAsientos);
            panelBanios.Controls.Add(lblCantidadBanios);
            panelBanios.Location = new Point(23, 230);
            panelBanios.Name = "panelBanios";
            panelBanios.Size = new Size(529, 79);
            panelBanios.TabIndex = 7;
            // 
            // domUpDownCantidadBanios
            // 
            domUpDownCantidadBanios.Location = new Point(146, 29);
            domUpDownCantidadBanios.Name = "domUpDownCantidadBanios";
            domUpDownCantidadBanios.Size = new Size(120, 23);
            domUpDownCantidadBanios.TabIndex = 4;
            // 
            // domUpDownAsientos
            // 
            domUpDownAsientos.Location = new Point(392, 28);
            domUpDownAsientos.Name = "domUpDownAsientos";
            domUpDownAsientos.Size = new Size(120, 23);
            domUpDownAsientos.TabIndex = 3;
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.AutoSize = true;
            lblCantidadAsientos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadAsientos.Location = new Point(269, 30);
            lblCantidadAsientos.Name = "lblCantidadAsientos";
            lblCantidadAsientos.Size = new Size(117, 17);
            lblCantidadAsientos.TabIndex = 1;
            lblCantidadAsientos.Text = "Cantidad Asientos";
            // 
            // lblCantidadBanios
            // 
            lblCantidadBanios.AutoSize = true;
            lblCantidadBanios.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadBanios.Location = new Point(19, 30);
            lblCantidadBanios.Name = "lblCantidadBanios";
            lblCantidadBanios.Size = new Size(121, 17);
            lblCantidadBanios.TabIndex = 0;
            lblCantidadBanios.Text = "Cantidad de Baños";
            // 
            // panel1
            // 
            panel1.Controls.Add(domUpDownCapacidadMaxima);
            panel1.Controls.Add(lblCapacidadBodega);
            panel1.Location = new Point(23, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 79);
            panel1.TabIndex = 8;
            // 
            // domUpDownCapacidadMaxima
            // 
            domUpDownCapacidadMaxima.Location = new Point(278, 34);
            domUpDownCapacidadMaxima.Name = "domUpDownCapacidadMaxima";
            domUpDownCapacidadMaxima.Size = new Size(120, 23);
            domUpDownCapacidadMaxima.TabIndex = 1;
            // 
            // lblCapacidadBodega
            // 
            lblCapacidadBodega.AutoSize = true;
            lblCapacidadBodega.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCapacidadBodega.Location = new Point(19, 32);
            lblCapacidadBodega.Name = "lblCapacidadBodega";
            lblCapacidadBodega.Size = new Size(177, 17);
            lblCapacidadBodega.TabIndex = 0;
            lblCapacidadBodega.Text = "Capacidad máxima bodega";
            // 
            // btnBoton1
            // 
            btnBoton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoton1.Location = new Point(183, 470);
            btnBoton1.Name = "btnBoton1";
            btnBoton1.Size = new Size(75, 23);
            btnBoton1.TabIndex = 9;
            btnBoton1.Text = "Boton1";
            btnBoton1.UseVisualStyleBackColor = true;
            btnBoton1.Click += btnBoton1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(460, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 526);
            Controls.Add(btnCancelar);
            Controls.Add(btnBoton1);
            Controls.Add(panel1);
            Controls.Add(panelBanios);
            Controls.Add(PanelMatricula);
            Controls.Add(panelAvion);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmAgregarAvion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar avion";
            Load += FormAgregarAvion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAvion.ResumeLayout(false);
            panelAvion.PerformLayout();
            PanelMatricula.ResumeLayout(false);
            PanelMatricula.PerformLayout();
            panelBanios.ResumeLayout(false);
            panelBanios.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAvion;
        private PictureBox pictureBox1;
        private Label lblMatricula;
        private Panel PanelMatricula;
        private Panel panelBanios;
        private Label lblCantidadAsientos;
        private Label lblCantidadBanios;
        private Panel panel1;
        private Label lblCapacidadBodega;
        protected Panel panelAvion;
        protected ComboBox cboAviones;
        protected TextBox txtMatriculaAvion;
        protected DomainUpDown domUpDownAsientos;
        protected Button btnBoton1;
        protected Button btnCancelar;
        protected DomainUpDown domUpDownCapacidadMaxima;
        protected DomainUpDown domUpDownCantidadBanios;
    }
}
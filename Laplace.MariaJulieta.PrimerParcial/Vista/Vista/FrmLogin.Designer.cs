namespace Vista
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pboxPanelImagen = new PictureBox();
            lblTituloLogin = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            lblMensajeError = new Label();
            btnAutoCompletar = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxPanelImagen).BeginInit();
            SuspendLayout();
            // 
            // pboxPanelImagen
            // 
            pboxPanelImagen.Image = (Image)resources.GetObject("pboxPanelImagen.Image");
            pboxPanelImagen.Location = new Point(-1, 0);
            pboxPanelImagen.Name = "pboxPanelImagen";
            pboxPanelImagen.Size = new Size(250, 448);
            pboxPanelImagen.TabIndex = 0;
            pboxPanelImagen.TabStop = false;
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloLogin.Location = new Point(315, 61);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(314, 39);
            lblTituloLogin.TabIndex = 1;
            lblTituloLogin.Text = "Ingreso de usuarios";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(378, 151);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "USUARIO";
            txtUsuario.Size = new Size(192, 22);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(378, 198);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "CONTRASEÑA";
            txtContraseña.Size = new Size(192, 22);
            txtContraseña.TabIndex = 6;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LightGray;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(340, 304);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(104, 40);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(513, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.BackColor = SystemColors.ButtonFace;
            lblMensajeError.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(378, 257);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(97, 16);
            lblMensajeError.TabIndex = 7;
            lblMensajeError.Text = "Mensaje error";
            // 
            // btnAutoCompletar
            // 
            btnAutoCompletar.BackColor = Color.LightGray;
            btnAutoCompletar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutoCompletar.Location = new Point(414, 381);
            btnAutoCompletar.Name = "btnAutoCompletar";
            btnAutoCompletar.Size = new Size(113, 40);
            btnAutoCompletar.TabIndex = 8;
            btnAutoCompletar.Text = "Autocompletar";
            btnAutoCompletar.UseVisualStyleBackColor = false;
            btnAutoCompletar.Click += btnAutoCompletar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(699, 447);
            Controls.Add(btnAutoCompletar);
            Controls.Add(lblMensajeError);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblTituloLogin);
            Controls.Add(pboxPanelImagen);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pboxPanelImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pboxPanelImagen;
        private Label lblTituloLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblMensajeError;
        private Button btnAutoCompletar;
    }
}
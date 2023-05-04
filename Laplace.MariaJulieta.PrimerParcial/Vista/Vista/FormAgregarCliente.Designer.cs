namespace Vista
{
    partial class FormAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCliente));
            btnAgregarCliente = new Button();
            btnCancelar = new Button();
            lblNombreCliente = new Label();
            lblApellido = new Label();
            lblGenero = new Label();
            lblDni = new Label();
            lblEdad = new Label();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtEdadCliente = new TextBox();
            txtDniCliente = new TextBox();
            cmbGenero = new ComboBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(55, 494);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 26);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(338, 495);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(49, 90);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(56, 17);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(49, 159);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(49, 382);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(53, 17);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(49, 304);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 17);
            lblDni.TabIndex = 5;
            lblDni.Text = "Dni";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(49, 235);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(38, 17);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(179, 90);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(198, 22);
            txtNombreCliente.TabIndex = 7;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(179, 150);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(198, 22);
            txtApellidoCliente.TabIndex = 8;
            // 
            // txtEdadCliente
            // 
            txtEdadCliente.Location = new Point(179, 231);
            txtEdadCliente.Name = "txtEdadCliente";
            txtEdadCliente.Size = new Size(198, 22);
            txtEdadCliente.TabIndex = 9;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(179, 295);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(198, 22);
            txtDniCliente.TabIndex = 10;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(179, 379);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 25);
            cmbGenero.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(127, 447);
            lblError.Name = "lblError";
            lblError.Size = new Size(235, 17);
            lblError.TabIndex = 12;
            lblError.Text = "Datos incorrectos. Vuelva a intentarlo";
            // 
            // FormAgregarCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(456, 590);
            ControlBox = false;
            Controls.Add(lblError);
            Controls.Add(cmbGenero);
            Controls.Add(txtDniCliente);
            Controls.Add(txtEdadCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblGenero);
            Controls.Add(lblApellido);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarCliente);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar cliente";
            Load += FormAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliente;
        private Button btnCancelar;
        private Label lblNombreCliente;
        private Label lblApellido;
        private Label lblGenero;
        private Label lblDni;
        private Label lblEdad;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtEdadCliente;
        private TextBox txtDniCliente;
        private ComboBox cmbGenero;
        private Label lblError;
    }
}
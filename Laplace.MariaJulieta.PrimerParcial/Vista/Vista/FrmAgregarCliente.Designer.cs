namespace Vista
{
    partial class FrmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCliente));
            btnBoton1 = new Button();
            btnCancelar = new Button();
            lblNombreCliente = new Label();
            lblApellido = new Label();
            lblGenero = new Label();
            lblDni = new Label();
            txtNombreCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtDniCliente = new TextBox();
            cmbGenero = new ComboBox();
            lblError = new Label();
            dtpickerFechaNacimiento = new DateTimePicker();
            ldlFechaNacimiento = new Label();
            SuspendLayout();
            // 
            // btnBoton1
            // 
            btnBoton1.Location = new Point(55, 494);
            btnBoton1.Name = "btnBoton1";
            btnBoton1.Size = new Size(75, 26);
            btnBoton1.TabIndex = 0;
            btnBoton1.Text = "Boton1";
            btnBoton1.UseVisualStyleBackColor = true;
            btnBoton1.Click += btnBoton1_Click;
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
            lblNombreCliente.Location = new Point(28, 182);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(56, 17);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(26, 245);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(26, 379);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(53, 17);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Género";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(28, 123);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 17);
            lblDni.TabIndex = 5;
            lblDni.Text = "Dni";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(179, 182);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(198, 22);
            txtNombreCliente.TabIndex = 7;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(179, 242);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(198, 22);
            txtApellidoCliente.TabIndex = 8;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(181, 118);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(198, 22);
            txtDniCliente.TabIndex = 10;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // dtpickerFechaNacimiento
            // 
            dtpickerFechaNacimiento.Location = new Point(179, 315);
            dtpickerFechaNacimiento.Name = "dtpickerFechaNacimiento";
            dtpickerFechaNacimiento.Size = new Size(249, 22);
            dtpickerFechaNacimiento.TabIndex = 13;
            dtpickerFechaNacimiento.ValueChanged += dtpickerFechaNacimiento_ValueChanged;
            // 
            // ldlFechaNacimiento
            // 
            ldlFechaNacimiento.AutoSize = true;
            ldlFechaNacimiento.Location = new Point(26, 320);
            ldlFechaNacimiento.Name = "ldlFechaNacimiento";
            ldlFechaNacimiento.Size = new Size(135, 17);
            ldlFechaNacimiento.TabIndex = 14;
            ldlFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // FrmAgregarCliente
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(456, 590);
            Controls.Add(ldlFechaNacimiento);
            Controls.Add(dtpickerFechaNacimiento);
            Controls.Add(lblError);
            Controls.Add(cmbGenero);
            Controls.Add(txtDniCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblDni);
            Controls.Add(lblGenero);
            Controls.Add(lblApellido);
            Controls.Add(lblNombreCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnBoton1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar cliente";
            Load += FormAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Button btnBoton1;
        protected Button btnCancelar;
        protected Label lblNombreCliente;
        protected Label lblApellido;
        protected Label lblGenero;
        protected Label lblDni;
        protected TextBox txtNombreCliente;
        protected TextBox txtApellidoCliente;
        protected TextBox txtDniCliente;
        protected ComboBox cmbGenero;
        protected Label lblError;
        protected DateTimePicker dtpickerFechaNacimiento;
        protected Label ldlFechaNacimiento;
    }
}
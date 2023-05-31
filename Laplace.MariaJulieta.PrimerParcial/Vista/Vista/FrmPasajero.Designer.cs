namespace Vista
{
    partial class FrmPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajero));
            grpDatosPersonalesPasajero = new GroupBox();
            lblError = new Label();
            ldlFechaNacimiento = new Label();
            dtpickerFechaNacimiento = new DateTimePicker();
            cmbGenero = new ComboBox();
            txtDniPasajero = new TextBox();
            txtApellidoPasajero = new TextBox();
            txtNombrePasajero = new TextBox();
            lblDni = new Label();
            lblGenero = new Label();
            lblApellido = new Label();
            lblNombreCliente = new Label();
            btnBoton1 = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            grpDatosPersonalesPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpDatosPersonalesPasajero
            // 
            grpDatosPersonalesPasajero.Controls.Add(lblError);
            grpDatosPersonalesPasajero.Controls.Add(ldlFechaNacimiento);
            grpDatosPersonalesPasajero.Controls.Add(dtpickerFechaNacimiento);
            grpDatosPersonalesPasajero.Controls.Add(cmbGenero);
            grpDatosPersonalesPasajero.Controls.Add(txtDniPasajero);
            grpDatosPersonalesPasajero.Controls.Add(txtApellidoPasajero);
            grpDatosPersonalesPasajero.Controls.Add(txtNombrePasajero);
            grpDatosPersonalesPasajero.Controls.Add(lblDni);
            grpDatosPersonalesPasajero.Controls.Add(lblGenero);
            grpDatosPersonalesPasajero.Controls.Add(lblApellido);
            grpDatosPersonalesPasajero.Controls.Add(lblNombreCliente);
            grpDatosPersonalesPasajero.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatosPersonalesPasajero.Location = new Point(12, 23);
            grpDatosPersonalesPasajero.Name = "grpDatosPersonalesPasajero";
            grpDatosPersonalesPasajero.Size = new Size(465, 357);
            grpDatosPersonalesPasajero.TabIndex = 0;
            grpDatosPersonalesPasajero.TabStop = false;
            grpDatosPersonalesPasajero.Text = "Datos Personales";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(8, 327);
            lblError.Name = "lblError";
            lblError.Size = new Size(302, 17);
            lblError.TabIndex = 15;
            lblError.Text = "Datos personales incorrectos. Vuelva a intentarlo";
            // 
            // ldlFechaNacimiento
            // 
            ldlFechaNacimiento.AutoSize = true;
            ldlFechaNacimiento.Location = new Point(6, 223);
            ldlFechaNacimiento.Name = "ldlFechaNacimiento";
            ldlFechaNacimiento.Size = new Size(135, 17);
            ldlFechaNacimiento.TabIndex = 24;
            ldlFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpickerFechaNacimiento
            // 
            dtpickerFechaNacimiento.Location = new Point(159, 217);
            dtpickerFechaNacimiento.Name = "dtpickerFechaNacimiento";
            dtpickerFechaNacimiento.Size = new Size(249, 22);
            dtpickerFechaNacimiento.TabIndex = 23;
            dtpickerFechaNacimiento.ValueChanged += dtpickerFechaNacimiento_ValueChanged;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(159, 273);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 25);
            cmbGenero.TabIndex = 22;
            // 
            // txtDniPasajero
            // 
            txtDniPasajero.Location = new Point(161, 36);
            txtDniPasajero.Name = "txtDniPasajero";
            txtDniPasajero.Size = new Size(198, 22);
            txtDniPasajero.TabIndex = 21;
            // 
            // txtApellidoPasajero
            // 
            txtApellidoPasajero.Location = new Point(159, 160);
            txtApellidoPasajero.Name = "txtApellidoPasajero";
            txtApellidoPasajero.Size = new Size(198, 22);
            txtApellidoPasajero.TabIndex = 20;
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.Location = new Point(159, 100);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(198, 22);
            txtNombrePasajero.TabIndex = 19;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(8, 41);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 17);
            lblDni.TabIndex = 18;
            lblDni.Text = "Dni";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(6, 276);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(53, 17);
            lblGenero.TabIndex = 17;
            lblGenero.Text = "Género";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 163);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 17);
            lblApellido.TabIndex = 16;
            lblApellido.Text = "Apellido";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(8, 100);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(56, 17);
            lblNombreCliente.TabIndex = 15;
            lblNombreCliente.Text = "Nombre";
            // 
            // btnBoton1
            // 
            btnBoton1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoton1.Location = new Point(78, 403);
            btnBoton1.Name = "btnBoton1";
            btnBoton1.Size = new Size(75, 26);
            btnBoton1.TabIndex = 13;
            btnBoton1.Text = "Boton1";
            btnBoton1.UseVisualStyleBackColor = true;
            btnBoton1.Click += btnBoton1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(337, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gifPasajero;
            pictureBox1.Location = new Point(521, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 251);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnBoton1);
            Controls.Add(grpDatosPersonalesPasajero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Pasajero";
            Load += FrmPasajero_Load;
            grpDatosPersonalesPasajero.ResumeLayout(false);
            grpDatosPersonalesPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosPersonalesPasajero;
        protected Label ldlFechaNacimiento;
        protected DateTimePicker dtpickerFechaNacimiento;
        protected ComboBox cmbGenero;
        protected TextBox txtDniPasajero;
        protected TextBox txtApellidoPasajero;
        protected TextBox txtNombrePasajero;
        protected Label lblDni;
        protected Label lblGenero;
        protected Label lblApellido;
        protected Label lblNombreCliente;
        protected Label lblError;
        protected Button btnBoton1;
        protected Button btnCancelar;
        private PictureBox pictureBox1;
    }
}
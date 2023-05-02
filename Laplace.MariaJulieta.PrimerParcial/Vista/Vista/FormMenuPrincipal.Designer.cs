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
            panelData.SuspendLayout();
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
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 722);
            ControlBox = false;
            Controls.Add(panelData);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú - Fly Airlines";
            Load += FormMenuPrincipal_Load;
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelData;
        private Button btnSalir;
        private Label lblFechaActual;
        private Label lblBienvenidaUser;
    }
}
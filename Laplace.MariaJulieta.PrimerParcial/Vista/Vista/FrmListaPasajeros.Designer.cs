namespace Vista
{
    partial class FrmListaPasajeros
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
            dtgListadoPasajeros = new DataGridView();
            lblVuelo = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListadoPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dtgListadoPasajeros
            // 
            dtgListadoPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListadoPasajeros.Location = new Point(12, 84);
            dtgListadoPasajeros.Name = "dtgListadoPasajeros";
            dtgListadoPasajeros.RowTemplate.Height = 25;
            dtgListadoPasajeros.Size = new Size(752, 271);
            dtgListadoPasajeros.TabIndex = 0;
            // 
            // lblVuelo
            // 
            lblVuelo.AutoSize = true;
            lblVuelo.Location = new Point(12, 57);
            lblVuelo.Name = "lblVuelo";
            lblVuelo.Size = new Size(110, 15);
            lblVuelo.TabIndex = 1;
            lblVuelo.Text = "Vuelo Seleccionado";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(364, 406);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmListaPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(lblVuelo);
            Controls.Add(dtgListadoPasajeros);
            Name = "FrmListaPasajeros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de pasajeros";
            Load += FrmListaPasajeros_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListadoPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgListadoPasajeros;
        private Label lblVuelo;
        private Button btnAceptar;
    }
}
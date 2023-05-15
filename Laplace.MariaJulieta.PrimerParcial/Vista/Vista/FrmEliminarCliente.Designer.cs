namespace Vista
{
    partial class FrmEliminarCliente
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
            SuspendLayout();
            // 
            // btnBoton1
            // 
            btnBoton1.Click += btnBoton1_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.DataSource = null;/*(new ESexo[] { ESexo.Femenino, ESexo.Masculino, ESexo.NoBinario });*/
            //cmbGenero.Items.AddRange(new object[] { ESexo.Femenino, ESexo.Masculino, ESexo.NoBinario });
            cmbGenero.Size = new Size(121, 25);
            // 
            // dtpickerFechaNacimiento
            // 
            dtpickerFechaNacimiento.MaxDate = new DateTime(2023, 5, 13, 0, 0, 0, 0);
            dtpickerFechaNacimiento.Value = new DateTime(2023, 5, 13, 0, 0, 0, 0);
            // 
            // FrmEliminarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 553);
            Name = "FrmEliminarCliente";
            Text = "Eliminar Cliente";
            Load += FrmEliminarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
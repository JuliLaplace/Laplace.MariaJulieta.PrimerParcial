namespace Vista
{
    partial class FrmEliminarPasajero
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
            // dtpickerFechaNacimiento
            // 
            dtpickerFechaNacimiento.MaxDate = new DateTime(2023, 5, 22, 0, 0, 0, 0);
            dtpickerFechaNacimiento.Value = new DateTime(2023, 5, 22, 0, 0, 0, 0);
            // 
            // cmbGenero
            // 
            cmbGenero.DataSource = null; /* (new ESexo[] { ESexo.Femenino, ESexo.Masculino, ESexo.NoBinario });
            cmbGenero.Items.AddRange(new object[] { ESexo.Femenino, ESexo.Masculino, ESexo.NoBinario });*/
            // 
            // btnBoton1
            // 
            btnBoton1.Text = "Agregar";
            // 
            // FrmEliminarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmEliminarPasajero";
            Text = "FrmEliminarPasajero";
            Load += FrmEliminarPasajero_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
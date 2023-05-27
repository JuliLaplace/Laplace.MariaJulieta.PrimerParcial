namespace Vista
{
    partial class FrmEliminarAvion
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
            panelAvion.SuspendLayout();
            SuspendLayout();
            // 
            // cboAviones
            // 
            cboAviones.DataSource = null;/*(new EAvion[] { EAvion.Airbus, EAvion.Boeing });
            //cboAviones.Items.AddRange(new object[] { EAvion.Airbus, EAvion.Boeing });*/
            // 
            // domUpDownAsientos
            // 
            domUpDownAsientos.Items.Add(200);
            domUpDownAsientos.Items.Add(150);
            domUpDownAsientos.Items.Add(100);
            domUpDownAsientos.SelectedIndex = 0;
            domUpDownAsientos.Text = "200";
            // 
            // btnBoton1
            // 
            btnBoton1.Text = "Agregar";
            // 
            // domUpDownCapacidadMaxima
            // 
            domUpDownCapacidadMaxima.Items.Add(200.6D);
            domUpDownCapacidadMaxima.Items.Add(150.5D);
            domUpDownCapacidadMaxima.Items.Add(100.3D);
            domUpDownCapacidadMaxima.SelectedIndex = 2;
            domUpDownCapacidadMaxima.Text = "100,3";
            // 
            // domUpDownCantidadBanios
            // 
            domUpDownCantidadBanios.Items.Add(4);
            domUpDownCantidadBanios.Items.Add(2);
            domUpDownCantidadBanios.SelectedIndex = 1;
            domUpDownCantidadBanios.Text = "2";
            // 
            // FrmEliminarAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Name = "FrmEliminarAvion";
            Text = "FrmEliminarAvion";
            Load += FrmEliminarAvion_Load;
            panelAvion.ResumeLayout(false);
            panelAvion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        FormLogin formularioLogin;
        public FormMenuPrincipal(Usuario usuario, FormLogin login)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            this.formularioLogin = login;
            this.lblBienvenidaUser.Visible = false;
        }


        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblFechaActual.Text = DateTime.Now.ToShortDateString();
            this.lblBienvenidaUser.Visible = true;
            this.lblBienvenidaUser.Text = "Bienvenido " + usuarioLogueado.Correo;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            formularioLogin.Show();
            formularioLogin.LimpiarPantalla();
            this.Close();
        }
    }
}

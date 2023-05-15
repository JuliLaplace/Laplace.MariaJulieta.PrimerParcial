using Entidades;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMensajeError.Visible = false;
            lblMensajeError.Text = "Error. Verifique datos ingresados";

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "admin@admin.com";
            this.txtContraseña.Text = "12345678";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = this.txtUsuario.Text;
            string contraseñaIngresada = this.txtContraseña.Text;
            this.lblMensajeError.Visible=false;

            if (ValidarDatosIngresados(usuarioIngresado, contraseñaIngresada))
            {
                Usuario unUsuario = Empresa.ValidarUnUsuario(usuarioIngresado, contraseñaIngresada);
                if (unUsuario is not null)
                {
                    FrmMenuPrincipal formMenu = new FrmMenuPrincipal(unUsuario, this);
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    this.lblMensajeError.Visible = true;
                    LimpiarPantalla();
                }
            }
            else
            {
                this.lblMensajeError.Visible = true;
                LimpiarPantalla();
            }
        }


        private static bool ValidarDatosIngresados(string usuario, string contraseña)
        {
            return Validador.ValidarQueEsTexto(usuario) && Validador.ValidarQueEsTexto(contraseña);
        }
        public void LimpiarPantalla()
        {
            this.txtUsuario.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
        }
    }
}
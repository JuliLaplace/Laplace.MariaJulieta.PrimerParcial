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
            this.txtContrase�a.Text = "12345678";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = this.txtUsuario.Text;
            string contrase�aIngresada = this.txtContrase�a.Text;
            this.lblMensajeError.Visible=false;

            if (ValidarDatosIngresados(usuarioIngresado, contrase�aIngresada))
            {
                Usuario unUsuario = Empresa.ValidarUnUsuario(usuarioIngresado, contrase�aIngresada);
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


        private static bool ValidarDatosIngresados(string usuario, string contrase�a)
        {
            return Validador.ValidarQueEsTexto(usuario) && Validador.ValidarQueEsTexto(contrase�a);
        }
        public void LimpiarPantalla()
        {
            this.txtUsuario.Text = string.Empty;
            this.txtContrase�a.Text = string.Empty;
        }
    }
}
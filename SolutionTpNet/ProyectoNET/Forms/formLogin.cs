using Signin;

namespace LogIn
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "admin" && this.txtPass.Text == "admin")
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseņas incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System.Text.RegularExpressions; // Para validar el email
using ProyectoNET;
using ProyectoNET.Forms;
using ProyectoNET.Controllers;
using Signin;

namespace LogIn
{
    internal partial class frmLogIn : Form
    {
        private readonly UserController _userController;

        public frmLogIn(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

            // Asociar el evento KeyDown a todos los TextBox
            txtUsuario.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPassword.KeyDown += new KeyEventHandler(txtKeyDown);
        }

        // Activar bot�n btnIngresar al presionar Enter
        private void txtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar el beep cuando se presiona Enter
                e.SuppressKeyPress = true;

                // Simular un clic en el bot�n btnIngresar
                btnIngresar.PerformClick();
            }
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo de usuario no puede estar vac�o.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo de contrase�a no puede estar vac�o.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el nombre de usuario sea un email v�lido
            //if (!EsEmailValido(txtUsuario.Text))
            //{
            //    MessageBox.Show("Por favor, ingresa un correo electr�nico v�lido.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // Validar la longitud de la contrase�a (m�nimo 6 caracteres)
            //if (txtPassword.Text.Length < 6)
            //{
            //    MessageBox.Show("La contrase�a debe tener al menos 6 caracteres.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            bool operation = await _userController.UserLogInAsync(txtUsuario.Text, txtPassword.Text);

            // Validaci�n de credenciales de inicio de sesi�n
            if (operation)
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el formulario principal abierto
                frmMain mainForm = (frmMain)this.MdiParent;

                if (mainForm != null)
                {
                    // Habilitar el Dashboard en el men� principal
                    mainForm.HabilitarMenus();
                }

                // Redirigir al frmMain y mostrar frmDashboard dentro del mismo
                frmDashboard dashboard = new frmDashboard();  // Crear el formulario de dashboard

                // Configurar frmDashboard como hijo de frmMain
                dashboard.MdiParent = mainForm;
                dashboard.WindowState = FormWindowState.Maximized;
                dashboard.Show();

                // Cerrar el formulario de login actual
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contrase�as incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para validar si el email tiene un formato correcto
        private bool EsEmailValido(string email)
        {
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // Vincular el evento de clic del bot�n al m�todo btnIngresar_Click
            btnIngresar.Click += new EventHandler(btnIngresar_Click);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

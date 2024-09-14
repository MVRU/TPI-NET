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

        // Activar botón btnIngresar al presionar Enter
        private void txtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar el beep cuando se presiona Enter
                e.SuppressKeyPress = true;

                // Simular un clic en el botón btnIngresar
                btnIngresar.PerformClick();
            }
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos no están vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el nombre de usuario sea un email válido
            //if (!EsEmailValido(txtUsuario.Text))
            //{
            //    MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // Validar la longitud de la contraseña (mínimo 6 caracteres)
            //if (txtPassword.Text.Length < 6)
            //{
            //    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            bool operation = await _userController.UserLogInAsync(txtUsuario.Text, txtPassword.Text);

            // Validación de credenciales de inicio de sesión
            if (operation)
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el formulario principal abierto
                frmMain mainForm = (frmMain)this.MdiParent;

                if (mainForm != null)
                {
                    // Habilitar el Dashboard en el menú principal
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
                MessageBox.Show("Usuario y/o contraseñas incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para validar si el email tiene un formato correcto
        private bool EsEmailValido(string email)
        {
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // Vincular el evento de clic del botón al método btnIngresar_Click
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

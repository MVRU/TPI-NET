using ProyectoNET;
using ProyectoNET.Forms;
using ProyectoNET.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNET.Properties;

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
            txtLegajo.KeyDown += new KeyEventHandler(txtKeyDown);
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

        // M�todo para guardar el ID de usuario en la configuraci�n
        private void SaveUserSession(string userId)
        {
            Settings.Default.UserId = userId;
            Settings.Default.MantenerSesion = checkBoxMantenerSesion.Checked;
            Settings.Default.Save();
        }

        // M�todo para cargar el ID de usuario de la configuraci�n
        private string LoadUserSession()
        {
            return Settings.Default.UserId;
        }

        // M�todo para borrar el ID de usuario de la configuraci�n
        private void ClearUserSession()
        {
            Settings.Default.UserId = string.Empty;
            Settings.Default.MantenerSesion = false;
            Settings.Default.Save();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("El campo legajo no puede estar vac�o.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo de contrase�a no puede estar vac�o.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la longitud de la contrase�a (m�nimo 8 caracteres)
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("La contrase�a debe tener al menos 8 caracteres.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool operation = await _userController.UserLogInAsync(txtLegajo.Text, txtPassword.Text);

            // Validaci�n de credenciales de inicio de sesi�n
            if (operation)
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Guardar sesi�n si el checkbox est� seleccionado
                SaveUserSession(txtLegajo.Text);

                // Obtener el formulario principal abierto
                MainForm mainForm = (MainForm)this.MdiParent;

                if (mainForm != null)
                {
                    // Pasar el ID del usuario al MainForm para habilitar los men�s
                    mainForm.SetUserId(txtLegajo.Text);
                    await mainForm.HabilitarMenusAsync(txtLegajo.Text);
                }

                // Mostrar el Dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.MdiParent = mainForm;
                dashboard.WindowState = FormWindowState.Maximized;
                dashboard.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Legajo y/o contrase�a incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // Vincular el evento de clic del bot�n al m�todo btnIngresar_Click
            btnIngresar.Click += new EventHandler(btnIngresar_Click);
        }

        private void checkBoxMantenerSesion_CheckedChanged(object sender, EventArgs e)
        {
            // Al cambiar el estado del checkbox, se actualiza la propiedad MantenerSesion
            Settings.Default.MantenerSesion = checkBoxMantenerSesion.Checked;
            Settings.Default.Save();
        }
    }
}

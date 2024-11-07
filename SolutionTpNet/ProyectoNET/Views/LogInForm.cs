using ProyectoNET;
using ProyectoNET.Forms;
using ProyectoNET.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                // Obtener el formulario principal abierto
                MainForm mainForm = (MainForm)this.MdiParent;

                if (mainForm != null)
                {
                    // Pasar el ID del usuario al MainForm para habilitar los men�s
                    mainForm.SetUserId(txtLegajo.Text);  // Usar el legajo como ID
                    await mainForm.HabilitarMenusAsync(txtLegajo.Text);
                }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void lblLegajo_Click(object sender, EventArgs e)
        { }
    }
}

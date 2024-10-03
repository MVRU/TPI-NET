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
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("El campo legajo no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la longitud de la contraseña (mínimo 8 caracteres)
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = await _userController.UserLogInAsync(txtLegajo.Text, txtPassword.Text);

            if (user != null)
            {
                if (chkRememberMe.Checked)
                {
                    ProyectoNET.Properties.Settings.Default.RememberMe = true;
                    ProyectoNET.Properties.Settings.Default.LastLegajo = txtLegajo.Text;
                    ProyectoNET.Properties.Settings.Default.Name = user.Name;
                    ProyectoNET.Properties.Settings.Default.LastName = user.LastName;
                    ProyectoNET.Properties.Settings.Default.Role = user.Role;
                    ProyectoNET.Properties.Settings.Default.Save();
                }
                else
                {
                    ProyectoNET.Properties.Settings.Default.RememberMe = false;
                    ProyectoNET.Properties.Settings.Default.LastLegajo = string.Empty;
                    ProyectoNET.Properties.Settings.Default.Name = string.Empty;
                    ProyectoNET.Properties.Settings.Default.LastName = string.Empty;
                    ProyectoNET.Properties.Settings.Default.Role = string.Empty;
                    ProyectoNET.Properties.Settings.Default.Save();
                }

                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainForm = (frmMain)this.MdiParent;
                if (mainForm != null)
                {
                    mainForm.HabilitarMenus();
                }

                var dashboardForm = new frmDashboard(user.Name, user.LastName, user.Role);
                dashboardForm.MdiParent = mainForm;
                dashboardForm.WindowState = FormWindowState.Maximized;
                dashboardForm.Show();

                this.Close();
            }

            else
            {
                MessageBox.Show("Legajo y/o contraseña incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // Vincular el evento de clic del botón al método btnIngresar_Click
            btnIngresar.Click += new EventHandler(btnIngresar_Click);
            pnlLogIn.Location = new Point((this.Width / 2) - (pnlLogIn.Width / 2), (this.Height / 2) - (pnlLogIn.Height / 2));
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

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

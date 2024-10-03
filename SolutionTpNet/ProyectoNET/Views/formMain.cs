using LogIn;
using ProyectoNET.Controllers;
using ProyectoNET.Forms;
using Signin;
using System;
using System.Windows.Forms;
using tomarAsistencia;
using Microsoft.Extensions.DependencyInjection;


namespace ProyectoNET
{
    internal partial class frmMain : Form
    {
        private readonly UserController _userController;

        private bool sesionIniciada = false;  // Variable para verificar si la sesión está iniciada

        public frmMain(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

            // Deshabilitar menús por defecto
            dashboardToolStripMenuItem.Enabled = false;
            asistenciaToolStripMenuItem.Visible = false;
            cursosToolStripMenuItem.Visible = false;
            configuraciónToolStripMenuItem.Visible = false;
            cuentaToolStripMenuItem.Visible = false;
            cerrarSesiónToolStripMenuItem.Visible = false;
        }

        // Método para habilitar los menús después de iniciar sesión correctamente
        public void HabilitarMenus()
        {
            dashboardToolStripMenuItem.Enabled = true;
            asistenciaToolStripMenuItem.Visible = true;
            cursosToolStripMenuItem.Visible = true;
            configuraciónToolStripMenuItem.Visible = true;
            cuentaToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem .Visible = true;
            iniciarSesionToolStripMenuItem.Visible = false;
            registrarseToolStripMenuItem.Visible = false;
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSignIn_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<frmSignIn>();
            formX.MdiParent = this;

            // Suscribirse al evento de registro exitoso
            formX.RegistroExitoso += FrmSignIn_RegistroExitoso;

            formX.Show();
        }

        private void FrmSignIn_RegistroExitoso(object sender, EventArgs e)
        {
            ((frmSignIn)sender).Close();
            MostrarFormularioLogin();
        }

        private void mnuLogIn_Click(object sender, EventArgs e)
        {
            MostrarFormularioLogin();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                HabilitarMenus();
                MostrarDashboard();
            }
            else
            {
                MostrarFormularioLogin();
            }
        }
        private void MostrarFormularioSignin()
        {
            MostrarFormularioSignin();
        }

        private void MostrarFormularioLogin()
        {

            var loginForm = Program.ServiceProvider.GetRequiredService<frmLogIn>();
            Point centerPoint = new Point((this.Width / 2) - (500 / 2), (this.Height / 2) - (400 / 2));
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void MostrarDashboard()
        {
            var name = Properties.Settings.Default.Name;
            var lastName = Properties.Settings.Default.LastName;
            var role = Properties.Settings.Default.Role;

            var formX = new frmDashboard(name, lastName, role);
            formX.MdiParent = this;
            formX.WindowState = FormWindowState.Maximized;
            formX.Show();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Manejar clics en menús
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Manejar clics en menús
        }

        private void guíaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Manejar clics en la guía de ayuda
        }

        private void asistenciaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<frmTomarAsistencia>();
            formX.MdiParent = this;
            formX.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<frmDashboard>();
            formX.MdiParent = this;
            formX.Show();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.LastLegajo = string.Empty;
            Properties.Settings.Default.Save();

            // Mostrar el formulario de inicio de sesión
            MostrarFormularioLogin();
        }

    }
}

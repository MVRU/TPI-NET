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
    internal partial class MainForm : Form
    {
        private readonly UserController _userController;

        private bool sesionIniciada = false;  // Variable para verificar si la sesión está iniciada

        public MainForm(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

            // Deshabilitar menús por defecto
            dashboardToolStripMenuItem.Enabled = false;
            asistenciaToolStripMenuItem.Visible = false;
            cursosToolStripMenuItem.Visible = false;
            configuraciónToolStripMenuItem.Visible = false;
            cuentaToolStripMenuItem.Visible = false;
        }

        // Método para habilitar los menús después de iniciar sesión correctamente
        public void HabilitarMenus()
        {
            dashboardToolStripMenuItem.Enabled = true;
            asistenciaToolStripMenuItem.Visible = true;
            cursosToolStripMenuItem.Visible = true;
            configuraciónToolStripMenuItem.Visible = true;
            cuentaToolStripMenuItem.Visible = true;
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

            // Mostrar el formulario de inicio de sesión
            var loginForm = Program.ServiceProvider.GetRequiredService<frmLogIn>();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void mnuLogIn_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<frmLogIn>();
            formX.MdiParent = this;
            formX.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // Manejar la carga del formulario
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
            var formX = Program.ServiceProvider.GetRequiredService<TakeAttendanceForm>();
            formX.MdiParent = this;
            formX.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<DashboardForm>();
            formX.MdiParent = this;
            formX.Show();
        }
    }
}

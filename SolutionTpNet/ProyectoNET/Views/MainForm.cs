using LogIn;
using ProyectoNET.Controllers;
using ProyectoNET.Forms;
using Signin;
using System;
using System.Windows.Forms;
using tomarAsistencia;
using Microsoft.Extensions.DependencyInjection;
using ProyectoNET.Models;
using ProyectoNET.Views;


namespace ProyectoNET
{
    internal partial class MainForm : Form
    {
        private readonly UserController _userController;

        private bool sesionIniciada = false;  // Variable para verificar si la sesión está iniciada

        private User _user;

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
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void mnuLogIn_Click(object sender, EventArgs e)
        {
            var formLogIn = Program.ServiceProvider.GetRequiredService<frmLogIn>();
            formLogIn.MdiParent = this;
            formLogIn.StartPosition = FormStartPosition.CenterScreen;
            formLogIn.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // Manejar la carga del formulario
            this.checkUserRole();
            var formLogIn = Program.ServiceProvider.GetRequiredService<frmLogIn>();
            formLogIn.MdiParent = this;
            formLogIn.StartPosition = FormStartPosition.CenterScreen;
            formLogIn.Show();
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
            formX.userAssign(_user);
            formX.StartPosition = FormStartPosition.CenterScreen;
            formX.Show();
        }
        public void userAssign(User u)
        {
            this._user = u;
        }

        public void checkUserRole()
        {
            if (this._user != null)
            {
                switch (this._user.Role.ToUpper())
                {
                    case "ADMIN":
                        misMateriasToolStripMenuItem.Visible = false;
                        materiasToolStripMenuItem.Visible = true;
                        break;

                    case "STUDENT":
                        tomarAsistenciaToolStripMenuItem.Visible = false;
                        crearNuevoCursoToolStripMenuItem.Visible = false;
                        materiasToolStripMenuItem.Visible = true;
                        break;

                    case "PROF":
                        crearNuevoCursoToolStripMenuItem.Visible = false;
                        misMateriasToolStripMenuItem.Visible = false;
                        materiasToolStripMenuItem.Visible = true;
                        break;
                }
            }
            else
            {
                dashboardToolStripMenuItem.Visible = false;
                materiasToolStripMenuItem.Visible = false;
            }
        }

        private void verTodasLasMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<SubjectsForm>();
            formX.MdiParent = this;
            formX.StartPosition = FormStartPosition.CenterScreen;
            formX.Show();
        }
    }
}

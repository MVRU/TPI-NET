using LogIn;
using ProyectoNET.Controllers;
using ProyectoNET.Forms;
using Signin;
using System;
using System.Windows.Forms;
using tomarAsistencia;
using Microsoft.Extensions.DependencyInjection;
using ProyectoNET.Views;
using ProyectoNET.Properties;

namespace ProyectoNET
{
    internal partial class MainForm : Form
    {
        private readonly UserController _userController;
        private bool sesionIniciada = false;  // Variable para verificar si la sesión está iniciada
        private string userIdActual;          // Variable para almacenar el ID del usuario actual
        private string userRoleActual;        // Variable para almacenar el rol del usuario actual

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
            usuariosToolStripMenuItem.Visible = false;
            cerrarSesiónToolStripMenuItem.Visible = false;
            gestionarHorariosToolStripMenuItem.Visible = false;

            // Cargar usuario de sesión solo si está guardado y si se debería mantener la sesión
            string savedUserId = LoadUserSession();
            string savedUserRole = LoadUserRole();
            if (!string.IsNullOrEmpty(savedUserId))
            {
                SetUser(savedUserId, savedUserRole);
                HabilitarMenusAsync(savedUserId);
            }
        }

        // Método para habilitar los menús después de iniciar sesión correctamente
        public async Task HabilitarMenusAsync(string userId)
        {
            if (!sesionIniciada) return; // Solo habilita menús si la sesión está iniciada
            var user = await _userController.GetUserByIdAsync(userId); // Usar el ID del usuario actual

            if (user != null && user.Role == "Admin") // Mostrar solo si el usuario es Admin
            {
                usuariosToolStripMenuItem.Visible = true; // Mostrar el menú solo si el usuario es Admin
            }

            if (user != null && (user.Role == "Admin" || user.Role == "Professor")) // Si es Admin o Professor
            {
                gestionarHorariosToolStripMenuItem.Visible = true;
                gestionarCursosToolStripMenuItem.Visible = true;
                gestionarAsignaturasToolStripMenuItem.Visible = true;
            }

            dashboardToolStripMenuItem.Enabled = true;
            asistenciaToolStripMenuItem.Visible = true;
            configuraciónToolStripMenuItem.Visible = true;
            cuentaToolStripMenuItem.Visible = true;
            cursosToolStripMenuItem.Visible = true;
            cerrarSesiónToolStripMenuItem.Visible = true;
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

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formX = Program.ServiceProvider.GetRequiredService<UsersManagementForm>();
            formX.SetCurrentUserId(userIdActual);
            formX.MdiParent = this;
            formX.Show();
        }

        // Al momento de iniciar sesión, se debe almacenar el ID y rol del usuario actual
        public void SetUser(string userId, string userRole)
        {
            userIdActual = userId;
            userRoleActual = userRole;
            sesionIniciada = true;  // Marcar que la sesión está iniciada
            cerrarSesiónToolStripMenuItem.Visible = true;  // Mostrar la opción de cerrar sesión
        }

        // Métodos para cargar y guardar el ID y rol de sesión en la configuración
        private string LoadUserSession()
        {
            if (Settings.Default.MantenerSesion)
            {
                return Settings.Default.UserId;
            }
            return string.Empty;
        }

        private string LoadUserRole()
        {
            if (Settings.Default.MantenerSesion)
            {
                return Settings.Default.UserRole;
            }
            return string.Empty;
        }

        private void ClearUserSession()
        {
            Settings.Default.UserId = string.Empty;
            Settings.Default.UserRole = string.Empty;
            Settings.Default.MantenerSesion = false;
            Settings.Default.Save();
        }

        // Método para cerrar la sesión
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cerrar todos los formularios hijos abiertos, excepto el MainForm
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this)
                    {
                        childForm.Close();
                    }
                }

                // Limpiar el ID y rol de usuario de la sesión
                ClearUserSession();
                userIdActual = null;
                userRoleActual = null;
                sesionIniciada = false;

                // Deshabilitar los menús que estaban disponibles solo para usuarios autenticados
                dashboardToolStripMenuItem.Enabled = false;
                asistenciaToolStripMenuItem.Visible = false;
                cursosToolStripMenuItem.Visible = false;
                configuraciónToolStripMenuItem.Visible = false;
                cuentaToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                cerrarSesiónToolStripMenuItem.Visible = false;
                cursosToolStripMenuItem.Visible = false;

                // Restaurar la visibilidad de las opciones de iniciar sesión y registrarse
                iniciarSesionToolStripMenuItem.Visible = true;
                registrarseToolStripMenuItem.Visible = true;

                MessageBox.Show("Sesión cerrada correctamente.", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario de inicio de sesión
                var loginForm = Program.ServiceProvider.GetRequiredService<frmLogIn>();
                loginForm.MdiParent = this;
                loginForm.Show();
            }
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profileForm = Program.ServiceProvider.GetRequiredService<ProfileForm>();
            profileForm.MdiParent = this;
            profileForm.Show();
        }

        private void gestionarAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var subjectManagementForm = Program.ServiceProvider.GetRequiredService<SubjectManagementForm>();
            subjectManagementForm.MdiParent = this;
            subjectManagementForm.Show();
        }

        private void gestionarHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduleManagementForm = Program.ServiceProvider.GetRequiredService<ScheduleManagementForm>();
            scheduleManagementForm.MdiParent = this;
            scheduleManagementForm.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var courseManagementForm = Program.ServiceProvider.GetRequiredService<CourseManagementForm>();
            courseManagementForm.MdiParent = this;
            courseManagementForm.Show();
        }

        private void gestionarMatriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var enrollmentManagementForm = Program.ServiceProvider.GetRequiredService<EnrollmentManagementForm>();
            enrollmentManagementForm.MdiParent = this;
            enrollmentManagementForm.Show();
        }
    }
}

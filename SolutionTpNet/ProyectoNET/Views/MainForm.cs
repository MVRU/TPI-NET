﻿using LogIn;
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

            if (user != null && user.Role == "Admin")
            {
                usuariosToolStripMenuItem.Visible = true; // Mostrar el menú solo si el usuario es Admin
            }

            dashboardToolStripMenuItem.Enabled = true;
            asistenciaToolStripMenuItem.Visible = true;
            cursosToolStripMenuItem.Visible = true;
            configuraciónToolStripMenuItem.Visible = true;
            cuentaToolStripMenuItem.Visible = true;
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

        private void menúToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void guíaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e) { }

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
    }
}

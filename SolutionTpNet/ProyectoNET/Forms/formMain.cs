using LogIn;
using ProyectoNET.Forms;
using Signin;
using System;
using System.Windows.Forms;
using tomarAsistencia;

namespace ProyectoNET
{
    public partial class frmMain : Form
    {

        private bool sesionIniciada = false;  // Variable para verificar si la sesión está iniciada

        public frmMain()
        {
            InitializeComponent();

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
            frmSignIn formX = new frmSignIn();
            formX.MdiParent = this;

            // Suscribirse al evento de registro exitoso
            formX.RegistroExitoso += FrmSignIn_RegistroExitoso;

            formX.Show();
        }

        private void FrmSignIn_RegistroExitoso(object sender, EventArgs e)
        {
            ((frmSignIn)sender).Close();

            // Mostrar el formulario de inicio de sesión
            frmLogIn loginForm = new frmLogIn();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void mnuLogIn_Click(object sender, EventArgs e)
        {
            frmLogIn formX = new frmLogIn();
            formX.MdiParent = this;
            formX.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guíaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asistenciaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTomarAsistencia formX = new frmTomarAsistencia();
            formX.MdiParent = this;
            formX.Show();

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDashboard formX = new frmDashboard();
            formX.MdiParent = this;
            formX.Show();
        }
    }
}

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenLogInForm();
        }

        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void OpenLogInForm()
        {
            CloseAllChildForms();

            LogInForm logInForm = new LogInForm
            {
                MdiParent = this
            };
            logInForm.Show();
        }

        private void OpenSignInForm()
        {
            CloseAllChildForms();

            SignInForm signInForm = new SignInForm
            {
                MdiParent = this
            };
            signInForm.Show();
        }

        private void OpenDashboardForm()
        {
            CloseAllChildForms();

            DashboardForm dashboardForm = new DashboardForm
            {
                MdiParent = this
            };
            dashboardForm.Show();
        }

        private void OpenUsersManagementForm()
        {
            CloseAllChildForms();

            UsersManagementForm usersManagementForm = new UsersManagementForm
            {
                MdiParent = this
            };
            usersManagementForm.Show();
        }

        private void OpenHelpForm()
        {
            CloseAllChildForms();

            HelpForm helpForm = new HelpForm
            {
                MdiParent = this
            };
            helpForm.Show();
        }

        private void OpenAboutForm()
        {
            CloseAllChildForms();

            AboutForm aboutForm = new AboutForm
            {
                MdiParent = this
            };
            aboutForm.Show();
        }

        // Cambiar color de fondo de MainForm a blanco
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(248, 248, 248); // Color #f8f8f8
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLogInForm();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSignInForm();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDashboardForm();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUsersManagementForm();
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelpForm();
        }

        private void sobreCheckInUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }
    }
}
namespace DesktopApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void linkPasswordForgotten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.MdiParent is MainForm mainForm)
            {
                SignInForm signInForm = new SignInForm
                {
                    MdiParent = mainForm
                };
                signInForm.Show();
            }

            this.Close();
        }
    }
}
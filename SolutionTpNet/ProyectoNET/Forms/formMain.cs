using LogIn;
using Signin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tomarAsistencia;
using static System.Windows.Forms.DataFormats;

namespace ProyectoNET
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuAsistencia_Click(object sender, EventArgs e)
        {
            frmTomarAsistencia formX = new frmTomarAsistencia();
            formX.MdiParent = this;
            formX.Show();
        }

        private void mnuSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn formX = new frmSignIn();
            formX.MdiParent = this;
            formX.Show();
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
    }
}

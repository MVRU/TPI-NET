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
    public partial class formMain : Form
    {
        public formMain()
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
            formSignin formX = new formSignin();
            formX.MdiParent = this;
            formX.Show();
        }

        private void mnuLogIn_Click(object sender, EventArgs e)
        {
            formLogin formX = new formLogin();
            formX.MdiParent = this;
            formX.Show();
        }

    }
}

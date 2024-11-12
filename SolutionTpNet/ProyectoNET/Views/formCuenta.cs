using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNET.Models;

namespace ProyectoNET
{
    public partial class formCuenta : Form
    {
        public User user;
        public formCuenta()
        {
            InitializeComponent();
        }

        public void userAssign(User u)
        {
            this.user = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtFile.Text = user.File;
            txtRole.Text = user.Role;

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AccountForm : Form
    {
        private User _user;
        public AccountForm()
        {
            InitializeComponent();
        }

        public void userAssign(User u)
        {
            this._user = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = _user.Name;
            txtLastName.Text = _user.LastName;
            txtFile.Text = _user.File;
            txtRole.Text = _user.Role;

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }
    }
}

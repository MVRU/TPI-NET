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

namespace ProyectoNET.Forms
{
    public partial class frmDashboard : Form
    {
        private User user;
        public frmDashboard()
        {
            InitializeComponent();
        }

        public void userAssign(User u)
        {
            this.user = u;
            lblBienvenida.Text = lblBienvenida.Text + u.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.checkUserRole();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        public void checkUserRole()
        {
            switch (this.user.Role.ToUpper())
            {
                case "ADMIN":
                    lbl2Dashboard.Text = "Listado de alumnos y profesores";
                    break;
                case "STUDENT":
                    lbl2Dashboard.Text = "Porcentaje de asistencia por curso";
                    break;
                case "PROF":
                    lbl2Dashboard.Text = "Estudiantes con problema de asistencia";
                    break;
            }
        }
    }
}

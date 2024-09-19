using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNET.Forms
{
    public partial class frmDashboard : Form
    {
        private string _nombre;
        private string _apellido;
        private string _rol;

        public frmDashboard(string nombre, string apellido, string rol)
        {
            InitializeComponent();
            _nombre = nombre;
            _apellido = apellido;
            _rol = rol;
            ConfigurarBienvenida();
        }

        private void ConfigurarBienvenida()
        {
            if (_rol == "Professor")
            {
                lblBienvenida.Text = $"Bienvenido/a de vuelta, Prof. {_nombre} {_apellido}";
            }
            else
            {
                lblBienvenida.Text = $"Bienvenido/a de vuelta, {_nombre} {_apellido}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}

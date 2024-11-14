using System;
using System.Windows.Forms;
using ProyectoNET.Properties;  // Asegúrate de tener el espacio de nombres correcto para Settings

namespace ProyectoNET.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Obtener el rol del usuario desde los Settings
            string userRole = Settings.Default.UserRole; // Esto debe coincidir con la propiedad en Settings.settings

            // Asignar el mensaje adecuado según el rol del usuario
            string roleMessage = string.Empty;

            switch (userRole)
            {
                case "Student":
                    roleMessage = "¡Bienvenido de vuelta, estudiante!";
                    break;
                case "Professor":
                    roleMessage = "¡Bienvenido de vuelta, profesor!";
                    break;
                case "Admin":
                    roleMessage = "¡Bienvenido de vuelta, admin!";
                    break;
                default:
                    roleMessage = "¡Bienvenido de vuelta!";
                    break;
            }

            // Establecer el texto del label
            lblBienvenida.Text = roleMessage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede ser eliminado si no lo necesitas
        }
    }
}

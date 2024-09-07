using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomarAsistencia
{
    public partial class frmTomarAsistencia : Form
    {
        public frmTomarAsistencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPresentes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmTomarAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void pnlScroll_Paint(object sender, PaintEventArgs e)
        {

            // Obtén todos los controles dentro del panel
            Control[] controles = pnlTomarAsistencia.Controls.Cast<Control>().ToArray();

            if (controles.Length == 0)
                return; // No hay controles, salir de la función

            // Encuentra los límites de todos los controles (es decir, el área total que ocupan)
            int leftMost = controles.Min(c => c.Left);
            int topMost = controles.Min(c => c.Top);
            int rightMost = controles.Max(c => c.Right);
            int bottomMost = controles.Max(c => c.Bottom);

            // Calcula el tamaño total ocupado por los controles
            int totalWidth = rightMost - leftMost;
            int totalHeight = bottomMost - topMost;

            // Calcula las nuevas coordenadas para centrar el área total ocupada por los controles
            int offsetX = (pnlTomarAsistencia.ClientSize.Width - totalWidth) / 2 - leftMost;
            int offsetY = (pnlTomarAsistencia.ClientSize.Height - totalHeight) / 2 - topMost;

            // Desplaza cada control según los cálculos
            foreach (var control in controles)
            {
                control.Location = new Point(control.Left + offsetX, control.Top + offsetY);
            }

        }
    }
}

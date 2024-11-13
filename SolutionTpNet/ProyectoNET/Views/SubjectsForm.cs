using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNET.Controllers;
using ProyectoNET.Models;

namespace ProyectoNET.Views
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private async void GetAllAndLoad()
        {
            IEnumerable<Subject> subjects = null;
            //subjects = await _subjectController.GetAllSubjectsAsync();

            this.subject_dataGrid.DataSource = subjects;

            if (this.subject_dataGrid.Rows.Count > 0)
            {
                this.subject_dataGrid.Rows[0].Selected = true;
                this.delete_btn.Enabled = true;
                this.update_btn.Enabled = true;
            }
            else
            {
                this.delete_btn.Enabled = false;
                this.update_btn.Enabled = false;
            }

        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}

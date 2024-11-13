using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class CourseManagementForm : Form
    {
        private readonly CourseController _courseController;

        public CourseManagementForm(CourseController courseController)
        {
            InitializeComponent();
            _courseController = courseController;

            // Configurar el DataGridView
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.MultiSelect = false;

            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Course> courses = _courseController.GetAllCourses();
            dataGridViewCourses.DataSource = courses;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var addCourseForm = new EditCourseForm(_courseController);
            addCourseForm.OnCourseAddedOrEdited += LoadCourses; // Recargar los cursos al agregar o editar
            addCourseForm.ShowDialog();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un curso para editar.");
                return;
            }

            var selectedRow = dataGridViewCourses.SelectedRows[0];
            var courseId = (int)selectedRow.Cells["Id"].Value;

            var editCourseForm = new EditCourseForm(_courseController, courseId);
            editCourseForm.OnCourseAddedOrEdited += LoadCourses; // Recargar los cursos al agregar o editar
            editCourseForm.ShowDialog();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un curso para eliminar.");
                return;
            }

            var selectedRow = dataGridViewCourses.SelectedRows[0];
            var courseId = (int)selectedRow.Cells["Id"].Value;

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este curso?", "Eliminar Curso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _courseController.DeleteCourse(courseId);
                LoadCourses();
            }
        }
    }
}

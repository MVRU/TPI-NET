﻿using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class CourseManagementForm : Form
    {
        private readonly CourseController _courseController;
        private readonly SubjectController _subjectController;

        public CourseManagementForm(CourseController courseController, SubjectController subjectController)
        {
            InitializeComponent();
            _courseController = courseController;
            _subjectController = subjectController;

            // Configurar el DataGridView
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.MultiSelect = false;

            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Course> courses = _courseController.GetAllCourses(); // Ahora el Course incluye SubjectDescription calculado

            // Desactivar la generación automática de columnas
            dataGridViewCourses.AutoGenerateColumns = false;

            // Asignar los cursos al DataGridView
            dataGridViewCourses.DataSource = courses;

            // Limpiar cualquier columna existente
            dataGridViewCourses.Columns.Clear();

            // Agregar las columnas manualmente
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Year",
                HeaderText = "Año"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Fecha de Inicio"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "Fecha de Fin"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quota",
                HeaderText = "Cupo"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubjectDescription", // Mostrar la descripción calculada
                HeaderText = "Asignatura"
            });

            // Configurar todas las columnas para que se ajusten automáticamente a su contenido
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Ajustar las columnas
            AdjustColumnWidths();
        }

        private void AdjustColumnWidths()
        {
            foreach (DataGridViewColumn column in dataGridViewCourses.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var addCourseForm = new EditCourseForm(_courseController, _subjectController);
            addCourseForm.OnCourseAddedOrEdited += LoadCourses;
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

            var editCourseForm = new EditCourseForm(_courseController, _subjectController, courseId);
            editCourseForm.OnCourseAddedOrEdited += LoadCourses;
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

        private void CourseManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
using Microsoft.Extensions.DependencyInjection;
using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class CourseManagementForm : Form
    {
        private readonly CourseController _courseController;
        private readonly SubjectController _subjectController;
        private readonly ScheduleController _scheduleController;
        private readonly AttendanceController _attendanceController;
        private readonly EnrollmentController _enrollmentController;

        public CourseManagementForm(CourseController courseController, SubjectController subjectController, ScheduleController scheduleController, AttendanceController attendanceController, EnrollmentController enrollmentController)
        {
            InitializeComponent();
            _courseController = courseController;
            _subjectController = subjectController;
            _scheduleController = scheduleController;
            _attendanceController = attendanceController; 
            _enrollmentController = enrollmentController;

            // Configurar el DataGridView
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.MultiSelect = false;

            LoadCourses();
        }

        private void LoadCourses()
        {
            // Obtener los cursos con sus horarios asociados
            var coursesWithSchedules = _courseController.GetAllCourses()
                .Select(course => new
                {
                    course.Id,
                    course.Year,
                    course.StartDate,
                    course.EndDate,
                    course.Quota,
                    // Verificar si SubjectId no es nulo antes de pasarlo al método
                    SubjectDescription = course.SubjectId.HasValue
                        ? _subjectController.GetSubjectDescriptionById(course.SubjectId.Value) // Usar .Value para acceder al valor de int?
                        : "N/A", // Si es nulo, asignar "N/A"
                    ScheduleText = course.Schedules.Any() ? string.Join(", ", course.Schedules.Select(s => s.DisplayText)) : "N/A" // Concatenar los horarios en formato legible
                })
                .ToList();

            // Desactivar la generación automática de columnas
            dataGridViewCourses.AutoGenerateColumns = false;

            // Asignar los cursos con horarios al DataGridView
            dataGridViewCourses.DataSource = coursesWithSchedules;

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
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ScheduleText", // Mostrar los horarios concatenados
                HeaderText = "Horario"
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
            var addCourseForm = new EditCourseForm(_courseController, _subjectController, _scheduleController);
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

            var editCourseForm = new EditCourseForm(_courseController, _subjectController, _scheduleController, courseId);
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
            // Este evento se puede utilizar si necesitas hacer alguna acción al cargar el formulario
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un curso para generar el reporte.");
                return;
            }

            // Obtener el ID del curso seleccionado
            var selectedRow = dataGridViewCourses.SelectedRows[0];
            var courseId = (int)selectedRow.Cells["Id"].Value;

            // Crear la instancia manualmente y pasarle las dependencias y el courseId
            var courseReportForm = new CourseReportForm(courseId, _courseController, _enrollmentController, _attendanceController);

            // Mostrar el formulario de reportes
            courseReportForm.ShowDialog();
        }
    }
}

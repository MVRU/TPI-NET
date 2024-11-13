using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditCourseForm : Form
    {
        private readonly CourseController _courseController;
        private int? _courseId;

        public event Action OnCourseAddedOrEdited;

        public EditCourseForm(CourseController courseController)
        {
            InitializeComponent();
            _courseController = courseController;
        }

        public EditCourseForm(CourseController courseController, int courseId) : this(courseController)
        {
            _courseId = courseId;
            LoadCourseDetails(courseId);
        }

        private void LoadCourseDetails(int courseId)
        {
            var course = _courseController.GetCourseById(courseId);
            if (course != null)
            {
                // Llenar los controles con los detalles del curso
                txtYear.Text = course.Year.ToString();
                dtpStartDate.Value = course.StartDate;
                dtpEndDate.Value = course.EndDate;
                txtQuota.Text = course.Quota.ToString();

                // Si el curso tiene un SubjectId, seleccionarlo en el combo box
                if (course.SubjectId.HasValue)
                {
                    cmbSubject.SelectedValue = course.SubjectId.Value;
                }
                else
                {
                    cmbSubject.SelectedIndex = -1; // No asignar ningún valor si es null
                }
            }
            else
            {
                MessageBox.Show("Curso no encontrado.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int year = int.Parse(txtYear.Text);
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            int quota = int.Parse(txtQuota.Text);

            // Verificar si el campo Subject es obligatorio o puede ser nulo
            int? subjectId = cmbSubject.SelectedIndex >= 0 ? (int?)cmbSubject.SelectedValue : null;

            if (_courseId.HasValue)
            {
                // Actualizar el curso
                _courseController.UpdateCourse(_courseId.Value, year, startDate, endDate, quota, subjectId);
            }
            else
            {
                // Crear un nuevo curso
                _courseController.CreateCourse(year, startDate, endDate, quota, subjectId);
            }

            // Llamar al evento para actualizar la vista principal
            OnCourseAddedOrEdited?.Invoke();
            this.Close();
        }
    }
}

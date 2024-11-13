using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditCourseForm : Form
    {
        private readonly CourseController _courseController;
        private readonly SubjectController _subjectController;
        private int? _courseId;

        public event Action OnCourseAddedOrEdited;

        public EditCourseForm(CourseController courseController, SubjectController subjectController)
        {
            InitializeComponent();
            _courseController = courseController;
            _subjectController = subjectController;

            LoadSubjects();
            ConfigureControls();
        }

        public EditCourseForm(CourseController courseController, SubjectController subjectController, int courseId)
            : this(courseController, subjectController)
        {
            _courseId = courseId;
            LoadCourseDetails(courseId);
        }

        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubjects().ToList();

            // Agregar opción "N/A" al inicio de la lista de asignaturas
            subjects.Insert(0, new Subject { Id = 0, Description = "N/A" });

            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "Description";
            cmbSubject.ValueMember = "Id";
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecer "N/A" como la opción seleccionada por defecto
            cmbSubject.SelectedIndex = 0;
        }

        private void ConfigureControls()
        {
            // Bloquear txtYear para que no sea editable
            txtYear.ReadOnly = true;

            // Establecer el valor predeterminado de txtYear al año actual si no se ha asignado StartDate
            if (dtpStartDate.Value == null || dtpStartDate.Value == DateTime.MinValue)
            {
                txtYear.Text = DateTime.Now.Year.ToString();
            }

            dtpStartDate.ValueChanged += (s, e) => UpdateYearBasedOnStartDate();
            dtpStartDate.Format = DateTimePickerFormat.Short; // Para que solo se muestre la fecha, no la hora
            dtpEndDate.Format = DateTimePickerFormat.Short;   // Lo mismo para la fecha de fin
        }

        private void UpdateYearBasedOnStartDate()
        {
            txtYear.Text = dtpStartDate.Value.Year.ToString();
        }

        private void LoadCourseDetails(int courseId)
        {
            var course = _courseController.GetCourseById(courseId);
            if (course != null)
            {
                txtYear.Text = course.Year.ToString();
                dtpStartDate.Value = course.StartDate;
                dtpEndDate.Value = course.EndDate;
                txtQuota.Text = course.Quota.ToString();

                // Si no tiene asignatura, seleccionar "N/A"
                cmbSubject.SelectedValue = course.SubjectId ?? 0;  // 0 es el Id de "N/A"
            }
            else
            {
                MessageBox.Show("Curso no encontrado.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtQuota.Text) || cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int year;
            if (!int.TryParse(txtYear.Text, out year))
            {
                MessageBox.Show("El año no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Validar que la Fecha de Fin sea posterior a la Fecha de Inicio
            if (endDate <= startDate)
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Evitar guardar el curso si las fechas no son válidas
            }

            int quota;
            if (!int.TryParse(txtQuota.Text, out quota) || quota <= 1)
            {
                MessageBox.Show("La cuota debe ser mayor a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? subjectId = cmbSubject.SelectedIndex > 0 ? (int?)cmbSubject.SelectedValue : null;

            // Si ya existe un ID de curso, actualizamos, de lo contrario, creamos un nuevo curso
            try
            {
                if (_courseId.HasValue)
                {
                    _courseController.UpdateCourse(_courseId.Value, year, startDate, endDate, quota, subjectId);
                }
                else
                {
                    _courseController.CreateCourse(year, startDate, endDate, quota, subjectId);
                }

                // Notificar que se agregó o editó el curso y cerrar el formulario
                OnCourseAddedOrEdited?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al guardar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

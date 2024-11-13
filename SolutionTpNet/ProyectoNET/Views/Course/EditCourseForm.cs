using Microsoft.EntityFrameworkCore;
using ProyectoNET.Controllers;
using ProyectoNET.Models;

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
            btnAssignSchedule.Visible = false;

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
                btnAssignSchedule.Visible = true; // Mostrar el botón de asignación de horarios solo si es un curso existente
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
                return;
            }

            int quota;
            if (!int.TryParse(txtQuota.Text, out quota))
            {
                MessageBox.Show("La cuota no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? subjectId = cmbSubject.SelectedIndex > 0 ? (int?)cmbSubject.SelectedValue : null;

            // Verificar que el SubjectId seleccionado sea válido si no es N/A
            if (subjectId.HasValue && !_subjectController.SubjectExists(subjectId.Value))
            {
                MessageBox.Show("El SubjectId proporcionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Si ya existe un ID de curso, actualizamos, de lo contrario, creamos un nuevo curso
                if (_courseId.HasValue)
                {
                    _courseController.UpdateCourse(_courseId.Value, year, startDate, endDate, quota, subjectId);
                }
                else
                {
                    _courseId = _courseController.CreateCourse(year, startDate, endDate, quota, subjectId);
                }

                // Notificar que se agregó o editó el curso
                OnCourseAddedOrEdited?.Invoke();

                // Solo mostrar el botón AssignSchedule si el curso fue creado correctamente
                if (_courseId.HasValue)
                {
                    btnAssignSchedule.Visible = true; // Mostrar el botón solo si el curso fue creado o editado correctamente
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DbUpdateException dbEx) // Captura errores de Entity Framework
            {
                MessageBox.Show($"Hubo un error al guardar el curso: {dbEx.Message}\nDetalles: {dbEx.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al guardar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssignSchedule_Click(object sender, EventArgs e)
        {
            // Verificar si el curso es nuevo o ya existe
            if (_courseId.HasValue)
            {
                // Si el curso ya tiene un ID (es existente), simplemente abrir el formulario de asignación de horarios
                var course = _courseController.GetCourseById(_courseId.Value);
                if (course != null)
                {
                    var assignScheduleForm = new AssignScheduleForm(course);
                    assignScheduleForm.ShowDialog(); // Mostrar el formulario de asignación de horarios
                }
                else
                {
                    MessageBox.Show("El curso no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede asignar horarios a un curso nuevo. Guarde el curso primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

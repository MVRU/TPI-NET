using ProyectoNET.Models;
using ProyectoNET.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ProyectoNET.Views
{
    public partial class EditEnrollmentForm : Form
    {
        private readonly UniversityContext _context;
        private Enrollment _enrollmentToEdit;
        private int? _courseId;

        // Evento que se dispara cuando se crea o edita una matrícula
        public event Action OnEnrollmentCreatedOrEdited;

        // Constructor para crear nueva matrícula
        public EditEnrollmentForm(UniversityContext context, Enrollment enrollment = null, int? courseId = null)
        {
            _context = context;
            _enrollmentToEdit = enrollment;
            _courseId = courseId;
            InitializeComponent();

            this.Text = enrollment == null ? "Crear Matrícula" : "Editar Matrícula";
            LoadCourses();
            LoadStatuses();
            FillEnrollmentDetails();
        }

        // Cargar la lista de cursos
        private void LoadCourses()
        {
            try
            {
                var courses = _context.Courses.Where(c => c.StartDate <= dtpEnrollmentDate.Value).ToList();  // Usar el DBContext para cargar cursos
                if (courses == null || !courses.Any())
                {
                    MessageBox.Show("No se encontraron cursos disponibles para esta fecha.");
                    return;
                }

                cmbCourses.DataSource = courses;
                cmbCourses.DisplayMember = "SubjectDescription";
                cmbCourses.ValueMember = "Id";

                // Si estamos editando, seleccionar el curso de la matrícula
                if (_enrollmentToEdit != null)
                {
                    cmbCourses.SelectedValue = _enrollmentToEdit.CourseId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los cursos: {ex.Message}");
            }
        }

        // Cargar la lista de estados desde el repositorio
        private void LoadStatuses()
        {
            try
            {
                var statuses = _context.Statuses.ToList();  // Usar el DBContext para cargar estados
                if (statuses == null || !statuses.Any())
                {
                    MessageBox.Show("No se encontraron estados disponibles.");
                    return;
                }

                cmbStatus.DataSource = statuses;
                cmbStatus.DisplayMember = "Description"; // Mostrar la descripción
                cmbStatus.ValueMember = "Id"; // Usar el ID como valor

                // Si estamos editando, seleccionar el estado de la matrícula
                if (_enrollmentToEdit != null && _enrollmentToEdit.Status != null)
                {
                    cmbStatus.SelectedValue = _enrollmentToEdit.Status.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estados: {ex.Message}");
            }
        }

        // Llenar los detalles de la matrícula para editar
        private void FillEnrollmentDetails()
        {
            if (_enrollmentToEdit != null)
            {
                txtStudentFile.Text = _enrollmentToEdit.Student.File.ToString();
                dtpEnrollmentDate.Value = _enrollmentToEdit.EnrollmentDate;
                cmbCourses.SelectedValue = _enrollmentToEdit.CourseId; // Llenar el ComboBox con el curso
                cmbStatus.SelectedValue = _enrollmentToEdit.Status?.Id; // Llenar el estado de la matrícula con el ID del estado
            }
        }

        // Validación del número de legajo del estudiante
        private bool IsValidStudentFile(string studentFile)
        {
            // El número de legajo debe ser un número entero positivo
            return int.TryParse(studentFile, out _);
        }

        // Evento al hacer clic en el botón "Guardar"
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var studentFile = txtStudentFile.Text?.Trim(); // Asegurarse de que no sea null o vacío

                if (string.IsNullOrEmpty(studentFile))
                {
                    MessageBox.Show("El número de legajo no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var courseId = (cmbCourses.SelectedValue != null) ? (int)cmbCourses.SelectedValue : 0; // Validar si se ha seleccionado un curso
                var statusItem = cmbStatus.SelectedItem as Status; // Validar si se seleccionó un estado

                if (statusItem == null || courseId <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un curso y un estado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidStudentFile(studentFile))
                {
                    MessageBox.Show("El legajo debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si ya existe un estudiante con el legajo
                var user = await _context.Users.FirstOrDefaultAsync(u => u.File == studentFile);
                if (user == null)
                {
                    MessageBox.Show("El legajo ingresado no corresponde a un usuario válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var statusId = statusItem.Id;
                var enrollmentDate = dtpEnrollmentDate.Value; // La fecha de inscripción

                // Verificar si la fecha de inscripción es futura
                if (enrollmentDate > DateTime.Now)
                {
                    MessageBox.Show("La fecha de inscripción no puede ser en el futuro.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si ya existe una matrícula
                var existingEnrollment = await _context.Enrollments
                    .FirstOrDefaultAsync(e => e.Student.File == studentFile && e.CourseId == courseId && e.EnrollmentDate == enrollmentDate);

                if (existingEnrollment != null && existingEnrollment.Id != _enrollmentToEdit?.Id)
                {
                    MessageBox.Show("Ya existe una matrícula para este estudiante en este curso con la misma fecha.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear o editar la matrícula
                if (_enrollmentToEdit != null)
                {
                    _enrollmentToEdit.CourseId = courseId;
                    _enrollmentToEdit.StatusId = statusId;
                    _enrollmentToEdit.EnrollmentDate = enrollmentDate;

                    _context.Enrollments.Update(_enrollmentToEdit);  // Actualizamos el registro
                    await _context.SaveChangesAsync();  // Guardamos los cambios
                    MessageBox.Show("Matrícula editada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newEnrollment = new Enrollment
                    {
                        CourseId = courseId,
                        StatusId = statusId,
                        EnrollmentDate = enrollmentDate,
                        StudentId = user.File // Asociamos el estudiante
                    };

                    _context.Enrollments.Add(newEnrollment);  // Creamos una nueva matrícula
                    await _context.SaveChangesAsync();  // Guardamos los cambios
                    MessageBox.Show("Matrícula creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                OnEnrollmentCreatedOrEdited?.Invoke(); // Seguro con el operador null-conditional
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la matrícula: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento al hacer clic en el botón "Cancelar"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

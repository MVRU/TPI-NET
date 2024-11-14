using ProyectoNET.Controllers;
using ProyectoNET.Models;
using ProyectoNET.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditEnrollmentForm : Form
    {
        private readonly EnrollmentController _enrollmentController;
        private readonly StatusRepository _statusRepository;
        private readonly UserController _userController;
        private Enrollment _enrollmentToEdit; // Matrícula a editar, si aplica
        private int? _courseId;

        // Evento que se dispara cuando se crea o edita una matrícula
        public event Action OnEnrollmentCreatedOrEdited;

        // Constructor para crear nueva matrícula
        public EditEnrollmentForm(EnrollmentController enrollmentController, StatusRepository statusRepository, Enrollment enrollment = null, int? courseId = null)
        {
            _enrollmentController = enrollmentController;
            _statusRepository = statusRepository;
            _enrollmentToEdit = enrollment;
            _courseId = courseId;
            InitializeComponent();

            this.Text = "Crear Matrícula"; // Cambiar título a crear matrícula

            // Llenar los campos con la información de la matrícula existente si se está editando
            if (_enrollmentToEdit != null)
            {
                this.Text = "Editar Matrícula"; // Cambiar título a editar matrícula
            }

            LoadCourses();
            LoadStatuses();  // Cargar los estados
            FillEnrollmentDetails();
        }

        // Constructor para editar una matrícula existente
        public EditEnrollmentForm(EnrollmentController enrollmentController, StatusRepository statusRepository, UserController userController, Enrollment enrollment)
        {
            InitializeComponent();
            _enrollmentController = enrollmentController;
            _statusRepository = statusRepository;
            _userController = userController;
            _enrollmentToEdit = enrollment;

            this.Text = "Editar Matrícula"; // Cambiar título a editar matrícula

            LoadCourses();
            LoadStatuses();  // Cargar los estados
            FillEnrollmentDetails();
        }

        // Cargar la lista de cursos
        private void LoadCourses()
        {
            try
            {
                var courses = _enrollmentController.GetAllCourses(dtpEnrollmentDate.Value); // Obtener todos los cursos disponibles
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
                var statuses = _statusRepository.GetAllStatuses(); // Obtener todos los estados disponibles
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

                // Verificar si _userController está correctamente inicializado
                if (_userController == null)
                {
                    MessageBox.Show("El controlador de usuario no está inicializado correctamente.", "Error de inicialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intentar obtener el usuario
                var user = await _userController.GetUserByIdAsync(studentFile);

                // Verificar si el usuario fue encontrado
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
                var existingEnrollment = _enrollmentController.GetEnrollmentByStudentAndCourse(studentFile, courseId, enrollmentDate);
                if (existingEnrollment != null && existingEnrollment.Id != _enrollmentToEdit?.Id)
                {
                    MessageBox.Show("Ya existe una matrícula para este estudiante en este curso con la misma fecha.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear o editar la matrícula
                if (_enrollmentToEdit != null)
                {
                    // Si estamos editando, actualizamos la matrícula
                    if (_enrollmentToEdit.Status == null || _enrollmentToEdit.Status.Id != statusId)
                    {
                        var newStatus = _statusRepository.GetStatusById(statusId);
                        if (newStatus != null)
                        {
                            _enrollmentToEdit.Status = newStatus; // Asociamos el nuevo estado
                        }
                    }

                    _enrollmentController.UpdateEnrollment(_enrollmentToEdit.Id, enrollmentDate, courseId, statusId);
                    MessageBox.Show("Matrícula editada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _enrollmentController.CreateEnrollment(studentFile, courseId, enrollmentDate, statusId);
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

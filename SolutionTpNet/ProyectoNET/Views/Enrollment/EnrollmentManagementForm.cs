using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoNET.Controllers;
using ProyectoNET.Data;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Views
{
    public partial class EnrollmentManagementForm : Form
    {
        private readonly EnrollmentController _enrollmentController;
        private readonly CourseController _courseController;
        private readonly StatusRepository _statusRepository;

        public EnrollmentManagementForm(EnrollmentController enrollmentController, CourseController courseController, StatusRepository statusRepository)
        {
            InitializeComponent();
            _enrollmentController = enrollmentController;
            _courseController = courseController;
            _statusRepository = statusRepository;

            LoadCourses();
            // Cargar las matrículas de todos los cursos inicialmente
            LoadEnrollments();
        }

        private void LoadCourses()
        {
            // Cargar todos los cursos disponibles
            var courses = _courseController.GetAllCourses(); // Suponiendo que tienes este método

            // Crear una lista que contenga la opción "Todos los Cursos"
            var courseList = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "Todos los Cursos") // Opción "Todos los Cursos"
            };

            // Agregar los cursos reales a la lista
            courseList.AddRange(courses.Select(course => new KeyValuePair<int, string>(course.Id, course.SubjectDescription)));

            // Asignar la lista al ComboBox
            cmbCourses.DataSource = courseList;
            cmbCourses.DisplayMember = "Value";  // Mostrar el SubjectDescription
            cmbCourses.ValueMember = "Key";  // Usar el Id del curso
        }

        private void LoadEnrollments(int? courseId = null)
        {
            // Cargar las matrículas de todos los estudiantes si no se filtra por curso
            var enrollments = _enrollmentController.GetAllEnrollments();

            if (courseId.HasValue && courseId.Value > 0)
            {
                // Filtrar las matrículas por el curso seleccionado
                enrollments = enrollments.Where(e => e.CourseId == courseId.Value).ToList();
            }

            dgvEnrollments.DataSource = enrollments.Select(e => new
            {
                e.Id,
                Course = e.Course.SubjectDescription,
                e.EnrollmentDate,
                e.Status.Description
            }).ToList();
        }

        private void btnCreateEnrollment_Click(object sender, EventArgs e)
        {
            var courseId = (int)cmbCourses.SelectedValue;

            // Verificar si ya existe una matrícula para el curso seleccionado
            var existingEnrollment = _enrollmentController.GetEnrollmentByCourse(courseId);
            if (existingEnrollment != null)
            {
                MessageBox.Show("Ya hay una matrícula para este curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el contexto de la base de datos (esto debería estar en algún lugar del código, como un servicio o contexto global)
            var context = new UniversityContext(); // Asegúrate de que esto se pase correctamente.

            // Crear una nueva matrícula
            var editEnrollmentForm = new EditEnrollmentForm(
                context,        // Pasamos el contexto aquí
                enrollment: null, // No hay matrícula para crear
                courseId: courseId // Solo pasamos courseId cuando se crea una nueva matrícula
            );

            // Suscribirse al evento de creación o edición de matrícula
            editEnrollmentForm.OnEnrollmentCreatedOrEdited += () =>
            {
                LoadEnrollments(); // Recargar matrículas después de la creación o edición
            };

            if (editEnrollmentForm.ShowDialog() == DialogResult.OK)
            {
                // El DataGridView ya se actualizó por el evento
            }
        }

        private void btnEditEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count > 0)
            {
                var enrollmentId = (int)dgvEnrollments.SelectedRows[0].Cells["Id"].Value;
                var enrollment = _enrollmentController.GetEnrollmentById(enrollmentId);

                if (enrollment != null)
                {
                    var context = new UniversityContext(); // Asegúrate de que esto se pase correctamente.

                    var editEnrollmentForm = new EditEnrollmentForm(
                        context,       // Pasamos el contexto aquí
                        enrollment: enrollment, // Pasamos la matrícula para editarla
                        courseId: null // No necesitamos courseId al editar
                    );

                    // Suscribirse al evento de creación o edición de matrícula
                    editEnrollmentForm.OnEnrollmentCreatedOrEdited += () =>
                    {
                        LoadEnrollments(); // Recargar matrículas después de la edición
                    };

                    if (editEnrollmentForm.ShowDialog() == DialogResult.OK)
                    {
                        // El DataGridView ya se actualizó por el evento
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una matrícula para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count > 0)
            {
                var enrollmentId = (int)dgvEnrollments.SelectedRows[0].Cells["Id"].Value;

                // Confirmar la baja lógica
                var confirmResult = MessageBox.Show("¿Está seguro de que desea dar de baja esta matrícula?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Llamar al controlador para realizar la baja lógica
                    _enrollmentController.DeleteEnrollment(enrollmentId);
                    LoadEnrollments(); // Recargar las matrículas después de dar de baja
                }
            }
            else
            {
                MessageBox.Show("Seleccione una matrícula para dar de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCourseId = (int)cmbCourses.SelectedValue;

            // Cargar las matrículas filtradas por el curso seleccionado
            LoadEnrollments(selectedCourseId == 0 ? (int?)null : selectedCourseId);
        }
    }
}

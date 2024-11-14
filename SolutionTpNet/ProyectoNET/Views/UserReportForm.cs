using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class UserReportForm : Form
    {
        private readonly UserController _userController;
        private readonly EnrollmentController _enrollmentController;
        private readonly AttendanceController _attendanceController;

        private string _userId; // ID del User, puede ser configurado al abrir el formulario

        // Constructor
        public UserReportForm(string userId, UserController userController, EnrollmentController enrollmentController, AttendanceController attendanceController)
        {
            InitializeComponent();
            _userId = userId;
            _userController = userController;
            _enrollmentController = enrollmentController;
            _attendanceController = attendanceController;

            LoadUserReport();
        }

        private void LoadUserReport()
        {
            // Cargar y mostrar las métricas generales
            LoadGeneralStats();

            // Cargar el TreeView de cursos
            LoadCoursesTreeView();
        }

        private void LoadGeneralStats()
        {
            try
            {
                // Total de asistencias
                var totalAttendances = _attendanceController.GetAttendancesByUserId(_userId).Count();
                lblTotalAttendances.Text = $"Total de asistencias: {totalAttendances}";

                // Total de cursos inscritos
                var totalEnrollments = _enrollmentController.GetEnrollmentsByStudentId(_userId).Count();
                lblTotalEnrollments.Text = $"Total de cursos inscritos: {totalEnrollments}";

                // Total de cursos aprobados
                var approvedCourses = _enrollmentController.GetEnrollmentsByStudentId(_userId)
                    .Where(e => e.Status != null && e.Status.Description == "Aprobado")  // Acceder a Status.Description
                    .Count();
                lblTotalApprovedCourses.Text = $"Total de cursos aprobados: {approvedCourses}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las métricas generales: {ex.Message}");
            }
        }

        private void LoadCoursesTreeView()
        {
            try
            {
                if (_enrollmentController == null || string.IsNullOrEmpty(_userId))
                {
                    MessageBox.Show("Datos inválidos: no se puede cargar el reporte.");
                    return;  // No continuar si los datos son inválidos.
                }

                // Limpiar el TreeView antes de agregar nuevos nodos
                tvCourses.Nodes.Clear();

                // Obtener las inscripciones del User
                var enrollments = _enrollmentController.GetEnrollmentsByStudentId(_userId);
                if (enrollments == null)
                {
                    MessageBox.Show("No se encontraron inscripciones para el usuario.");
                    return;
                }

                // Agrupar por Status.Description
                var groupedByStatus = enrollments
                    .GroupBy(e => e.Status.Description)  // Acceder a Status.Description
                    .OrderBy(g => g.Key);

                // Crear nodos para cada Status y agregar los cursos correspondientes
                foreach (var group in groupedByStatus)
                {
                    // Crear el nodo para el Status
                    TreeNode statusNode = new TreeNode(group.Key);

                    // Agregar los cursos a los que está inscrito el User
                    foreach (var enrollment in group)
                    {
                        string courseName = enrollment.Course?.SubjectDescription ?? "Sin descripción";  // Verificar si Course y Subject son null
                        TreeNode courseNode = new TreeNode(courseName);
                        statusNode.Nodes.Add(courseNode);
                    }

                    // Agregar el nodo del Status al TreeView
                    tvCourses.Nodes.Add(statusNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el TreeView de cursos: {ex.Message}");
            }
        }
    }
}
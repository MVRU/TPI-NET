using ProyectoNET.Controllers;
using ProyectoNET.Models;
using ProyectoNET.Repositories; // Asegúrate de incluir los repositorios
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class CourseReportForm : Form
    {
        private int _courseId;
        private readonly CourseController _courseController;
        private readonly EnrollmentController _enrollmentController;
        private readonly AttendanceController _attendanceController;

        // Constructor
        public CourseReportForm(int courseId, CourseController courseController, EnrollmentController enrollmentController, AttendanceController attendanceController)
        {
            InitializeComponent();
            _courseId = courseId;
            _courseController = courseController;
            _enrollmentController = enrollmentController;
            _attendanceController = attendanceController;

            LoadCourseReport();
        }

        private void LoadCourseReport()
        {
            // Cargar el curso para mostrar detalles básicos
            var course = _courseController.GetCourseById(_courseId);
            lblCourseName.Text = $"Curso: {course.Subject.Description} - Año: {course.Year}";

            // Cargar y mostrar las métricas
            LoadAttendanceStats();
            LoadClassStatistics();
            LoadQuotaCompliance();

            // Cargar las estadísticas de estado de los estudiantes
            LoadEnrollmentStats();
            LoadTotalAttendance();  // Mostrar el total de clases
            LoadEnrollmentTreeView();  // Cargar el TreeView con los estudiantes por Status

            // Cargar la métrica de mejor y peor asistencia
            LoadBestAndWorstAttendance();
        }

        public void SetCourseId(int courseId)
        {
            _courseId = courseId;
            LoadCourseReport();
        }

        private void LoadAttendanceStats()
        {
            // Código para cargar estadísticas de asistencia si está implementado
            //var averageAttendance = _attendanceController.GetAverageAttendance(_courseId);
            //lblAverageAttendance.Text = $"Promedio de asistencia: {averageAttendance}%";
        }

        private void LoadClassStatistics()
        {
            // Código para cargar estadísticas de clases si está implementado
            //var classStats = _courseController.GetClassStatistics(_courseId);
            //lblClassesScheduled.Text = $"Clases programadas: {classStats.Scheduled}";
            //lblClassesHeld.Text = $"Clases realizadas: {classStats.Held}";
        }

        private void LoadQuotaCompliance()
        {
            try
            {
                // Obtener el cumplimiento de cupo utilizando el método del repositorio
                var quotaCompliance = _courseController.GetQuotaCompliance(_courseId);

                // Mostrar los resultados en los labels correspondientes
                lblTotalEnrollments.Text = $"Total de inscripciones: {quotaCompliance.totalEnrollments}";
                lblQuota.Text = $"Cupo máximo: {quotaCompliance.quota}";
                lblPercentageFulfilled.Text = $"Cumplimiento de cupo: {quotaCompliance.percentageFulfilled:F2}%";
                lblPercentageAvailable.Text = $"Cupo disponible: {quotaCompliance.percentageAvailable:F2}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el cumplimiento de cupo: {ex.Message}");
            }
        }

        private void LoadEnrollmentStats()
        {
            // Verificar que _courseId tiene un valor válido
            if (_courseId <= 0)
            {
                MessageBox.Show("El ID del curso no es válido.");
                return;
            }

            try
            {
                // Obtener las estadísticas de matrícula utilizando el método de Entity Framework
                var enrollmentStats = _enrollmentController.GetEnrollmentStatsByCourseEF(_courseId);

                // Inicializar las variables de estado de los estudiantes con "0"
                int aprobados = 0;
                int regulares = 0;
                int pendientes = 0;
                int libres = 0;

                // Asignar los valores correspondientes si existen estadísticas
                foreach (var stat in enrollmentStats)
                {
                    if (stat.StatusDescription == "Aprobado")
                    {
                        aprobados = stat.StudentCount;
                    }
                    else if (stat.StatusDescription == "Regular")
                    {
                        regulares = stat.StudentCount;
                    }
                    else if (stat.StatusDescription == "Pendiente")
                    {
                        pendientes = stat.StudentCount;
                    }
                    else if (stat.StatusDescription == "Libre")
                    {
                        libres = stat.StudentCount;
                    }
                }

                // Mostrar las estadísticas de matrícula (asegura que todas se muestren, incluso si son 0)
                lblAprobados.Text = $"Aprobados: {aprobados}";
                lblRegulares.Text = $"Regulares: {regulares}";
                lblPendientes.Text = $"Pendientes: {pendientes}";
                lblLibres.Text = $"Libres: {libres}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las estadísticas de matrícula: {ex.Message}");
            }
        }

        private void LoadTotalAttendance()
        {
            try
            {
                // Obtener el total de asistencias (enrollments) para el curso
                int totalAttendances = _courseController.GetTotalAttendanceByCourse(_courseId);

                // Mostrar el total de asistencias en el label correspondiente
                lblTotalAttendances.Text = $"Total de asistencias: {totalAttendances}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el total de asistencias: {ex.Message}");
            }
        }

        // Método para cargar el TreeView con los estudiantes por Status
        private void LoadEnrollmentTreeView()
        {
            try
            {
                // Limpiar el TreeView antes de agregar nuevos nodos
                tvEnrollments.Nodes.Clear();

                // Obtener todos los enrollments del curso con los estudiantes y su status
                var enrollments = _enrollmentController.GetEnrollmentsWithUsersByCourse(_courseId);

                // Agrupar los estudiantes por Status
                var groupedByStatus = enrollments
                    .GroupBy(e => e.StatusDescription)
                    .OrderBy(g => g.Key);

                // Crear nodos para cada Status y agregar los estudiantes como nodos hijos
                foreach (var group in groupedByStatus)
                {
                    // Crear el nodo para el Status (Aprobado, Regular, Pendiente, Libre)
                    TreeNode statusNode = new TreeNode(group.Key);

                    // Agregar los estudiantes como nodos hijos
                    foreach (var enrollment in group)
                    {
                        // Crear un nodo hijo con el nombre y apellido del estudiante
                        string studentName = $"{enrollment.User.Name} {enrollment.User.LastName}";
                        TreeNode studentNode = new TreeNode(studentName);

                        // Agregar el nodo hijo al nodo del Status
                        statusNode.Nodes.Add(studentNode);
                    }

                    // Agregar el nodo del Status al TreeView
                    tvEnrollments.Nodes.Add(statusNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el TreeView de matrículas: {ex.Message}");
            }
        }

        // Método para cargar la información del mejor y peor asistencia
        private void LoadBestAndWorstAttendance()
        {
            try
            {
                // Obtener el estudiante con la mejor y peor asistencia
                var (bestAttendanceUser, worstAttendanceUser) = _attendanceController.GetBestAndWorstAttendance(_courseId);

                if (bestAttendanceUser != null && worstAttendanceUser != null)
                {
                    lblBestAttendance.Text = $"Mejor asistencia: {bestAttendanceUser.Name} {bestAttendanceUser.LastName}";
                    lblWorstAttendance.Text = $"Peor asistencia: {worstAttendanceUser.Name} {worstAttendanceUser.LastName}";
                }
                else
                {
                    lblBestAttendance.Text = "No se pudo determinar el estudiante con mejor asistencia.";
                    lblWorstAttendance.Text = "No se pudo determinar el estudiante con peor asistencia.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las métricas de asistencia: {ex.Message}");
            }
        }
    }
}

using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class AttendanceManagementForm : Form
    {
        private readonly AttendanceController _attendanceController;
        private readonly EnrollmentController _enrollmentController; // Agregar una instancia del EnrollmentController

        public AttendanceManagementForm(AttendanceController attendanceController, EnrollmentController enrollmentController)
        {
            _attendanceController = attendanceController;
            _enrollmentController = enrollmentController; // Inicializar la instancia
            InitializeComponent();
            LoadAttendances();
        }

        // Cargar todas las asistencias en el DataGridView
        private void LoadAttendances()
        {
            try
            {
                // Obtener todas las asistencias (sin filtrar por matrícula)
                var attendances = _attendanceController.GetAllAttendances();

                // Si no hay asistencias, mostrar mensaje de advertencia
                if (attendances == null || !attendances.Any())
                {
                    MessageBox.Show("No se encontraron asistencias.");
                    dgvAttendances.DataSource = null;  // Limpiar el DataGridView
                    return;
                }

                // Configurar el DataGridView para mostrar las asistencias
                dgvAttendances.DataSource = attendances;
                dgvAttendances.Columns["EnrollmentId"].Visible = false; // Ocultar la columna de ID de matrícula

                // Asegurarse de que las columnas estén bien configuradas
                dgvAttendances.Columns["Id"].HeaderText = "ID Asistencia"; // Cambiar el encabezado de la columna
                dgvAttendances.Columns["Timestamp"].HeaderText = "Fecha y Hora"; // Configurar el encabezado adecuado para Timestamp
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show($"Error al cargar las asistencias: {ex.Message}");
            }
        }

        // Evento de clic en el botón "Editar"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAttendances.SelectedRows.Count > 0)
            {
                var attendanceId = (int)dgvAttendances.SelectedRows[0].Cells["Id"].Value;
                var attendanceForm = new EditAttendanceForm(_attendanceController, _enrollmentController, attendanceId); // Corregir llamada
                attendanceForm.ShowDialog();
                LoadAttendances(); // Recargar asistencias después de editar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una asistencia para editar.");
            }
        }

        // Evento de clic en el botón "Eliminar"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendances.SelectedRows.Count > 0)
            {
                var attendanceId = (int)dgvAttendances.SelectedRows[0].Cells["Id"].Value;
                var result = MessageBox.Show("¿Está seguro de que desea eliminar esta asistencia?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _attendanceController.DeleteAttendance(attendanceId);
                    LoadAttendances(); // Recargar asistencias después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una asistencia para eliminar.");
            }
        }

        // Evento de clic en el botón "Agregar"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var attendanceForm = new EditAttendanceForm(_attendanceController, _enrollmentController); // Pasar ambos controladores
            attendanceForm.ShowDialog();
            LoadAttendances(); // Recargar asistencias después de agregar una nueva
        }

        // Evento de clic en el botón "Cerrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

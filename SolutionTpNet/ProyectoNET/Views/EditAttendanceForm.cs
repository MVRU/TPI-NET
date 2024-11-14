using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditAttendanceForm : Form
    {
        private readonly AttendanceController _attendanceController;
        private readonly EnrollmentController _enrollmentController;
        private int? _attendanceId; // ID de la asistencia a editar (si aplica)
        private int _enrollmentId; // ID de la matrícula asociada

        // Constructor para crear nueva asistencia
        public EditAttendanceForm(AttendanceController attendanceController, EnrollmentController enrollmentController, int enrollmentId = 0, int? attendanceId = null)
        {
            _attendanceController = attendanceController;
            _enrollmentController = enrollmentController;
            _enrollmentId = enrollmentId;
            _attendanceId = attendanceId;
            InitializeComponent();

            // Si estamos editando, configuramos el título y cargamos los detalles
            this.Text = _attendanceId.HasValue ? "Editar Asistencia" : "Registrar Asistencia";
            LoadEnrollments(); // Cargar los enrollments en el ComboBox

            if (_attendanceId.HasValue)
            {
                LoadAttendanceDetails(); // Cargar los detalles si estamos editando
            }
        }

        // Cargar las inscripciones (enrollments) en el ComboBox
        private void LoadEnrollments()
        {
            try
            {
                var enrollments = _enrollmentController.GetAllEnrollments();
                if (enrollments != null && enrollments.Any())
                {
                    comboBoxEnrollment.DataSource = enrollments;
                    comboBoxEnrollment.DisplayMember = "FullName"; // Asumiendo que FullName es la propiedad a mostrar
                    comboBoxEnrollment.ValueMember = "Id"; // El valor que se utilizará (ID de la matrícula)
                }
                else
                {
                    MessageBox.Show("No se encontraron matrículas disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las inscripciones: {ex.Message}");
            }
        }

        // Cargar detalles de la asistencia cuando se edita
        private void LoadAttendanceDetails()
        {
            try
            {
                // Obtener la asistencia por su ID
                var attendance = _attendanceController.GetAttendanceById((int)_attendanceId);
                if (attendance != null)
                {
                    dtpAttendanceDate.Value = attendance.Timestamp; // Cargar la fecha de asistencia
                    comboBoxEnrollment.SelectedValue = attendance.EnrollmentId; // Asignar el EnrollmentId
                }
                else
                {
                    MessageBox.Show("La asistencia no fue encontrada.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la asistencia: {ex.Message}");
            }
        }

        // Validación de la fecha de asistencia
        private bool IsValidDate(DateTime date)
        {
            return date <= DateTime.Now; // La fecha no puede ser en el futuro
        }

        // Evento de clic en el botón "Guardar"
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var attendanceDate = dtpAttendanceDate.Value;
                var enrollmentId = (int)comboBoxEnrollment.SelectedValue; // Obtener el EnrollmentId seleccionado

                // Validación de la fecha
                if (!IsValidDate(attendanceDate))
                {
                    MessageBox.Show("La fecha de asistencia no puede ser en el futuro.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si estamos editando
                if (_attendanceId.HasValue)
                {
                    // Actualizamos la asistencia existente
                    _attendanceController.UpdateAttendance((int)_attendanceId, attendanceDate, enrollmentId);
                    MessageBox.Show("Asistencia actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si estamos creando una nueva
                else
                {
                    _attendanceController.CreateAttendance(attendanceDate, enrollmentId); // Crear una nueva asistencia
                    MessageBox.Show("Asistencia registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); // Cerrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la asistencia: {ex.Message}");
            }
        }


        // Evento de clic en el botón "Cancelar"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class ScheduleManagementForm : Form
    {
        private readonly ScheduleController _scheduleController;
        private Schedule _selectedSchedule; // Para almacenar el horario seleccionado

        public ScheduleManagementForm(ScheduleController scheduleController)
        {
            InitializeComponent();
            _scheduleController = scheduleController;
            LoadSchedules();
        }

        private void ScheduleManagementForm_Load(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        // Cargar la lista de horarios en el DataGridView
        private void LoadSchedules()
        {
            dgvHorarios.DataSource = _scheduleController.GetAllSchedules()
                .Select(s => new
                {
                    s.Id,
                    s.Day,
                    s.StartTime,
                    s.EndTime
                }).ToList();

            // Cambiar los nombres de las columnas a español
            dgvHorarios.Columns["Id"].HeaderText = "ID";
            dgvHorarios.Columns["Day"].HeaderText = "Día";
            dgvHorarios.Columns["StartTime"].HeaderText = "Hora de inicio";
            dgvHorarios.Columns["EndTime"].HeaderText = "Hora de fin";

            // Ajustar el tamaño de las columnas
            dgvHorarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Evento al seleccionar una fila en el DataGridView
        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHorarios.Rows.Count) // Asegurarse de que se seleccionó una fila válida
            {
                int scheduleId = Convert.ToInt32(dgvHorarios.Rows[e.RowIndex].Cells["Id"].Value);
                _selectedSchedule = _scheduleController.GetAllSchedules().FirstOrDefault(s => s.Id == scheduleId);
            }
        }

        // Evento al hacer clic en el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de creación/edición de horario
            EditScheduleForm editScheduleForm = new EditScheduleForm(_scheduleController);

            // Suscribir al evento para actualizar el DataGridView después de agregar un horario
            editScheduleForm.OnScheduleAddedOrEdited += () =>
            {
                LoadSchedules(); // Recargar la lista de horarios
            };

            editScheduleForm.ShowDialog();
        }

        // Evento al hacer clic en el botón "Modificar"
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule != null)
            {
                // Crear y mostrar el formulario de edición de horario
                EditScheduleForm editScheduleForm = new EditScheduleForm(_scheduleController, _selectedSchedule);

                // Suscribir al evento para actualizar el DataGridView después de modificar un horario
                editScheduleForm.OnScheduleAddedOrEdited += () =>
                {
                    LoadSchedules(); // Recargar la lista de horarios
                };

                editScheduleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un horario para modificar.");
            }
        }

        // Evento al hacer clic en el botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule != null)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este horario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _scheduleController.DeleteSchedule(_selectedSchedule.Id);
                    MessageBox.Show("Horario eliminado con éxito.");
                    _selectedSchedule = null; // Limpiar la selección después de eliminar
                    LoadSchedules(); // Recargar la lista de horarios
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un horario para eliminar.");
            }
        }
    }
}

using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditScheduleForm : Form
    {
        private readonly ScheduleController _scheduleController;
        private Schedule _schedule;

        public event Action OnScheduleAddedOrEdited;

        public EditScheduleForm(ScheduleController scheduleController)
        {
            InitializeComponent();
            _scheduleController = scheduleController;

            // Configurar DateTimePickers para seleccionar solo la hora
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;

            // Seleccionar el primer día de la lista por defecto
            cmbDay.SelectedIndex = 0;
        }

        public EditScheduleForm(ScheduleController scheduleController, Schedule schedule)
            : this(scheduleController)
        {
            _schedule = schedule;
            cmbDay.SelectedItem = schedule.Day;
            dtpStartTime.Value = DateTime.Today + schedule.StartTime;
            dtpEndTime.Value = DateTime.Today + schedule.EndTime;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un día.");
                return;
            }

            TimeSpan startTime = new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, dtpStartTime.Value.Second);
            TimeSpan endTime = new TimeSpan(dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, dtpEndTime.Value.Second);

            if (startTime >= endTime)
            {
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.");
                return;
            }

            string day = cmbDay.SelectedItem.ToString();

            try
            {
                if (_schedule == null)
                {
                    _scheduleController.CreateSchedule(day, startTime, endTime);
                }
                else
                {
                    _scheduleController.UpdateSchedule(_schedule.Id, day, startTime, endTime);
                }

                OnScheduleAddedOrEdited?.Invoke();
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
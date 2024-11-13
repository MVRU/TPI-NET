using ProyectoNET.Data;
using ProyectoNET.Models;
using ProyectoNET.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class AssignScheduleForm : Form
    {
        private readonly CourseRepository _courseRepository;
        private readonly ScheduleRepository _scheduleRepository;
        private Course _course;

        public AssignScheduleForm(Course course)
        {
            InitializeComponent();
            _courseRepository = new CourseRepository(new UniversityContext());
            _scheduleRepository = new ScheduleRepository(new UniversityContext());
            _course = course;
        }

        private void AssignScheduleForm_Load(object sender, EventArgs e)
        {
            // Cargar la información del curso
            lblCourseInfo.Text = $"Curso: {_course.Year} - {_course.SubjectDescription}";

            // Llenar el ComboBox con los días de la semana
            comboBoxDay.Items.AddRange(new[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            comboBoxDay.SelectedIndex = 0; // Por defecto seleccionar el primer día

            // Cargar los horarios de acuerdo al día seleccionado
            LoadSchedulesByDay(comboBoxDay.SelectedItem.ToString());
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filtrar los horarios según el día seleccionado
            LoadSchedulesByDay(comboBoxDay.SelectedItem.ToString());
        }

        private void LoadSchedulesByDay(string day)
        {
            // Depuración: Imprimir el valor del día seleccionado
            Console.WriteLine($"Filtrando horarios para el día: {day}");

            // Obtener todos los horarios filtrados por el día seleccionado
            var schedules = _scheduleRepository.GetSchedulesByDay(day);

            // Limpiar el ComboBox de horarios
            comboBoxSchedule.Items.Clear();

            // Depurar si hay horarios obtenidos
            Console.WriteLine($"Cargando horarios para el día: {day}. Horarios encontrados: {schedules.Count()}");

            // Llenar el ComboBox con los horarios disponibles para el día seleccionado
            foreach (var schedule in schedules)
            {
                comboBoxSchedule.Items.Add(new ComboBoxItem
                {
                    Text = $"{schedule.StartTime:hh\\:mm} - {schedule.EndTime:hh\\:mm}",
                    Value = schedule.Id
                });
            }

            // Seleccionar el primer horario por defecto si existen horarios
            if (comboBoxSchedule.Items.Count > 0)
            {
                comboBoxSchedule.SelectedIndex = 0;
            }
            else
            {
                // Mensaje de depuración si no se encuentran horarios
                Console.WriteLine($"No se encontraron horarios para el día: {day}");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Verificar si un horario ha sido seleccionado
            if (comboBoxSchedule.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un horario para asignar al curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedSchedule = (ComboBoxItem)comboBoxSchedule.SelectedItem;

            // Verificar si el horario ya está asignado al curso
            if (_course.Schedules.Any(s => s.Id == selectedSchedule.Value))
            {
                MessageBox.Show("Este horario ya está asignado al curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignar el horario al curso
            var scheduleToAdd = _scheduleRepository.GetScheduleById(selectedSchedule.Value);
            _course.Schedules.Add(scheduleToAdd);

            // Guardar los cambios en el curso
            _courseRepository.UpdateCourse(_course.Id, _course.Year, _course.StartDate, _course.EndDate, _course.Quota, _course.SubjectId);

            MessageBox.Show("Horario asignado correctamente al curso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    // Clase auxiliar para representar el item del ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

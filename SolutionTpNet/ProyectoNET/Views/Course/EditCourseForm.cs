using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditCourseForm : Form
    {
        private readonly CourseController _courseController;
        private readonly SubjectController _subjectController;
        private readonly ScheduleController _scheduleController;
        private readonly UserController _userController; // Agregado para obtener los usuarios
        private int? _courseId;

        public event Action OnCourseAddedOrEdited;

        public EditCourseForm(CourseController courseController, SubjectController subjectController, ScheduleController scheduleController, UserController userController)
        {
            InitializeComponent();
            _courseController = courseController;
            _subjectController = subjectController;
            _scheduleController = scheduleController;
            _userController = userController; // Inicializar el controlador de usuarios

            LoadSubjects();
            LoadSchedules();
            LoadProfessors(); // Cargar los profesores
            ConfigureControls();
        }

        public EditCourseForm(CourseController courseController, SubjectController subjectController, ScheduleController scheduleController, UserController userController, int courseId)
            : this(courseController, subjectController, scheduleController, userController)
        {
            _courseId = courseId;
            LoadCourseDetails(courseId);
        }

        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubjects().ToList();
            subjects.Insert(0, new Subject { Id = 0, Description = "N/A" });
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "Description";
            cmbSubject.ValueMember = "Id";
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.SelectedIndex = 0;
        }

        private void LoadSchedules()
        {
            var schedules = _scheduleController.GetAllSchedules();

            var schedulesByDay = schedules
                .GroupBy(s => s.Day)
                .OrderBy(g => g.Key)
                .ToList();

            tvSchedules.Nodes.Clear();

            foreach (var dayGroup in schedulesByDay)
            {
                var dayNode = new TreeNode(dayGroup.Key.ToString())
                {
                    Tag = dayGroup.Key,
                    Checked = false,
                    ForeColor = Color.Gray
                };

                foreach (var schedule in dayGroup)
                {
                    var scheduleNode = new TreeNode($"{schedule.StartTime:hh\\:mm} - {schedule.EndTime:hh\\:mm} ({schedule.Day})")
                    {
                        Tag = schedule.Id
                    };
                    dayNode.Nodes.Add(scheduleNode);
                }

                tvSchedules.Nodes.Add(dayNode);
            }

            tvSchedules.FullRowSelect = true;
            tvSchedules.CheckBoxes = true;
        }

        private async void LoadProfessors()
        {
            var professors = await _userController.GetUsersByRole("Professor"); // Obtener solo los usuarios con rol 'Professor'
            clbProfessors.Items.Clear();

            foreach (var professor in professors)
            {
                var item = new CheckedListBoxItem
                {
                    Value = professor.File,
                    Display = $"{professor.File} - {professor.Name} {professor.LastName}"
                };
                clbProfessors.Items.Add(item);
            }
        }

        private void ConfigureControls()
        {
            txtYear.ReadOnly = true;

            if (dtpStartDate.Value == null || dtpStartDate.Value == DateTime.MinValue)
            {
                txtYear.Text = DateTime.Now.Year.ToString();
            }

            dtpStartDate.ValueChanged += (s, e) => UpdateYearBasedOnStartDate();
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Format = DateTimePickerFormat.Short;
        }

        private void UpdateYearBasedOnStartDate()
        {
            txtYear.Text = dtpStartDate.Value.Year.ToString();
        }

        private void LoadCourseDetails(int courseId)
        {
            var course = _courseController.GetCourseById(courseId);
            if (course != null)
            {
                txtYear.Text = course.Year.ToString();
                dtpStartDate.Value = course.StartDate;
                dtpEndDate.Value = course.EndDate;
                txtQuota.Text = course.Quota.ToString();

                cmbSubject.SelectedValue = course.SubjectId ?? 0;

                // Seleccionar los horarios del curso
                foreach (var schedule in course.Schedules)
                {
                    var dayNode = tvSchedules.Nodes.Cast<TreeNode>()
                        .FirstOrDefault(node => node.Tag.ToString() == schedule.Day);
                    if (dayNode != null)
                    {
                        var scheduleNode = dayNode.Nodes.Cast<TreeNode>()
                            .FirstOrDefault(node => (int)node.Tag == schedule.Id);
                        if (scheduleNode != null)
                        {
                            scheduleNode.Checked = true;
                        }
                    }
                }

                // Cargar los profesores asignados al curso
                foreach (var professor in course.Users.Where(u => u.Role == "Professor"))
                {
                    var item = clbProfessors.Items.Cast<CheckedListBoxItem>()
                        .FirstOrDefault(i => i.Value == professor.File);
                    if (item != null)
                    {
                        item.Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Curso no encontrado.");
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuota.Text) || cmbSubject.SelectedIndex == 0 || !tvSchedules.Nodes.Cast<TreeNode>().Any(dayNode => dayNode.Nodes.Cast<TreeNode>().Any(scheduleNode => scheduleNode.Checked)))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("El año no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuota.Text) || !int.TryParse(txtQuota.Text, out int quota))
            {
                MessageBox.Show("La cuota no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (endDate <= startDate)
            {
                MessageBox.Show("La fecha de fin debe ser posterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedScheduleIds = tvSchedules.Nodes.Cast<TreeNode>()
                .Where(dayNode => dayNode.Nodes.Cast<TreeNode>().Any(scheduleNode => scheduleNode.Checked))
                .SelectMany(dayNode => dayNode.Nodes.Cast<TreeNode>())
                .Where(scheduleNode => scheduleNode.Checked)
                .Select(scheduleNode => (int)scheduleNode.Tag)
                .ToList();

            if (selectedScheduleIds.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener los usuarios seleccionados como profesores
                var selectedProfessorFiles = clbProfessors.Items.Cast<CheckedListBoxItem>()
                    .Where(item => item.Checked)
                    .Select(item => item.Value)
                    .ToList();

                // Crear o actualizar el curso
                if (_courseId.HasValue)
                {
                    _courseController.UpdateCourse(_courseId.Value, year, startDate, endDate, quota, (int?)cmbSubject.SelectedValue, selectedScheduleIds, selectedProfessorFiles);
                }
                else
                {
                    _courseId = _courseController.CreateCourse(year, startDate, endDate, quota, (int?)cmbSubject.SelectedValue, selectedScheduleIds, selectedProfessorFiles);
                }

                OnCourseAddedOrEdited?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Clase auxiliar para los items del CheckedListBox
    public class CheckedListBoxItem
    {
        public string Value { get; set; }
        public string Display { get; set; }
        public bool Checked { get; set; }
    }
}

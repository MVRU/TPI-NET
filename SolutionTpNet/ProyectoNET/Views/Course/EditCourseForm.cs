using ProyectoNET.Controllers;
using ProyectoNET.Models;

namespace ProyectoNET.Views
{
    public partial class EditCourseForm : Form
    {
        private readonly CourseController _courseController;
        private readonly SubjectController _subjectController;
        private readonly ScheduleController _scheduleController;
        private int? _courseId;

        public event Action OnCourseAddedOrEdited;

        public EditCourseForm(CourseController courseController, SubjectController subjectController, ScheduleController scheduleController)
        {
            InitializeComponent();
            _courseController = courseController;
            _subjectController = subjectController;
            _scheduleController = scheduleController; // Asigna el controlador de horarios

            LoadSubjects();
            LoadSchedules(); // Cargar los horarios en el TreeView
            ConfigureControls();
        }

        public EditCourseForm(CourseController courseController, SubjectController subjectController, ScheduleController scheduleController, int courseId)
            : this(courseController, subjectController, scheduleController)
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

            // Agrupar horarios por día
            var schedulesByDay = schedules
                .GroupBy(s => s.Day)
                .OrderBy(g => g.Key) // Ordenar los días
                .ToList();

            tvSchedules.Nodes.Clear(); // Limpiar el TreeView antes de cargar los datos

            foreach (var dayGroup in schedulesByDay)
            {
                var dayNode = new TreeNode(dayGroup.Key.ToString()) // Crear un nodo para el día
                {
                    Tag = dayGroup.Key, // Guardar el día como un valor (Tag) en el nodo
                    Checked = false, // Asegurar que la casilla de verificación del día esté desmarcada
                    ForeColor = Color.Gray // Desactivar visualmente el nodo "Day"
                };

                foreach (var schedule in dayGroup)
                {
                    var scheduleNode = new TreeNode($"{schedule.StartTime:hh\\:mm} - {schedule.EndTime:hh\\:mm} ({schedule.Day})")
                    {
                        Tag = schedule.Id // Guardar el Id del horario en el nodo
                    };
                    dayNode.Nodes.Add(scheduleNode); // Agregar el horario como un nodo hijo
                }

                tvSchedules.Nodes.Add(dayNode); // Agregar el nodo del día al TreeView
            }

            tvSchedules.FullRowSelect = true; // Permitir seleccionar toda la fila
            tvSchedules.CheckBoxes = true; // Activar casillas de verificación para la selección
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

                // Seleccionar los horarios del curso si están asociados a alguno
                foreach (var schedule in course.Schedules)
                {
                    var dayNode = tvSchedules.Nodes.Cast<TreeNode>()
                        .FirstOrDefault(node => node.Tag.ToString() == schedule.Day); // Comparar como string
                    if (dayNode != null)
                    {
                        var scheduleNode = dayNode.Nodes.Cast<TreeNode>()
                            .FirstOrDefault(node => (int)node.Tag == schedule.Id); // Buscar el horario correspondiente
                        if (scheduleNode != null)
                        {
                            scheduleNode.Checked = true; // Marcar el horario como seleccionado
                        }
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
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtQuota.Text) || cmbSubject.SelectedIndex == 0 || !tvSchedules.Nodes.Cast<TreeNode>().Any(dayNode => dayNode.Nodes.Cast<TreeNode>().Any(scheduleNode => scheduleNode.Checked)))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar año
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("El año no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar cuota
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

            // Obtener los horarios seleccionados
            var selectedScheduleIds = tvSchedules.Nodes.Cast<TreeNode>()
                .Where(dayNode => dayNode.Nodes.Cast<TreeNode>().Any(scheduleNode => scheduleNode.Checked)) // Verificar solo los horarios seleccionados
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
                // Crear o actualizar el curso
                if (_courseId.HasValue)
                {
                    _courseController.UpdateCourse(_courseId.Value, year, startDate, endDate, quota, (int?)cmbSubject.SelectedValue, selectedScheduleIds);
                }
                else
                {
                    _courseId = _courseController.CreateCourse(year, startDate, endDate, quota, (int?)cmbSubject.SelectedValue, selectedScheduleIds);
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
}

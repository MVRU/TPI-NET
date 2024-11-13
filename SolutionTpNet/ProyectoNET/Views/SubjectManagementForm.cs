using System;
using System.Linq;
using System.Windows.Forms;
using ProyectoNET.Controllers;
using ProyectoNET.Models;

namespace ProyectoNET.Views
{
    public partial class SubjectManagementForm : Form
    {
        private readonly SubjectController _subjectController;
        private Subject _selectedSubject;

        public SubjectManagementForm(SubjectController subjectController)
        {
            InitializeComponent();
            _subjectController = subjectController;
            LoadSubjects();
        }

        // Este es el evento que se invoca cuando una asignatura ha sido agregada o editada
        public event Action OnSubjectAddedOrEdited;

        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        // Cargar la lista de asignaturas en el DataGridView
        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubjects()
                .Select(s => new { s.Id, s.Description, RequiredAttendancePercentage = s.RequiredAttendancePercentage + "%" }) // Concatenar "%" al valor del porcentaje
                .ToList();

            dgvSubjects.DataSource = subjects;

            // Cambiar los nombres de las columnas en el DataGridView a español
            dgvSubjects.Columns["Id"].HeaderText = "ID";
            dgvSubjects.Columns["Description"].HeaderText = "Descripción";
            dgvSubjects.Columns["RequiredAttendancePercentage"].HeaderText = "Porcentaje de asistencia requerido";

            // Ajustar automáticamente el tamaño de las columnas según el contenido
            dgvSubjects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvSubjects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubjects.Columns["RequiredAttendancePercentage"].Width = 250;
        }

        // Evento al seleccionar una fila en el DataGridView
        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSubjects.Rows.Count) // Asegurarse de que se seleccionó una fila válida
            {
                int subjectId = Convert.ToInt32(dgvSubjects.Rows[e.RowIndex].Cells["Id"].Value);
                _selectedSubject = _subjectController.GetAllSubjects().FirstOrDefault(s => s.Id == subjectId);
            }
        }

        private void btnModificarAsignatura_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una asignatura antes de permitir la modificación
            if (_selectedSubject != null)
            {
                // Crear y mostrar el formulario de creación/edición
                EditSubjectForm createSubjectForm = new EditSubjectForm(_subjectController, _selectedSubject);

                // Suscribir al evento OnSubjectCreatedOrEdited para actualizar el DataGridView
                createSubjectForm.OnSubjectCreatedOrEdited += () =>
                {
                    LoadSubjects();
                };

                // Mostrar el formulario
                createSubjectForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una asignatura para modificar.");
            }
        }

        // Eliminar asignatura seleccionada
        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (_selectedSubject != null)
            {
                _subjectController.DeleteSubject(_selectedSubject.Id);
                MessageBox.Show("Asignatura eliminada con éxito.");
                _selectedSubject = null; // Limpiar la selección después de eliminar
                LoadSubjects(); // Recargar la lista de asignaturas
            }
            else
            {
                MessageBox.Show("Por favor selecciona una asignatura para eliminar.");
            }
        }

        // Evento al hacer clic en el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario de creación/edición
            EditSubjectForm createSubjectForm = new EditSubjectForm(_subjectController);

            // Suscribir al evento OnSubjectCreatedOrEdited para actualizar el DataGridView
            createSubjectForm.OnSubjectCreatedOrEdited += () =>
            {
                LoadSubjects();
            };

            // Mostrar el formulario
            createSubjectForm.ShowDialog();
        }
    }
}

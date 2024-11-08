using System;
using System.Collections.Generic;
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
            btnGuardar.Visible = false; // Solo visible cuando se está en modo de edición
            LoadSubjects();
        }

        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        // Cargar la lista de asignaturas en el DataGridView
        private void LoadSubjects()
        {
            dgvSubjects.DataSource = _subjectController.GetAllSubjects()
                .Select(s => new { s.Id, s.Description, s.RequiredAttendancePercentage, s.AverageAttendancePercentage })
                .ToList();
        }

        // Evento al seleccionar una fila en el DataGridView
        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se seleccionó una fila válida
            {
                int subjectId = Convert.ToInt32(dgvSubjects.Rows[e.RowIndex].Cells["Id"].Value);
                _selectedSubject = _subjectController.GetAllSubjects().FirstOrDefault(s => s.Id == subjectId);

                if (_selectedSubject != null)
                {
                    EnableModificationMode(false); // Deshabilitar campos hasta que se haga clic en "Modificar"
                }
            }
        }

        // Cambiar al modo de edición
        private void btnModificarAsignatura_Click(object sender, EventArgs e)
        {
            EnableModificationMode(true);
        }

        // Guardar cambios en la asignatura
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_selectedSubject != null)
            {
                // Actualizar asignatura con valores ingresados directamente en el DataGridView
                var rowIndex = dgvSubjects.CurrentCell.RowIndex;
                _selectedSubject.Description = dgvSubjects.Rows[rowIndex].Cells["Description"].Value.ToString();
                _selectedSubject.RequiredAttendancePercentage = Convert.ToSingle(dgvSubjects.Rows[rowIndex].Cells["RequiredAttendancePercentage"].Value);
                _selectedSubject.AverageAttendancePercentage = Convert.ToSingle(dgvSubjects.Rows[rowIndex].Cells["AverageAttendancePercentage"].Value);

                // Actualizar asignatura en la base de datos
                _subjectController.UpdateSubject(_selectedSubject.Id, _selectedSubject.Description, _selectedSubject.RequiredAttendancePercentage, _selectedSubject.AverageAttendancePercentage);
                MessageBox.Show("Asignatura actualizada con éxito.");
                EnableModificationMode(false);
                LoadSubjects();
            }
        }

        // Eliminar asignatura seleccionada
        private void btnEliminarAsignatura_Click(object sender, EventArgs e)
        {
            if (_selectedSubject != null)
            {
                _subjectController.DeleteSubject(_selectedSubject.Id);
                MessageBox.Show("Asignatura eliminada con éxito.");
                _selectedSubject = null;
                LoadSubjects();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una asignatura para eliminar.");
            }
        }

        // Habilitar o deshabilitar el modo de modificación
        private void EnableModificationMode(bool isEditing)
        {
            dgvSubjects.ReadOnly = !isEditing;
            btnGuardar.Visible = isEditing;
            btnModificarAsignatura.Visible = !isEditing;
        }
    }
}

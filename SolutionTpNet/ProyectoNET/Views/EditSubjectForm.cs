using System;
using System.Windows.Forms;
using ProyectoNET.Controllers;
using ProyectoNET.Models;

namespace ProyectoNET.Views
{
    public partial class EditSubjectForm : Form
    {
        private readonly SubjectController _subjectController;
        private Subject _subjectToEdit; // Asignatura a editar, si aplica

        // Evento que se dispara cuando se crea o edita una asignatura
        public event Action OnSubjectCreatedOrEdited;

        public EditSubjectForm(SubjectController subjectController, Subject subjectToEdit = null)
        {
            InitializeComponent();
            _subjectController = subjectController;
            _subjectToEdit = subjectToEdit;

            if (_subjectToEdit != null)
            {
                // Si estamos editando, llenamos los campos con la información de la asignatura
                txtDescription.Text = _subjectToEdit.Description;
                txtRequiredAttendancePercentage.Text = _subjectToEdit.RequiredAttendancePercentage.ToString();
                this.Text = "Editar Asignatura"; // Cambiar título del formulario
            }
            else
            {
                this.Text = "Crear Asignatura"; // Cambiar título del formulario
            }
        }

        // Evento al hacer clic en el botón "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            float requiredAttendancePercentage;

            // Validar que los valores ingresados sean correctos
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Por favor ingrese una descripción para la asignatura.");
                return;
            }

            if (!float.TryParse(txtRequiredAttendancePercentage.Text, out requiredAttendancePercentage) || requiredAttendancePercentage < 0 || requiredAttendancePercentage > 100)
            {
                MessageBox.Show("Por favor ingrese un porcentaje de asistencia requerido válido (entre 0 y 100).");
                return;
            }

            // Si estamos editando, actualizamos la asignatura
            if (_subjectToEdit != null)
            {
                _subjectToEdit.Description = description;
                _subjectToEdit.RequiredAttendancePercentage = requiredAttendancePercentage;
                _subjectController.UpdateSubject(_subjectToEdit.Id, _subjectToEdit.Description, _subjectToEdit.RequiredAttendancePercentage);
                MessageBox.Show("Asignatura editada con éxito.");
            }
            else
            {
                // Si estamos creando, creamos la nueva asignatura
                _subjectController.CreateSubject(description, requiredAttendancePercentage);
                MessageBox.Show("Asignatura creada con éxito.");
            }

            // Disparar el evento para notificar que la asignatura fue creada o editada
            OnSubjectCreatedOrEdited?.Invoke();

            // Cerrar el formulario después de crear o editar la asignatura
            this.Close();
        }

        // Evento al hacer clic en el botón "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using ProyectoNET.Models;
using ProyectoNET.Controllers;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class EditUserForm : Form
    {
        private readonly User _user;
        private readonly UserController _userController;

        public EditUserForm(User user, UserController userController)
        {
            InitializeComponent();
            _user = user;
            _userController = userController;
            PopulateFields();
        }

        private void PopulateFields()
        {
            // Cargar la información actual del usuario en los campos
            txtFile.Text = _user.File;
            txtName.Text = _user.Name;
            txtLastName.Text = _user.LastName;
            txtEmail.Text = _user.Email;
            txtAddress.Text = _user.Address;

            // Configurar lista desplegable para Role con opciones específicas
            cboRole.Items.AddRange(new string[] { "Student", "Admin", "Professor" });
            cboRole.SelectedItem = _user.Role;

            // Deshabilitar campo de legajo (ID) ya que no debe modificarse
            txtFile.Enabled = false;

            // Atributo específico de Admin
            if (_user.Role == "Admin")
            {
                txtPosition.Text = _user.Position;
            }
            else
            {
                txtPosition.Enabled = false; // Deshabilitar campo si no es Admin
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cboRole.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de correo electrónico
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar los valores del usuario desde los campos
            _user.Name = txtName.Text;
            _user.LastName = txtLastName.Text;
            _user.Email = txtEmail.Text;
            _user.Address = txtAddress.Text;
            _user.Role = cboRole.SelectedItem.ToString();

            if (_user.Role == "Admin")
            {
                _user.Position = txtPosition.Text;
            }

            // Obtener el ID y el rol actual del usuario logueado desde Settings.settings
            string currentUserId = Properties.Settings.Default.UserId;
            string currentUserRole = Properties.Settings.Default.UserRole;

            // Llamar al método de actualización en UserController
            var success = await _userController.UpdateUserAsync(_user, currentUserId, currentUserRole);
            if (success)
            {
                MessageBox.Show("Usuario actualizado con éxito.", "Edición de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario de edición
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

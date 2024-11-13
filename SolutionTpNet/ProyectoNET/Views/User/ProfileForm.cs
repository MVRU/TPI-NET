using ProyectoNET.Models;
using ProyectoNET.Controllers;
using ProyectoNET.Repositories;
using System;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class ProfileForm : Form
    {
        private readonly UserController _userController;
        private readonly string _currentUserId;

        public ProfileForm(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
            _currentUserId = Properties.Settings.Default.UserId; // Obtener el ID del usuario actual desde Settings
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            // Obtener los datos del usuario actual
            var user = await _userController.GetUserByIdAsync(_currentUserId);

            if (user != null)
            {
                // Llenar los campos del formulario con la información del usuario
                txtName.Text = user.Name;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtRole.Text = user.Role;
                txtAddress.Text = user.Address;
                txtPassword.Text = "******";  // Mostrar contraseña como asteriscos

                // Si es Admin, mostrar información adicional
                if (user.Role == "Admin")
                {
                    txtPosition.Text = user.Position;
                }
                else
                {
                    txtPosition.Visible = false; // Ocultar campo si no es Admin
                }

                // Bloquear los campos de texto para que no sean editables por defecto
                DisableFields();
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para deshabilitar todos los campos de texto
        private void DisableFields()
        {
            txtName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmail.Enabled = false;
            txtRole.Enabled = false;
            txtAddress.Enabled = false;
            txtPassword.Enabled = false;
            txtPosition.Enabled = false;
        }

        // Método para habilitar los campos de texto para editar
        private void EnableFields()
        {
            txtName.Enabled = true;
            txtLastName.Enabled = true;
            txtEmail.Enabled = true;
            txtRole.Enabled = true;
            txtAddress.Enabled = true;
            txtPassword.Enabled = true;
            txtPosition.Enabled = true;
        }

        private async void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            // Obtener el usuario actual desde el controlador
            var user = await _userController.GetUserByIdAsync(_currentUserId);

            if (user != null)
            {
                // Crear una instancia de EditUserForm y pasarle el usuario y el controlador
                EditUserForm editForm = new EditUserForm(user, _userController);

                // Suscribirse al evento UserUpdated
                editForm.UserUpdated += EditForm_UserUpdated;

                // Mostrar el formulario de edición
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo cargar la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejar el evento UserUpdated
        private void EditForm_UserUpdated(User updatedUser)
        {
            // Actualizar los datos en el ProfileForm
            txtName.Text = updatedUser.Name;
            txtLastName.Text = updatedUser.LastName;
            txtEmail.Text = updatedUser.Email;
            txtRole.Text = updatedUser.Role;
            txtAddress.Text = updatedUser.Address;

            if (updatedUser.Role == "Admin")
            {
                txtPosition.Text = updatedUser.Position;
            }
            else
            {
                txtPosition.Visible = false;
            }
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar tu cuenta?", "Eliminar cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                var user = await _userController.GetUserByIdAsync(_currentUserId);

                if (user != null)
                {
                    var success = await _userController.DeleteUserAsync(_currentUserId, _currentUserId, user.Role);

                    if (success)
                    {
                        MessageBox.Show("Cuenta eliminada con éxito.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_currentUserId, _userController);
            changePasswordForm.ShowDialog();
        }
    }
}

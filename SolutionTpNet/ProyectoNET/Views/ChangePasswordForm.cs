using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class ChangePasswordForm : Form
    {
        private readonly string _userId;
        private readonly UserController _userController;

        public ChangePasswordForm(string userId, UserController userController)
        {
            InitializeComponent();
            _userId = userId;
            _userController = userController;
        }

        private async void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la nueva contraseña cumpla con los requisitos
            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("La nueva contraseña no cumple con los requisitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si la contraseña actual es correcta
            var user = await _userController.GetUserByIdAsync(_userId);
            if (user == null)
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BCrypt.Net.BCrypt.Verify(currentPassword, user.Password))
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las nuevas contraseñas coincidan
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la contraseña del usuario
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.Password = hashedPassword;

            // Obtener el ID y rol del usuario actual (puedes obtener estos datos desde las propiedades de sesión o contexto global)
            string currentUserId = "idDelUsuarioActual"; // Debes asignarlo adecuadamente
            string currentUserRole = "rolDelUsuarioActual"; // Debes asignarlo adecuadamente

            bool success = await _userController.UpdateUserAsync(user, currentUserId, currentUserRole);

            if (success)
            {
                MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al cambiar la contraseña. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Za-z]") &&
                   Regex.IsMatch(password, @"[0-9]") &&
                   Regex.IsMatch(password, @"[\W_]"); // \W busca caracteres no alfanuméricos
        }
    }
}

using ProyectoNET.Controllers;
using ProyectoNET.Models;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks; // Importar para Task
using System.Windows.Forms;

namespace Signin
{
    internal partial class frmSignIn : Form
    {
        private readonly UserController _userController;

        // Definir el evento que será lanzado cuando el registro sea exitoso
        public event EventHandler RegistroExitoso;

        public frmSignIn(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

            // Asociar el evento KeyDown a todos los TextBox
            txtLegajo.KeyDown += new KeyEventHandler(txtKeyDown);
            txtName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtLastName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtEmail.KeyDown += new KeyEventHandler(txtKeyDown);
            txtDir.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwd.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwdConfirm.KeyDown += new KeyEventHandler(txtKeyDown);
        }

        // Simular clic en el botón btnRegistrarse al presionar Enter
        private void txtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evitar el beep cuando se presiona Enter
                btnRegistrarse.PerformClick(); // Simular un clic en el botón btnRegistrarse
            }
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            // Validar todos los campos antes de agregar al usuario
            if (await ValidateSignInAsync())
            {
                // Crear un usuario del tipo Student por defecto
                User student = new User
                {
                    File = txtLegajo.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPwd.Text,
                    Address = txtDir.Text,
                    Role = "Student"
                };

                // Agregar el usuario a través del controlador
                bool success = await _userController.AddUserAsync(student);
                if (success)
                {
                    MessageBox.Show("Se ha registrado exitosamente.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lanzar el evento RegistroExitoso
                    RegistroExitoso?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validar los campos del formulario de registro de manera asíncrona
        private async Task<bool> ValidateSignInAsync()
        {
            string error = "";

            // Validar legajo
            if (string.IsNullOrWhiteSpace(txtLegajo.Text) || !IsValidLegajo(txtLegajo.Text))
            {
                error = "El campo Legajo no puede estar vacío, debe contener al menos un número y tener un máximo de 10 caracteres.";
            }
            // Validar nombre
            else if (IsPlaceholderText(txtName.Text) || string.IsNullOrWhiteSpace(txtName.Text) || ContainsNumbers(txtName.Text))
            {
                error = "El campo de texto Nombre no puede estar vacío y no debe contener números.";
            }
            // Validar apellido
            else if (IsPlaceholderText(txtLastName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || ContainsNumbers(txtLastName.Text))
            {
                error = "El campo de texto Apellido no puede estar vacío y no debe contener números.";
            }
            // Validar dirección de correo electrónico
            else if (IsPlaceholderText(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "El campo de texto Email no puede estar vacío y debe tener un formato válido.";
            }
            // Validar dirección
            else if (IsPlaceholderText(txtDir.Text) || string.IsNullOrWhiteSpace(txtDir.Text))
            {
                error = "El campo de texto Dirección no puede estar vacío.";
            }
            // Validar contraseña
            else if (IsPlaceholderText(txtPwd.Text) || string.IsNullOrWhiteSpace(txtPwd.Text) || !IsValidPassword(txtPwd.Text))
            {
                error = "La contraseña debe tener al menos 8 caracteres, incluir letras, números y símbolos.";
            }
            // Validar confirmación de contraseña
            else if (txtPwd.Text != txtPwdConfirm.Text)
            {
                error = "Las contraseñas no coinciden.";
            }
            // Verificar si el usuario ya existe
            else if (await _userController.GetUserByIdAsync(txtLegajo.Text) != null)
            {
                error = "Ya existe un usuario registrado con ese Legajo.";
            }

            // Si no hay errores, devolver verdadero
            if (string.IsNullOrEmpty(error))
            {
                return true;
            }

            // Si hay errores, mostrar mensaje de error
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Verificar si el texto en el TextBox es el texto de marcador de posición
        private bool IsPlaceholderText(string text)
        {
            // Compara con el texto predeterminado para cada campo
            return text == "Introduce tu nombre" || text == "Introduce tu apellido" ||
                   text == "Introduce tu email" || text == "Introduce tu dirección" ||
                   text == "Introduce tu contraseña" || text == "Confirma tu contraseña";
        }

        // Validar si el legajo cumple con los requisitos
        private bool IsValidLegajo(string legajo)
        {
            // El legajo debe tener al menos un número, y puede tener letras (opcionales), y debe tener un máximo de 10 caracteres
            return legajo.Length <= 10 &&
                   Regex.IsMatch(legajo, @"[0-9]") &&
                   Regex.IsMatch(legajo, @"^[a-zA-Z0-9]+$"); // Solo letras y números
        }

        // Validar si la contraseña cumple con los requisitos
        private bool IsValidPassword(string password)
        {
            // La contraseña debe tener al menos 8 caracteres, incluyendo letras, dígitos y símbolos
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Za-z]") &&
                   Regex.IsMatch(password, @"[0-9]") &&
                   Regex.IsMatch(password, @"[\W_]"); // \W busca caracteres no alfanuméricos
        }

        // Verificar si el texto contiene números
        private bool ContainsNumbers(string text)
        {
            return Regex.IsMatch(text, @"\d");
        }

        // Manejar eventos de clic en los cuadros de texto para limpiar el contenido
        private void txtName_Click(object sender, EventArgs e) => txtName.Text = "";
        private void txtLastName_Click(object sender, EventArgs e) => txtLastName.Text = "";
        private void txtLegajo_Click(object sender, EventArgs e) => txtLegajo.Text = "";
        private void txtDir_Click(object sender, EventArgs e) => txtDir.Text = "";
        private void txtPwd_Click(object sender, EventArgs e) => txtPwd.Text = "";
        private void txtPwdConfirm_Click(object sender, EventArgs e) => txtPwdConfirm.Text = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

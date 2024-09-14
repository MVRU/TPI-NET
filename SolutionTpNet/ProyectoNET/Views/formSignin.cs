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

        // Definir el evento que ser� lanzado cuando el registro sea exitoso
        public event EventHandler RegistroExitoso;

        public frmSignIn(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

            // Asociar el evento KeyDown a todos los TextBox
            txtName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtLastName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtId.KeyDown += new KeyEventHandler(txtKeyDown);
            txtDir.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwd.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwdConfirm.KeyDown += new KeyEventHandler(txtKeyDown);
        }

        // Simular clic en el bot�n btnRegistrarse al presionar Enter
        private void txtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evitar el beep cuando se presiona Enter
                btnRegistrarse.PerformClick(); // Simular un clic en el bot�n btnRegistrarse
            }
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            // Validar todos los campos antes de agregar al usuario
            if (await ValidateSignInAsync())
            {
                // Crear un usuario del tipo Student por defecto
                Student student = new Student
                {
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Id = txtId.Text,
                    Password = txtPwd.Text,
                    Address = txtDir.Text,
                    Role = "Student"
                };

                // Agregar el usuario a trav�s del controlador
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

        // Validar los campos del formulario de registro de manera as�ncrona
        private async Task<bool> ValidateSignInAsync()
        {
            string error = "";

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                error = "El campo de texto Nombre no puede estar vac�o.";
            }
            // Validar apellido
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                error = "El campo de texto Apellido no puede estar vac�o.";
            }
            // Validar direcci�n de correo electr�nico
            else if (string.IsNullOrWhiteSpace(txtId.Text) || !Regex.IsMatch(txtId.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "El campo de texto Email no puede estar vac�o y debe tener un formato v�lido.";
            }
            // Validar direcci�n
            else if (string.IsNullOrWhiteSpace(txtDir.Text))
            {
                error = "El campo de texto Direcci�n no puede estar vac�o.";
            }
            // Validar contrase�a
            else if (string.IsNullOrWhiteSpace(txtPwd.Text) || !IsValidPassword(txtPwd.Text))
            {
                error = "La contrase�a debe tener al menos 8 caracteres, incluir letras, n�meros y s�mbolos.";
            }
            // Validar confirmaci�n de contrase�a
            else if (txtPwd.Text != txtPwdConfirm.Text)
            {
                error = "Las contrase�as no coinciden.";
            }
            // Verificar si el usuario ya existe
            else if (await _userController.GetUserByIdAsync(txtId.Text) != null)
            {
                error = "Ya existe un usuario registrado con ese email.";
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

        // Validar si la contrase�a cumple con los requisitos
        private bool IsValidPassword(string password)
        {
            // La contrase�a debe tener al menos 8 caracteres, incluyendo letras, d�gitos y s�mbolos
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Za-z]") &&
                   Regex.IsMatch(password, @"[0-9]") &&
                   Regex.IsMatch(password, @"[\W_]"); // \W busca caracteres no alfanum�ricos
        }

        // Manejar eventos de clic en los cuadros de texto para limpiar el contenido
        private void txtName_Click(object sender, EventArgs e) => txtName.Text = "";
        private void txtLastName_Click(object sender, EventArgs e) => txtLastName.Text = "";
        private void txtId_Click(object sender, EventArgs e) => txtId.Text = "";
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

    }

}

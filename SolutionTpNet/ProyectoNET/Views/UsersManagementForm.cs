using ProyectoNET.Data;
using ProyectoNET.Models;
using ProyectoNET.Repositories;
using ProyectoNET.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNET.Views
{
    public partial class UsersManagementForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly UserController _userController;
        private List<User> _users;
        private string _currentUserId; // Id del usuario actual

        public UsersManagementForm(UserRepository userRepository, UserController userController)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _userController = userController;
            LoadUsersAsync();
        }

        // Método para establecer el ID del usuario actual
        public void SetCurrentUserId(string currentUserId)
        {
            _currentUserId = currentUserId;
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
        }

        private async void LoadUsersAsync()
        {
            try
            {
                _users = await _userRepository.GetAllUsersAsync();
                if (_users.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios.");
                }
                else
                {
                    dgvUsuarios.DataSource = _users.Select(u => new
                    {
                        u.File,
                        u.Name,
                        u.LastName,
                        u.Email,
                        u.Role
                    }).ToList();

                    // Cambiar los nombres de las columnas en el DataGridView a español
                    dgvUsuarios.Columns["File"].HeaderText = "Legajo";
                    dgvUsuarios.Columns["Name"].HeaderText = "Nombre";
                    dgvUsuarios.Columns["LastName"].HeaderText = "Apellido";
                    dgvUsuarios.Columns["Role"].HeaderText = "Rol";

                    // Ajustar automáticamente el tamaño de las columnas según el contenido
                    dgvUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
            }
        }

        // Método para editar un usuario
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUserFile = dgvUsuarios.SelectedRows[0].Cells["File"].Value.ToString();
                var user = _users.FirstOrDefault(u => u.File == selectedUserFile);
                if (user != null)
                {
                    var editUserForm = new EditUserForm(user, _userController); // Formulario de edición
                    editUserForm.ShowDialog();
                    LoadUsersAsync(); // Recargar los usuarios
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para editar.");
            }
        }

        // Método para eliminar un usuario
        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUserFile = dgvUsuarios.SelectedRows[0].Cells["File"].Value.ToString();

                // Bloquear eliminación del usuario actual
                if (selectedUserFile == _currentUserId)
                {
                    MessageBox.Show("No puedes eliminar tu propia cuenta.");
                    return;
                }

                var user = _users.FirstOrDefault(u => u.File == selectedUserFile);
                if (user != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var success = await _userController.DeleteUserAsync(user.File, _currentUserId, "Admin");
                        if (success)
                        {
                            LoadUsersAsync(); // Recargar los usuarios
                            MessageBox.Show("Usuario eliminado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar el usuario.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

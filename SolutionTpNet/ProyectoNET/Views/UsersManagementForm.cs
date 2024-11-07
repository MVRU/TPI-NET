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

        public UsersManagementForm(UserRepository userRepository, UserController userController)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _userController = userController;
            LoadUsersAsync(); 
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}");
            }
        }

        // Método para editar un usuario
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUserFile = dgvUsuarios.SelectedRows[0].Cells["File"].Value.ToString();
                var user = _users.FirstOrDefault(u => u.File == selectedUserFile);
                if (user != null)
                {
                    var editUserForm = new EditUserForm(user); // Formulario de edición
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
        private async void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUserFile = dgvUsuarios.SelectedRows[0].Cells["File"].Value.ToString();
                var user = _users.FirstOrDefault(u => u.File == selectedUserFile);
                if (user != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var success = await _userController.DeleteUserAsync(user.File, "Admin");
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

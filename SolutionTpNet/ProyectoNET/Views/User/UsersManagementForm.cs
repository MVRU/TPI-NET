using ProyectoNET.Controllers;
using ProyectoNET.Data;
using ProyectoNET.Models;
using ProyectoNET.Repositories;

namespace ProyectoNET.Views
{
    public partial class UsersManagementForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly UserController _userController;
        private readonly UniversityContext _context;
        private List<User> _users;
        private string _currentUserId; // Id del usuario actual

        public UsersManagementForm(UserRepository userRepository, UserController userController, UniversityContext context)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _userController = userController;
            _context = context;
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

        // Método para mostrar el reporte de un usuario
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var selectedUserFile = dgvUsuarios.SelectedRows[0].Cells["File"].Value.ToString();
                var user = _users.FirstOrDefault(u => u.File == selectedUserFile);

                if (user != null)
                {
                    try
                    {
                        // Crear las instancias de los repositorios necesarios usando DI
                        var enrollmentRepository = new EnrollmentRepository(_context); // Usamos el contexto inyectado
                        var courseRepository = new CourseRepository(_context); // Instancia de CourseRepository

                        // Crear una instancia de EnrollmentController pasando ambos repositorios
                        var enrollmentController = new EnrollmentController(enrollmentRepository, courseRepository);

                        // Crear una instancia de AttendanceController
                        var attendanceController = new AttendanceController(new AttendanceRepository(_context));

                        // Crear una nueva instancia de UserReportForm y pasarle los parámetros necesarios
                        var userReportForm = new UserReportForm(user.File, _userController, enrollmentController, attendanceController);

                        // Abrir el formulario de reporte de usuario
                        userReportForm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el reporte del usuario: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para ver el reporte.");
            }
        }
    }
}

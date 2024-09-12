using ProyectoNET;

namespace Signin
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
            // Asociar el evento KeyDown a todos los TextBox
            txtName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtLastName.KeyDown += new KeyEventHandler(txtKeyDown);
            txtId.KeyDown += new KeyEventHandler(txtKeyDown);
            txtDir.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwd.KeyDown += new KeyEventHandler(txtKeyDown);
            txtPwdConfirm.KeyDown += new KeyEventHandler(txtKeyDown);
    }

        // Activar botón btnRegistrarse al presionar Enter
        private void txtKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Evitar el beep cuando se presiona Enter
                e.SuppressKeyPress = true;
                
                // Simular un clic en el botón btnRegistrarse
                btnRegistrarse.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserController oper = new UserController();

            if (checkSignIn(oper))
            {
                // Crear un usuario del tipo Student por defecto
                Student student = new Student();
                student.Name = txtName.Text;
                student.LastName = txtLastName.Text;
                student.Id = txtId.Text;
                student.Password = txtPwd.Text;
                student.Address = txtDir.Text;
                // Asignar el rol como Student
                student.Role = "Student";
                // Agregar el student a la base de datos
                oper.addUser(student);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }
        private void txtDir_Click(object sender, EventArgs e)
        {
            txtDir.Text = "";
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
        }
        private void txtPwdCondirm_Click(object sender, EventArgs e)
        {
            txtPwdConfirm.Text = "";
        }

        private bool checkSignIn(UserController o)
        {
            bool state = false;
            string error = "";
            //Validando datos
            if (txtName.Text.Length == 0) { error = "El campo de texto Nombre no puede estar vacio."; }
            if (txtLastName.Text.Length == 0) { error = "El campo de texto Apellido no puede estar vacio."; }
            if (txtId.Text.Length == 0) { error = "El campo de texto Email no puede estar vacio."; }
            if (txtDir.Text.Length == 0) { error = "El campo de texto Direccion no puede estar vacio."; }
            if (txtPwd.Text.Length < 8) { error = "El campo de texto Password no puede estar vacio."; }
            if (txtPwd.Text != txtPwdConfirm.Text) { error = "Las contraseñas no coinciden."; }
            if (o.getUserById(txtId.Text) != null) { error = "Ya hay un usuario registrado con ese mail."; }
            //Si el registro esta OK
            if (error == "")
            {
                MessageBox.Show("Se ha registrado exitosamente.", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

                

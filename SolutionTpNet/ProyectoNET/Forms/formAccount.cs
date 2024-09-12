using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoNET.Operations;
using ProyectoNET.Classes;

namespace ProyectoNET.Forms
{
    public partial class formAccount : Form
    {
        public formAccount(User user)
        {
            InitializeComponent();
            //txtName.Text = user.Name;
            //txtLastName.Text = user.LastName;
            //txtDir.Text = user.Dir;

            if (user == null) { txtDir.Text = "hola"; }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            Operation oper = new Operation();
            User user = oper.getUserById(txtId.Text);
            txtName.Enabled = true;
            txtLastName.Enabled = true;
            txtDir.Enabled = true;
            txtPwd.Visible = true;
            txtPwdConfirm.Visible = true;
            txtPwd.Enabled = true;
            txtPwdConfirm.Enabled = true;
            lblPwd.Visible = true;
            lblPwdConfirm.Visible = true;
            btnEditProfile.Enabled = false;
            btnOk.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (checkEditProfile())
            {
                Operation oper = new Operation();
                User updatedUser = new User()
                {
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Password = txtPwd.Text,
                    Dir = txtDir.Text
                };
                oper.updateUser(updatedUser);
                txtName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtDir.ReadOnly = true;
                txtPwd.Enabled = false;
                txtPwdConfirm.Enabled = false;
                txtPwd.Visible = false;
                txtPwdConfirm.Visible=false;
                lblPwd.Visible = false;
                lblPwdConfirm.Visible = false;
                btnEditProfile.Enabled = true;
                btnOk.Enabled = false;
            }
        }

        private bool checkEditProfile()
        {
            string error = "";
            //Validando datos
            if (txtName.Text.Length == 0) { error = "El campo de texto Nombre no puede estar vacio."; }
            if (txtLastName.Text.Length == 0) { error = "El campo de texto Apellido no puede estar vacio."; }
            if (txtDir.Text.Length == 0) { error = "El campo de texto Direccion no puede estar vacio."; }
            if (txtPwd.Text.Length < 8) { error = "El campo de texto Password no puede estar vacio."; }
            if (txtPwd.Text != txtPwdConfirm.Text) { error = "Las contraseñas no coinciden."; }
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

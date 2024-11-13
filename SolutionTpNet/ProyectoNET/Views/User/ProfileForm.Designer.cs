namespace ProyectoNET.Views
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtRole = new TextBox();
            lblRole = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtPosition = new TextBox();
            lblPosition = new Label();
            btnModificarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnCambiarContraseña = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(90, 73);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(158, 118);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(90, 121);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(51, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(90, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(158, 218);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(100, 23);
            txtRole.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(90, 221);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(24, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Rol";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 267);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(90, 270);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Dirección";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 317);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(80, 320);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Contraseña";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(158, 367);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 23);
            txtPosition.TabIndex = 13;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(90, 370);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(52, 15);
            lblPosition.TabIndex = 12;
            lblPosition.Text = "Posición";
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(72, 437);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(75, 23);
            btnModificarUsuario.TabIndex = 14;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(296, 437);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(114, 23);
            btnEliminarUsuario.TabIndex = 15;
            btnEliminarUsuario.Text = "Eliminar cuenta";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(158, 437);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(132, 23);
            btnCambiarContraseña.TabIndex = 16;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(503, 501);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtRole);
            Controls.Add(lblRole);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "ProfileForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            WindowState = FormWindowState.Maximized;
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtRole;
        private Label lblRole;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtPosition;
        private Label lblPosition;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private Button btnCambiarContraseña;
    }
}
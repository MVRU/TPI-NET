namespace Signin
{
    partial class frmSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblNombre = new Label();
            lblConfiguraTuCuenta = new Label();
            btnRegistrarse = new Button();
            lblApellido = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtDir = new TextBox();
            label3 = new Label();
            txtPwd = new TextBox();
            lblRepetirContraseña = new Label();
            txtPwdConfirm = new TextBox();
            lblRequisitosContraseña = new Label();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 237, 242);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(79, 122, 148);
            txtName.Location = new Point(158, 160);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(393, 19);
            txtName.TabIndex = 1;
            txtName.Text = "Introduce tu nombre";
            txtName.Click += txtName_Click;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombre.Location = new Point(158, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblConfiguraTuCuenta
            // 
            lblConfiguraTuCuenta.AutoSize = true;
            lblConfiguraTuCuenta.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfiguraTuCuenta.ForeColor = Color.FromArgb(13, 23, 28);
            lblConfiguraTuCuenta.Location = new Point(210, 26);
            lblConfiguraTuCuenta.Name = "lblConfiguraTuCuenta";
            lblConfiguraTuCuenta.Size = new Size(270, 31);
            lblConfiguraTuCuenta.TabIndex = 12;
            lblConfiguraTuCuenta.Text = "Configura tu cuenta";
            lblConfiguraTuCuenta.Click += label7_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(59, 161, 227);
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(158, 520);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(393, 30);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnSignIn_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.FromArgb(13, 23, 28);
            lblApellido.Location = new Point(158, 192);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(232, 237, 242);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(79, 122, 148);
            txtLastName.Location = new Point(158, 217);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(393, 19);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Introduce tu apellido";
            txtLastName.Click += txtLastName_Click;
            txtLastName.TextChanged += textBox3_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(13, 23, 28);
            lblEmail.Location = new Point(158, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(154, 20);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email institucional";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(232, 237, 242);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(79, 122, 148);
            txtEmail.Location = new Point(158, 275);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(393, 19);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Introduce tu email institucional";
            txtEmail.TextChanged += txtId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 23, 28);
            label2.Location = new Point(158, 311);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 19;
            label2.Text = "Direccion";
            label2.Click += label2_Click_1;
            // 
            // txtDir
            // 
            txtDir.BackColor = Color.FromArgb(232, 237, 242);
            txtDir.BorderStyle = BorderStyle.None;
            txtDir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDir.ForeColor = Color.FromArgb(79, 122, 148);
            txtDir.Location = new Point(158, 336);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(393, 19);
            txtDir.TabIndex = 4;
            txtDir.Text = "Introduce tu direccion";
            txtDir.Click += txtDir_Click;
            txtDir.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(158, 372);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 21;
            label3.Text = "Contraseña";
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.FromArgb(232, 237, 242);
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.ForeColor = Color.FromArgb(79, 122, 148);
            txtPwd.Location = new Point(158, 416);
            txtPwd.Margin = new Padding(3, 2, 3, 2);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(393, 19);
            txtPwd.TabIndex = 5;
            txtPwd.Text = "Introduce tu contraseña";
            txtPwd.Click += txtPwd_Click;
            // 
            // lblRepetirContraseña
            // 
            lblRepetirContraseña.AutoSize = true;
            lblRepetirContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepetirContraseña.ForeColor = Color.FromArgb(13, 23, 28);
            lblRepetirContraseña.Location = new Point(159, 449);
            lblRepetirContraseña.Name = "lblRepetirContraseña";
            lblRepetirContraseña.Size = new Size(178, 20);
            lblRepetirContraseña.TabIndex = 23;
            lblRepetirContraseña.Text = "Repite tu contraseña";
            // 
            // txtPwdConfirm
            // 
            txtPwdConfirm.BackColor = Color.FromArgb(232, 237, 242);
            txtPwdConfirm.BorderStyle = BorderStyle.None;
            txtPwdConfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwdConfirm.ForeColor = Color.FromArgb(79, 122, 148);
            txtPwdConfirm.Location = new Point(159, 474);
            txtPwdConfirm.Margin = new Padding(3, 2, 3, 2);
            txtPwdConfirm.Name = "txtPwdConfirm";
            txtPwdConfirm.PasswordChar = '*';
            txtPwdConfirm.Size = new Size(393, 19);
            txtPwdConfirm.TabIndex = 6;
            txtPwdConfirm.Text = "Introduce tu contraseña";
            txtPwdConfirm.Click += txtPwdConfirm_Click;
            // 
            // lblRequisitosContraseña
            // 
            lblRequisitosContraseña.AutoSize = true;
            lblRequisitosContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequisitosContraseña.ForeColor = Color.FromArgb(79, 122, 148);
            lblRequisitosContraseña.Location = new Point(158, 392);
            lblRequisitosContraseña.Name = "lblRequisitosContraseña";
            lblRequisitosContraseña.Size = new Size(367, 15);
            lblRequisitosContraseña.TabIndex = 24;
            lblRequisitosContraseña.Text = "Usa más de 8 caracteres, combinando letras, números y símbolos";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLegajo.ForeColor = Color.FromArgb(13, 23, 28);
            lblLegajo.Location = new Point(159, 80);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(63, 20);
            lblLegajo.TabIndex = 26;
            lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.BackColor = Color.FromArgb(232, 237, 242);
            txtLegajo.BorderStyle = BorderStyle.None;
            txtLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLegajo.ForeColor = Color.FromArgb(79, 122, 148);
            txtLegajo.Location = new Point(159, 105);
            txtLegajo.Margin = new Padding(3, 2, 3, 2);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(393, 19);
            txtLegajo.TabIndex = 0;
            txtLegajo.Text = "Introduce tu legajo";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(686, 576);
            Controls.Add(lblLegajo);
            Controls.Add(txtLegajo);
            Controls.Add(lblRequisitosContraseña);
            Controls.Add(lblRepetirContraseña);
            Controls.Add(txtPwdConfirm);
            Controls.Add(label3);
            Controls.Add(txtPwd);
            Controls.Add(label2);
            Controls.Add(txtDir);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblApellido);
            Controls.Add(txtLastName);
            Controls.Add(btnRegistrarse);
            Controls.Add(lblConfiguraTuCuenta);
            Controls.Add(lblNombre);
            Controls.Add(txtName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSignIn";
            ShowIcon = false;
            Text = "Sign In";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblNombre;
        private Label lblConfiguraTuCuenta;
        private Button btnRegistrarse;
        private Label lblApellido;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtDir;
        private Label label3;
        private TextBox txtPwd;
        private Label lblRepetirContraseña;
        private TextBox txtPwdConfirm;
        private Label lblRequisitosContraseña;
        private Label lblLegajo;
        private TextBox txtLegajo;
    }
}

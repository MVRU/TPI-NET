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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtDir = new TextBox();
            label3 = new Label();
            txtPwd = new TextBox();
            lblRepetirContraseña = new Label();
            txtPwdConfirm = new TextBox();
            lblRequisitosContraseña = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 237, 242);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(79, 122, 148);
            txtName.Location = new Point(226, 183);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(561, 28);
            txtName.TabIndex = 0;
            txtName.Text = "Introduce tu nombre";
            txtName.Click += txtName_Click;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombre.Location = new Point(226, 142);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 29);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblConfiguraTuCuenta
            // 
            lblConfiguraTuCuenta.AutoSize = true;
            lblConfiguraTuCuenta.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfiguraTuCuenta.ForeColor = Color.FromArgb(13, 23, 28);
            lblConfiguraTuCuenta.Location = new Point(300, 43);
            lblConfiguraTuCuenta.Margin = new Padding(4, 0, 4, 0);
            lblConfiguraTuCuenta.Name = "lblConfiguraTuCuenta";
            lblConfiguraTuCuenta.Size = new Size(399, 47);
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
            btnRegistrarse.Location = new Point(226, 768);
            btnRegistrarse.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(561, 50);
            btnRegistrarse.TabIndex = 13;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnSignIn_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.FromArgb(13, 23, 28);
            lblApellido.Location = new Point(226, 237);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(110, 29);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(232, 237, 242);
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(79, 122, 148);
            txtLastName.Location = new Point(226, 278);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(561, 28);
            txtLastName.TabIndex = 14;
            txtLastName.Text = "Introduce tu apellido";
            txtLastName.Click += txtLastName_Click;
            txtLastName.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 23, 28);
            label1.Location = new Point(226, 333);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 29);
            label1.TabIndex = 17;
            label1.Text = "Email institucional";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(232, 237, 242);
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(79, 122, 148);
            txtId.Location = new Point(226, 375);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(561, 28);
            txtId.TabIndex = 16;
            txtId.Text = "Introduce tu email institucional";
            txtId.Click += txtId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 23, 28);
            label2.Location = new Point(226, 435);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
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
            txtDir.Location = new Point(226, 477);
            txtDir.Margin = new Padding(4, 3, 4, 3);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(561, 28);
            txtDir.TabIndex = 18;
            txtDir.Text = "Introduce tu direccion";
            txtDir.Click += txtDir_Click;
            txtDir.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(226, 537);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 29);
            label3.TabIndex = 21;
            label3.Text = "Contraseña";
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.FromArgb(232, 237, 242);
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.ForeColor = Color.FromArgb(79, 122, 148);
            txtPwd.Location = new Point(226, 610);
            txtPwd.Margin = new Padding(4, 3, 4, 3);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(561, 28);
            txtPwd.TabIndex = 20;
            txtPwd.Text = "Introduce tu contraseña";
            txtPwd.Click += txtPwd_Click;
            // 
            // lblRepetirContraseña
            // 
            lblRepetirContraseña.AutoSize = true;
            lblRepetirContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepetirContraseña.ForeColor = Color.FromArgb(13, 23, 28);
            lblRepetirContraseña.Location = new Point(227, 665);
            lblRepetirContraseña.Margin = new Padding(4, 0, 4, 0);
            lblRepetirContraseña.Name = "lblRepetirContraseña";
            lblRepetirContraseña.Size = new Size(253, 29);
            lblRepetirContraseña.TabIndex = 23;
            lblRepetirContraseña.Text = "Repite tu contraseña";
            // 
            // txtPwdConfirm
            // 
            txtPwdConfirm.BackColor = Color.FromArgb(232, 237, 242);
            txtPwdConfirm.BorderStyle = BorderStyle.None;
            txtPwdConfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwdConfirm.ForeColor = Color.FromArgb(79, 122, 148);
            txtPwdConfirm.Location = new Point(227, 707);
            txtPwdConfirm.Margin = new Padding(4, 3, 4, 3);
            txtPwdConfirm.Name = "txtPwdConfirm";
            txtPwdConfirm.PasswordChar = '*';
            txtPwdConfirm.Size = new Size(561, 28);
            txtPwdConfirm.TabIndex = 22;
            txtPwdConfirm.Text = "Introduce tu contraseña";
            txtPwdConfirm.Click += txtPwdCondirm_Click;
            // 
            // lblRequisitosContraseña
            // 
            lblRequisitosContraseña.AutoSize = true;
            lblRequisitosContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequisitosContraseña.ForeColor = Color.FromArgb(79, 122, 148);
            lblRequisitosContraseña.Location = new Point(226, 570);
            lblRequisitosContraseña.Margin = new Padding(4, 0, 4, 0);
            lblRequisitosContraseña.Name = "lblRequisitosContraseña";
            lblRequisitosContraseña.Size = new Size(533, 22);
            lblRequisitosContraseña.TabIndex = 24;
            lblRequisitosContraseña.Text = "Usa más de 8 caracteres, combinando letras, números y símbolos";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(980, 853);
            Controls.Add(lblRequisitosContraseña);
            Controls.Add(lblRepetirContraseña);
            Controls.Add(txtPwdConfirm);
            Controls.Add(label3);
            Controls.Add(txtPwd);
            Controls.Add(label2);
            Controls.Add(txtDir);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(lblApellido);
            Controls.Add(txtLastName);
            Controls.Add(btnRegistrarse);
            Controls.Add(lblConfiguraTuCuenta);
            Controls.Add(lblNombre);
            Controls.Add(txtName);
            Margin = new Padding(4, 3, 4, 3);
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
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtDir;
        private Label label3;
        private TextBox txtPwd;
        private Label lblRepetirContraseña;
        private TextBox txtPwdConfirm;
        private Label lblRequisitosContraseña;
    }
}

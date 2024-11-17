namespace DesktopApp
{
    partial class SignInForm
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
            panel1 = new Panel();
            label2 = new Label();
            lblEmail = new Label();
            lblLastName = new Label();
            lblName = new Label();
            lblFile = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnSignIn = new Button();
            linkLogIn = new LinkLabel();
            txtFile = new ComboBox();
            txtName = new ComboBox();
            txtLastName = new ComboBox();
            txtEmail = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 72);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Lexend", 30F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 23, 28);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(798, 64);
            label2.TabIndex = 8;
            label2.Text = "Configurá tu cuenta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(13, 23, 28);
            lblEmail.Location = new Point(172, 330);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(168, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email institucional";
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(13, 23, 28);
            lblLastName.Location = new Point(172, 255);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 25);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "Apellido";
            // 
            // lblName
            // 
            lblName.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(13, 23, 28);
            lblName.Location = new Point(172, 179);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 25);
            lblName.TabIndex = 14;
            lblName.Text = "Nombre";
            // 
            // lblFile
            // 
            lblFile.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblFile.ForeColor = Color.FromArgb(13, 23, 28);
            lblFile.Location = new Point(172, 108);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(72, 25);
            lblFile.TabIndex = 16;
            lblFile.Text = "Legajo";
            // 
            // label1
            // 
            label1.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(13, 23, 28);
            label1.Location = new Point(172, 409);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 18;
            label1.Text = "Contraseña";
            // 
            // label3
            // 
            label3.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(172, 511);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 20;
            label3.Text = "Repetí tu contraseña";
            // 
            // label4
            // 
            label4.Font = new Font("Lexend", 10F);
            label4.ForeColor = Color.FromArgb(79, 122, 148);
            label4.Location = new Point(3, 431);
            label4.Name = "label4";
            label4.Size = new Size(798, 29);
            label4.TabIndex = 21;
            label4.Text = "Usá más de 8 caracteres, combinando letras, números y símbolos.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(linkLogIn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 595);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 115);
            panel2.TabIndex = 22;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(59, 161, 227);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Lexend", 14F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.FromArgb(13, 23, 28);
            btnSignIn.Location = new Point(178, 5);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(448, 48);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Crear cuenta";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // linkLogIn
            // 
            linkLogIn.ActiveLinkColor = Color.FromArgb(59, 161, 227);
            linkLogIn.Font = new Font("Lexend", 12F);
            linkLogIn.LinkColor = Color.FromArgb(79, 122, 148);
            linkLogIn.Location = new Point(12, 69);
            linkLogIn.Name = "linkLogIn";
            linkLogIn.Size = new Size(780, 25);
            linkLogIn.TabIndex = 7;
            linkLogIn.TabStop = true;
            linkLogIn.Text = "¿Ya tenés una cuenta? Iniciá sesión.";
            linkLogIn.TextAlign = ContentAlignment.MiddleCenter;
            linkLogIn.VisitedLinkColor = Color.FromArgb(59, 161, 227);
            linkLogIn.LinkClicked += linkLogIn_LinkClicked;
            // 
            // txtFile
            // 
            txtFile.BackColor = Color.FromArgb(232, 237, 242);
            txtFile.DropDownStyle = ComboBoxStyle.Simple;
            txtFile.Font = new Font("Lexend", 12F);
            txtFile.ForeColor = Color.FromArgb(79, 122, 148);
            txtFile.FormattingEnabled = true;
            txtFile.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtFile.Location = new Point(178, 136);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(448, 33);
            txtFile.TabIndex = 0;
            txtFile.Text = "Introduce tu legajo";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 237, 242);
            txtName.DropDownStyle = ComboBoxStyle.Simple;
            txtName.Font = new Font("Lexend", 12F);
            txtName.ForeColor = Color.FromArgb(79, 122, 148);
            txtName.FormattingEnabled = true;
            txtName.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtName.Location = new Point(178, 207);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 33);
            txtName.TabIndex = 1;
            txtName.Text = "Introduce tu nombre";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(232, 237, 242);
            txtLastName.DropDownStyle = ComboBoxStyle.Simple;
            txtLastName.Font = new Font("Lexend", 12F);
            txtLastName.ForeColor = Color.FromArgb(79, 122, 148);
            txtLastName.FormattingEnabled = true;
            txtLastName.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtLastName.Location = new Point(178, 283);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(448, 33);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Introduce tu apellido";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(232, 237, 242);
            txtEmail.DropDownStyle = ComboBoxStyle.Simple;
            txtEmail.Font = new Font("Lexend", 12F);
            txtEmail.ForeColor = Color.FromArgb(79, 122, 148);
            txtEmail.FormattingEnabled = true;
            txtEmail.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtEmail.Location = new Point(178, 358);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(448, 33);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Introduce tu email institucional";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(232, 237, 242);
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.Font = new Font("Lexend", 12F);
            comboBox1.ForeColor = Color.FromArgb(79, 122, 148);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            comboBox1.Location = new Point(178, 463);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(448, 33);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Introduce tu contraseña";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(232, 237, 242);
            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.Font = new Font("Lexend", 12F);
            comboBox2.ForeColor = Color.FromArgb(79, 122, 148);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            comboBox2.Location = new Point(178, 539);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(448, 33);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "Introduce tu contraseña nuevamente";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(804, 710);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtFile);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblFile);
            Controls.Add(lblName);
            Controls.Add(lblLastName);
            Controls.Add(lblEmail);
            Controls.Add(panel1);
            Font = new Font("Lexend", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblName;
        private Label lblFile;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private LinkLabel linkLogIn;
        private Button btnSignIn;
        private ComboBox txtFile;
        private ComboBox txtName;
        private ComboBox txtLastName;
        private ComboBox txtEmail;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
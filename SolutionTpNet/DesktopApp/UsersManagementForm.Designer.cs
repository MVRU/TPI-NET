namespace DesktopApp
{
    partial class UsersManagementForm
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
            txtFile = new ComboBox();
            txtName = new ComboBox();
            txtLastName = new ComboBox();
            txtEmail = new ComboBox();
            button1 = new Button();
            btnLogIn = new Button();
            cbRole = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblFile = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvUsers = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFile);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFile);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 529);
            panel1.TabIndex = 0;
            // 
            // txtFile
            // 
            txtFile.BackColor = Color.FromArgb(232, 237, 242);
            txtFile.DropDownStyle = ComboBoxStyle.Simple;
            txtFile.Font = new Font("Lexend", 12F);
            txtFile.ForeColor = Color.FromArgb(79, 122, 148);
            txtFile.FormattingEnabled = true;
            txtFile.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtFile.Location = new Point(12, 103);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(273, 33);
            txtFile.TabIndex = 0;
            txtFile.Text = "Introduce el legajo";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(232, 237, 242);
            txtName.DropDownStyle = ComboBoxStyle.Simple;
            txtName.Font = new Font("Lexend", 12F);
            txtName.ForeColor = Color.FromArgb(79, 122, 148);
            txtName.FormattingEnabled = true;
            txtName.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtName.Location = new Point(11, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 33);
            txtName.TabIndex = 1;
            txtName.Text = "Introduce el nombre";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(232, 237, 242);
            txtLastName.DropDownStyle = ComboBoxStyle.Simple;
            txtLastName.Font = new Font("Lexend", 12F);
            txtLastName.ForeColor = Color.FromArgb(79, 122, 148);
            txtLastName.FormattingEnabled = true;
            txtLastName.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtLastName.Location = new Point(12, 232);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 33);
            txtLastName.TabIndex = 2;
            txtLastName.Text = "Introduce el apellido";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(232, 237, 242);
            txtEmail.DropDownStyle = ComboBoxStyle.Simple;
            txtEmail.Font = new Font("Lexend", 12F);
            txtEmail.ForeColor = Color.FromArgb(79, 122, 148);
            txtEmail.FormattingEnabled = true;
            txtEmail.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtEmail.Location = new Point(11, 301);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 33);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Introduce el email institucional";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 237, 242);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lexend", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(13, 23, 28);
            button1.Location = new Point(12, 478);
            button1.Name = "button1";
            button1.Size = new Size(273, 40);
            button1.TabIndex = 6;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(59, 161, 227);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Lexend", 12F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.FromArgb(13, 23, 28);
            btnLogIn.Location = new Point(11, 432);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(274, 40);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Guardar";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // cbRole
            // 
            cbRole.AutoCompleteCustomSource.AddRange(new string[] { "Estudiante", "Profesor", "Administrador" });
            cbRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbRole.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbRole.BackColor = Color.FromArgb(232, 237, 242);
            cbRole.DropDownStyle = ComboBoxStyle.Simple;
            cbRole.Font = new Font("Lexend", 12F);
            cbRole.ForeColor = Color.FromArgb(79, 122, 148);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            cbRole.Location = new Point(12, 371);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(273, 33);
            cbRole.TabIndex = 4;
            cbRole.Text = "Introduce el rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(13, 23, 28);
            label6.Location = new Point(12, 343);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 17;
            label6.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(13, 23, 28);
            label5.Location = new Point(12, 273);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 15;
            label5.Text = "Email institucional";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(13, 23, 28);
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 13;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 11;
            label3.Text = "Nombre";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblFile.ForeColor = Color.FromArgb(13, 23, 28);
            lblFile.Location = new Point(12, 75);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(67, 25);
            lblFile.TabIndex = 9;
            lblFile.Text = "Legajo";
            // 
            // label2
            // 
            label2.Font = new Font("Lexend", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 23, 28);
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(295, 51);
            label2.TabIndex = 8;
            label2.Text = "Crear usuario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Lexend", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(13, 23, 28);
            label1.Location = new Point(34, 0);
            label1.Name = "label1";
            label1.Size = new Size(843, 64);
            label1.TabIndex = 7;
            label1.Text = "Gestión de usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(297, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 69);
            panel2.TabIndex = 8;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(232, 237, 242);
            dgvUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = Color.FromArgb(0, 120, 212);
            dgvUsers.Location = new Point(331, 76);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(843, 443);
            dgvUsers.TabIndex = 7;
            // 
            // UsersManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(1177, 529);
            Controls.Add(dgvUsers);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Lexend", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsersManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvUsers;
        private Label label2;
        private Label lblFile;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox cbRole;
        private Button button1;
        private Button btnLogIn;
        private ComboBox txtEmail;
        private ComboBox txtFile;
        private ComboBox txtName;
        private ComboBox txtLastName;
    }
}
namespace DesktopApp
{
    partial class LogInForm
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
            lblWelcome = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblFile = new Label();
            label3 = new Label();
            cbKeepLoggedIn = new CheckBox();
            btnLogIn = new Button();
            panel2 = new Panel();
            linkSignIn = new LinkLabel();
            linkPasswordForgotten = new LinkLabel();
            txtFile = new ComboBox();
            txtPassword = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Lexend", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(13, 23, 28);
            lblWelcome.Location = new Point(12, 5);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(776, 64);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Bienvenido a la UTN";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Lexend", 12F);
            label2.ForeColor = Color.FromArgb(79, 122, 148);
            label2.Location = new Point(158, 57);
            label2.Name = "label2";
            label2.Size = new Size(503, 77);
            label2.TabIndex = 7;
            label2.Text = "Controlá la asistencia, realizá un seguimiento de la participación y gestioná tus clases con facilidad.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 138);
            panel1.TabIndex = 2;
            // 
            // lblFile
            // 
            lblFile.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            lblFile.ForeColor = Color.FromArgb(13, 23, 28);
            lblFile.Location = new Point(174, 161);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(74, 25);
            lblFile.TabIndex = 3;
            lblFile.Text = "Legajo";
            // 
            // label3
            // 
            label3.Font = new Font("Lexend Medium", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(174, 252);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // cbKeepLoggedIn
            // 
            cbKeepLoggedIn.AutoSize = true;
            cbKeepLoggedIn.Font = new Font("Lexend", 12F);
            cbKeepLoggedIn.ForeColor = Color.FromArgb(13, 23, 28);
            cbKeepLoggedIn.Location = new Point(181, 335);
            cbKeepLoggedIn.Name = "cbKeepLoggedIn";
            cbKeepLoggedIn.Size = new Size(231, 29);
            cbKeepLoggedIn.TabIndex = 2;
            cbKeepLoggedIn.Text = "Manten mi sesión iniciada";
            cbKeepLoggedIn.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(59, 161, 227);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Lexend", 14F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.FromArgb(13, 23, 28);
            btnLogIn.Location = new Point(181, 384);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(448, 48);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Iniciar sesión";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkSignIn);
            panel2.Controls.Add(linkPasswordForgotten);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 82);
            panel2.TabIndex = 8;
            // 
            // linkSignIn
            // 
            linkSignIn.ActiveLinkColor = Color.FromArgb(59, 161, 227);
            linkSignIn.Font = new Font("Lexend", 12F);
            linkSignIn.LinkColor = Color.FromArgb(79, 122, 148);
            linkSignIn.Location = new Point(12, 42);
            linkSignIn.Name = "linkSignIn";
            linkSignIn.Size = new Size(776, 25);
            linkSignIn.TabIndex = 5;
            linkSignIn.TabStop = true;
            linkSignIn.Text = "¿No tenés una cuenta? Registrate aquí.";
            linkSignIn.TextAlign = ContentAlignment.MiddleCenter;
            linkSignIn.VisitedLinkColor = Color.FromArgb(59, 161, 227);
            linkSignIn.LinkClicked += linkSignIn_LinkClicked;
            // 
            // linkPasswordForgotten
            // 
            linkPasswordForgotten.ActiveLinkColor = Color.FromArgb(59, 161, 227);
            linkPasswordForgotten.Font = new Font("Lexend", 12F);
            linkPasswordForgotten.LinkColor = Color.FromArgb(79, 122, 148);
            linkPasswordForgotten.Location = new Point(12, 9);
            linkPasswordForgotten.Name = "linkPasswordForgotten";
            linkPasswordForgotten.Size = new Size(776, 25);
            linkPasswordForgotten.TabIndex = 4;
            linkPasswordForgotten.TabStop = true;
            linkPasswordForgotten.Text = "¿Olvidaste tu contraseña?";
            linkPasswordForgotten.TextAlign = ContentAlignment.MiddleCenter;
            linkPasswordForgotten.VisitedLinkColor = Color.FromArgb(59, 161, 227);
            linkPasswordForgotten.LinkClicked += linkPasswordForgotten_LinkClicked;
            // 
            // txtFile
            // 
            txtFile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFile.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtFile.BackColor = Color.FromArgb(232, 237, 242);
            txtFile.DropDownStyle = ComboBoxStyle.Simple;
            txtFile.Font = new Font("Lexend", 12F);
            txtFile.ForeColor = Color.FromArgb(79, 122, 148);
            txtFile.FormattingEnabled = true;
            txtFile.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtFile.Location = new Point(181, 189);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(448, 33);
            txtFile.TabIndex = 0;
            txtFile.Text = "Introduce tu legajo";
            // 
            // txtPassword
            // 
            txtPassword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPassword.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtPassword.BackColor = Color.FromArgb(232, 237, 242);
            txtPassword.DropDownStyle = ComboBoxStyle.Simple;
            txtPassword.Font = new Font("Lexend", 12F);
            txtPassword.ForeColor = Color.FromArgb(79, 122, 148);
            txtPassword.FormattingEnabled = true;
            txtPassword.Items.AddRange(new object[] { "Estudiante", "Profesor", "Administrador" });
            txtPassword.Location = new Point(181, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(448, 33);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Introduce tu contraseña";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(800, 555);
            Controls.Add(txtPassword);
            Controls.Add(txtFile);
            Controls.Add(panel2);
            Controls.Add(btnLogIn);
            Controls.Add(cbKeepLoggedIn);
            Controls.Add(label3);
            Controls.Add(lblFile);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label2;
        private Panel panel1;
        private Label lblFile;
        private Label label3;
        private CheckBox cbKeepLoggedIn;
        private Button btnLogIn;
        private Panel panel2;
        private LinkLabel linkPasswordForgotten;
        private LinkLabel linkSignIn;
        private ComboBox txtFile;
        private ComboBox txtPassword;
    }
}
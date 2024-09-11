namespace LogIn
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            checkBoxMantenerSesion = new CheckBox();
            btnIngresar = new Button();
            linkOlvidaPassword = new LinkLabel();
            lblContraseña = new Label();
            lblEmail = new Label();
            lblDescripcionBienvenida = new Label();
            lblBienvenida = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // checkBoxMantenerSesion
            // 
            checkBoxMantenerSesion.AutoSize = true;
            checkBoxMantenerSesion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMantenerSesion.ForeColor = Color.FromArgb(13, 23, 28);
            checkBoxMantenerSesion.Location = new Point(196, 329);
            checkBoxMantenerSesion.Name = "checkBoxMantenerSesion";
            checkBoxMantenerSesion.Size = new Size(180, 20);
            checkBoxMantenerSesion.TabIndex = 2;
            checkBoxMantenerSesion.Text = "Manten mi sesión iniciada";
            checkBoxMantenerSesion.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(59, 161, 227);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14F);
            btnIngresar.ForeColor = Color.FromArgb(13, 23, 28);
            btnIngresar.Location = new Point(196, 377);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(420, 39);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // linkOlvidaPassword
            // 
            linkOlvidaPassword.AutoSize = true;
            linkOlvidaPassword.DisabledLinkColor = Color.DimGray;
            linkOlvidaPassword.Font = new Font("Microsoft Sans Serif", 12F);
            linkOlvidaPassword.ForeColor = Color.FromArgb(79, 122, 148);
            linkOlvidaPassword.LinkColor = Color.DimGray;
            linkOlvidaPassword.Location = new Point(321, 428);
            linkOlvidaPassword.Name = "linkOlvidaPassword";
            linkOlvidaPassword.Size = new Size(170, 20);
            linkOlvidaPassword.TabIndex = 4;
            linkOlvidaPassword.TabStop = true;
            linkOlvidaPassword.Text = "¿Olvidó su contaseña?";
            linkOlvidaPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Microsoft Sans Serif", 12F);
            lblContraseña.ForeColor = Color.FromArgb(13, 23, 28);
            lblContraseña.Location = new Point(196, 265);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(92, 20);
            lblContraseña.TabIndex = 23;
            lblContraseña.Text = "Contraseña";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(13, 23, 28);
            lblEmail.Location = new Point(196, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 20);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // lblDescripcionBienvenida
            // 
            lblDescripcionBienvenida.AutoSize = true;
            lblDescripcionBienvenida.Font = new Font("Microsoft Sans Serif", 12F);
            lblDescripcionBienvenida.ForeColor = Color.FromArgb(79, 122, 148);
            lblDescripcionBienvenida.Location = new Point(183, 112);
            lblDescripcionBienvenida.Name = "lblDescripcionBienvenida";
            lblDescripcionBienvenida.Size = new Size(461, 40);
            lblDescripcionBienvenida.TabIndex = 21;
            lblDescripcionBienvenida.Text = "Controla la asistencia, realiza un seguimiento de la participación \r\ny gestiona tus clases con facilidad.";
            lblDescripcionBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(13, 23, 28);
            lblBienvenida.Location = new Point(196, 48);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(435, 51);
            lblBienvenida.TabIndex = 20;
            lblBienvenida.Text = "Bienvenido a la UTN";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(232, 237, 242);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(79, 122, 148);
            txtUsuario.Location = new Point(196, 223);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(420, 19);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "Introduce tu email";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(232, 237, 242);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = Color.FromArgb(79, 122, 148);
            txtPassword.Location = new Point(196, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Introduce tu contraseña";
            txtPassword.Size = new Size(420, 19);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Introduce tu contraseña";
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(800, 502);
            Controls.Add(checkBoxMantenerSesion);
            Controls.Add(btnIngresar);
            Controls.Add(linkOlvidaPassword);
            Controls.Add(lblContraseña);
            Controls.Add(lblEmail);
            Controls.Add(lblDescripcionBienvenida);
            Controls.Add(lblBienvenida);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogIn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            WindowState = FormWindowState.Maximized;
            Load += frmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxMantenerSesion;
        private Button btnIngresar;
        private LinkLabel linkOlvidaPassword;
        private Label lblContraseña;
        private Label lblEmail;
        private Label lblDescripcionBienvenida;
        private Label lblBienvenida;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}

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
            lblPassword = new Label();
            lblLegajo = new Label();
            lblDescripcionBienvenida = new Label();
            lblBienvenida = new Label();
            txtLegajo = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // checkBoxMantenerSesion
            // 
            checkBoxMantenerSesion.Anchor = AnchorStyles.None;
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
            btnIngresar.Anchor = AnchorStyles.None;
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
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // linkOlvidaPassword
            // 
            linkOlvidaPassword.Anchor = AnchorStyles.None;
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
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblPassword.ForeColor = Color.FromArgb(13, 23, 28);
            lblPassword.Location = new Point(196, 265);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 20);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Contraseña";
            // 
            // lblLegajo
            // 
            lblLegajo.Anchor = AnchorStyles.None;
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLegajo.ForeColor = Color.FromArgb(13, 23, 28);
            lblLegajo.Location = new Point(196, 200);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(57, 20);
            lblLegajo.TabIndex = 22;
            lblLegajo.Text = "Legajo";
            lblLegajo.Click += lblLegajo_Click;
            // 
            // lblDescripcionBienvenida
            // 
            lblDescripcionBienvenida.Anchor = AnchorStyles.None;
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
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(13, 23, 28);
            lblBienvenida.Location = new Point(196, 48);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(435, 51);
            lblBienvenida.TabIndex = 20;
            lblBienvenida.Text = "Bienvenido a la UTN";
            // 
            // txtLegajo
            // 
            txtLegajo.Anchor = AnchorStyles.None;
            txtLegajo.BackColor = Color.FromArgb(232, 237, 242);
            txtLegajo.BorderStyle = BorderStyle.None;
            txtLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLegajo.ForeColor = Color.FromArgb(79, 122, 148);
            txtLegajo.Location = new Point(196, 223);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(420, 19);
            txtLegajo.TabIndex = 0;
            txtLegajo.Text = "Introduce tu legajo";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(232, 237, 242);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10F);
            txtPassword.ForeColor = Color.FromArgb(79, 122, 148);
            txtPassword.Location = new Point(196, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Introduce tu contraseña";
            txtPassword.Size = new Size(420, 16);
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
            Controls.Add(lblPassword);
            Controls.Add(lblLegajo);
            Controls.Add(lblDescripcionBienvenida);
            Controls.Add(lblBienvenida);
            Controls.Add(txtLegajo);
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
        private Label lblPassword;
        private Label lblLegajo;
        private Label lblDescripcionBienvenida;
        private Label lblBienvenida;
        private TextBox txtLegajo;
        private TextBox txtPassword;
    }
}

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
            txtPassword = new TextBox();
            txtLegajo = new TextBox();
            lblBienvenida = new Label();
            lblDescripcionBienvenida = new Label();
            lblLegajo = new Label();
            lblPassword = new Label();
            linkOlvidaPassword = new LinkLabel();
            btnIngresar = new Button();
            chkRememberMe = new CheckBox();
            pnlLogIn = new Panel();
            pnlLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(232, 237, 242);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = Color.FromArgb(79, 122, 148);
            txtPassword.Location = new Point(199, 258);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Introduce tu contraseña";
            txtPassword.Size = new Size(420, 28);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Introduce tu contraseña";
            // 
            // txtLegajo
            // 
            txtLegajo.BackColor = Color.FromArgb(232, 237, 242);
            txtLegajo.BorderStyle = BorderStyle.None;
            txtLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLegajo.ForeColor = Color.FromArgb(79, 122, 148);
            txtLegajo.Location = new Point(199, 193);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(420, 28);
            txtLegajo.TabIndex = 0;
            txtLegajo.Text = "Introduce tu legajo";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(13, 23, 28);
            lblBienvenida.Location = new Point(84, 26);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(642, 74);
            lblBienvenida.TabIndex = 20;
            lblBienvenida.Text = "Bienvenido a la UTN";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // lblDescripcionBienvenida
            // 
            lblDescripcionBienvenida.AutoSize = true;
            lblDescripcionBienvenida.Font = new Font("Microsoft Sans Serif", 12F);
            lblDescripcionBienvenida.ForeColor = Color.FromArgb(79, 122, 148);
            lblDescripcionBienvenida.Location = new Point(54, 103);
            lblDescripcionBienvenida.Name = "lblDescripcionBienvenida";
            lblDescripcionBienvenida.Size = new Size(703, 58);
            lblDescripcionBienvenida.TabIndex = 21;
            lblDescripcionBienvenida.Text = "Controla la asistencia, realiza un seguimiento de la participación \r\ny gestiona tus clases con facilidad.";
            lblDescripcionBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLegajo.ForeColor = Color.FromArgb(13, 23, 28);
            lblLegajo.Location = new Point(199, 161);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(87, 29);
            lblLegajo.TabIndex = 22;
            lblLegajo.Text = "Legajo";
            lblLegajo.Click += lblLegajo_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblPassword.ForeColor = Color.FromArgb(13, 23, 28);
            lblPassword.Location = new Point(199, 226);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(136, 29);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Contraseña";
            // 
            // linkOlvidaPassword
            // 
            linkOlvidaPassword.AutoSize = true;
            linkOlvidaPassword.DisabledLinkColor = Color.DimGray;
            linkOlvidaPassword.Font = new Font("Microsoft Sans Serif", 12F);
            linkOlvidaPassword.ForeColor = Color.FromArgb(79, 122, 148);
            linkOlvidaPassword.LinkColor = Color.DimGray;
            linkOlvidaPassword.Location = new Point(278, 369);
            linkOlvidaPassword.Name = "linkOlvidaPassword";
            linkOlvidaPassword.Size = new Size(254, 29);
            linkOlvidaPassword.TabIndex = 4;
            linkOlvidaPassword.TabStop = true;
            linkOlvidaPassword.Text = "¿Olvidó su contaseña?";
            linkOlvidaPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(59, 161, 227);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14F);
            btnIngresar.ForeColor = Color.FromArgb(13, 23, 28);
            btnIngresar.Location = new Point(199, 327);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(420, 39);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.FromArgb(13, 23, 28);
            chkRememberMe.Location = new Point(199, 292);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(262, 29);
            chkRememberMe.TabIndex = 2;
            chkRememberMe.Text = "Manten mi sesión iniciada";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // pnlLogIn
            // 
            pnlLogIn.Controls.Add(lblBienvenida);
            pnlLogIn.Controls.Add(linkOlvidaPassword);
            pnlLogIn.Controls.Add(btnIngresar);
            pnlLogIn.Controls.Add(chkRememberMe);
            pnlLogIn.Controls.Add(lblDescripcionBienvenida);
            pnlLogIn.Controls.Add(lblLegajo);
            pnlLogIn.Controls.Add(txtLegajo);
            pnlLogIn.Controls.Add(txtPassword);
            pnlLogIn.Controls.Add(lblPassword);
            pnlLogIn.Location = new Point(56, 27);
            pnlLogIn.Name = "pnlLogIn";
            pnlLogIn.Size = new Size(818, 420);
            pnlLogIn.TabIndex = 25;
            pnlLogIn.Paint += panel2_Paint;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(1058, 502);
            Controls.Add(pnlLogIn);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogIn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            WindowState = FormWindowState.Maximized;
            Load += frmLogIn_Load;
            pnlLogIn.ResumeLayout(false);
            pnlLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtLegajo;
        private Label lblBienvenida;
        private Label lblDescripcionBienvenida;
        private Label lblLegajo;
        private Label lblPassword;
        private LinkLabel linkOlvidaPassword;
        private Button btnIngresar;
        private CheckBox chkRememberMe;
        private Panel pnlLogIn;
    }
}

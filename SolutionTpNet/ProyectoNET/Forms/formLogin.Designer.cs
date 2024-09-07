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
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label4 = new Label();
            linkOlvidaPass = new LinkLabel();
            btnIngresar = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(232, 237, 242);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.FromArgb(79, 122, 148);
            txtPass.Location = new Point(117, 274);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Introduce tu contraseña";
            txtPass.Size = new Size(547, 24);
            txtPass.TabIndex = 0;
            txtPass.Text = "Introduce tu contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(232, 237, 242);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(79, 122, 148);
            txtUsuario.Location = new Point(117, 194);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(547, 22);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Introduce tu email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 23, 28);
            label1.Location = new Point(186, 33);
            label1.Name = "label1";
            label1.Size = new Size(435, 51);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la UTN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(79, 122, 148);
            label2.Location = new Point(117, 101);
            label2.Name = "label2";
            label2.Size = new Size(547, 48);
            label2.TabIndex = 3;
            label2.Text = "Controla la asistencia, realiza un seguimiento de la participación \r\ny gestiona tus clases con facilidad.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(13, 23, 28);
            lblEmail.Location = new Point(117, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(13, 23, 28);
            label4.Location = new Point(117, 246);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // linkOlvidaPass
            // 
            linkOlvidaPass.AutoSize = true;
            linkOlvidaPass.DisabledLinkColor = Color.DimGray;
            linkOlvidaPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkOlvidaPass.LinkColor = Color.DimGray;
            linkOlvidaPass.Location = new Point(324, 424);
            linkOlvidaPass.Name = "linkOlvidaPass";
            linkOlvidaPass.Size = new Size(143, 16);
            linkOlvidaPass.TabIndex = 6;
            linkOlvidaPass.TabStop = true;
            linkOlvidaPass.Text = "¿Olvidó su contaseña?";
            linkOlvidaPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.MenuHighlight;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(164, 382);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(457, 39);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(164, 340);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 20);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Manten mi sesión iniciada";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(800, 502);
            Controls.Add(checkBox1);
            Controls.Add(btnIngresar);
            Controls.Add(linkOlvidaPass);
            Controls.Add(label4);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogIn";
            ShowIcon = false;
            Text = "Log In";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label lblEmail;
        private Label label4;
        private LinkLabel linkOlvidaPass;
        private Button btnIngresar;
        private CheckBox checkBox1;
    }
}

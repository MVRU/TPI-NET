namespace LogIn
{
    partial class formLogin
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
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkOlvidaPass = new LinkLabel();
            btnIngresar = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ScrollBar;
            txtPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(223, 363);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(651, 62);
            txtPass.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ScrollBar;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(223, 230);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(651, 62);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(347, 40);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la UTN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(574, 46);
            label2.TabIndex = 3;
            label2.Text = "Controla la asistencia, realiza un seguimiento de la participación \r\ny gestiona tus clases con facilidad";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // linkOlvidaPass
            // 
            linkOlvidaPass.AutoSize = true;
            linkOlvidaPass.DisabledLinkColor = Color.DimGray;
            linkOlvidaPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkOlvidaPass.LinkColor = Color.DimGray;
            linkOlvidaPass.Location = new Point(451, 613);
            linkOlvidaPass.Margin = new Padding(4, 0, 4, 0);
            linkOlvidaPass.Name = "linkOlvidaPass";
            linkOlvidaPass.Size = new Size(213, 25);
            linkOlvidaPass.TabIndex = 6;
            linkOlvidaPass.TabStop = true;
            linkOlvidaPass.Text = "¿Olvidó su contaseña?";
            linkOlvidaPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.MenuHighlight;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(223, 543);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(653, 65);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(223, 473);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(262, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Manten mi sesión iniciada";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1143, 750);
            Controls.Add(checkBox1);
            Controls.Add(btnIngresar);
            Controls.Add(linkOlvidaPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formLogin";
            Text = "LogIn";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkOlvidaPass;
        private Button btnIngresar;
        private CheckBox checkBox1;
    }
}

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
            txtPass.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(156, 218);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(457, 39);
            txtPass.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ScrollBar;
            txtUsuario.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(156, 138);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(457, 39);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 46);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a la UTN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 74);
            label2.Name = "label2";
            label2.Size = new Size(383, 32);
            label2.TabIndex = 3;
            label2.Text = "Controla la asistencia, realiza un seguimiento de la participación \r\ny gestiona tus clases con facilidad";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(156, 120);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 200);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // linkOlvidaPass
            // 
            linkOlvidaPass.AutoSize = true;
            linkOlvidaPass.DisabledLinkColor = Color.DimGray;
            linkOlvidaPass.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkOlvidaPass.LinkColor = Color.DimGray;
            linkOlvidaPass.Location = new Point(307, 377);
            linkOlvidaPass.Name = "linkOlvidaPass";
            linkOlvidaPass.Size = new Size(151, 15);
            linkOlvidaPass.TabIndex = 6;
            linkOlvidaPass.TabStop = true;
            linkOlvidaPass.Text = "¿Olvidó su contaseña?";
            linkOlvidaPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.MenuHighlight;
            btnIngresar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(156, 326);
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
            checkBox1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(156, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(193, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Manten mi sesión iniciada";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(btnIngresar);
            Controls.Add(linkOlvidaPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPass);
            Name = "formLogin";
            Text = "LogIn";
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

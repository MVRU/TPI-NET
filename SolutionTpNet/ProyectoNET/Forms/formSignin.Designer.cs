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
            textBox1 = new TextBox();
            lblNombre = new Label();
            lblConfiguraTuCuenta = new Label();
            btnRegistrarse = new Button();
            lblApellido = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            lblRepetirContraseña = new Label();
            textBox6 = new TextBox();
            lblRequisitosContraseña = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(232, 237, 242);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(79, 122, 148);
            textBox1.Location = new Point(158, 110);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 19);
            textBox1.TabIndex = 0;
            textBox1.Text = "Introduce tu nombre";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombre.Location = new Point(158, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblConfiguraTuCuenta
            // 
            lblConfiguraTuCuenta.AutoSize = true;
            lblConfiguraTuCuenta.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfiguraTuCuenta.ForeColor = Color.FromArgb(13, 23, 28);
            lblConfiguraTuCuenta.Location = new Point(210, 26);
            lblConfiguraTuCuenta.Name = "lblConfiguraTuCuenta";
            lblConfiguraTuCuenta.Size = new Size(270, 31);
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
            btnRegistrarse.Location = new Point(158, 461);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(393, 30);
            btnRegistrarse.TabIndex = 13;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += button1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.FromArgb(13, 23, 28);
            lblApellido.Location = new Point(158, 142);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(232, 237, 242);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(79, 122, 148);
            textBox3.Location = new Point(158, 167);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(393, 19);
            textBox3.TabIndex = 14;
            textBox3.Text = "Introduce tu apellido";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 23, 28);
            label1.Location = new Point(158, 200);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 17;
            label1.Text = "Email institucional";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(232, 237, 242);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(79, 122, 148);
            textBox2.Location = new Point(158, 225);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 19);
            textBox2.TabIndex = 16;
            textBox2.Text = "Introduce tu email institucional";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(13, 23, 28);
            label2.Location = new Point(158, 261);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 19;
            label2.Text = "Universidad";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(232, 237, 242);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.FromArgb(79, 122, 148);
            textBox4.Location = new Point(158, 286);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 19);
            textBox4.TabIndex = 18;
            textBox4.Text = "Introduce tu universidad";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(13, 23, 28);
            label3.Location = new Point(158, 322);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 21;
            label3.Text = "Contraseña";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(232, 237, 242);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.FromArgb(79, 122, 148);
            textBox5.Location = new Point(158, 366);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(393, 19);
            textBox5.TabIndex = 20;
            textBox5.Text = "Introduce tu contraseña";
            // 
            // lblRepetirContraseña
            // 
            lblRepetirContraseña.AutoSize = true;
            lblRepetirContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepetirContraseña.ForeColor = Color.FromArgb(13, 23, 28);
            lblRepetirContraseña.Location = new Point(159, 399);
            lblRepetirContraseña.Name = "lblRepetirContraseña";
            lblRepetirContraseña.Size = new Size(178, 20);
            lblRepetirContraseña.TabIndex = 23;
            lblRepetirContraseña.Text = "Repite tu contraseña";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(232, 237, 242);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.FromArgb(79, 122, 148);
            textBox6.Location = new Point(159, 424);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(393, 19);
            textBox6.TabIndex = 22;
            textBox6.Text = "Introduce tu contraseña";
            // 
            // lblRequisitosContraseña
            // 
            lblRequisitosContraseña.AutoSize = true;
            lblRequisitosContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequisitosContraseña.ForeColor = Color.FromArgb(79, 122, 148);
            lblRequisitosContraseña.Location = new Point(158, 342);
            lblRequisitosContraseña.Name = "lblRequisitosContraseña";
            lblRequisitosContraseña.Size = new Size(367, 15);
            lblRequisitosContraseña.TabIndex = 24;
            lblRequisitosContraseña.Text = "Usa más de 8 caracteres, combinando letras, números y símbolos";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(686, 512);
            Controls.Add(lblRequisitosContraseña);
            Controls.Add(lblRepetirContraseña);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(lblApellido);
            Controls.Add(textBox3);
            Controls.Add(btnRegistrarse);
            Controls.Add(lblConfiguraTuCuenta);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSignIn";
            ShowIcon = false;
            Text = "Sign In";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblNombre;
        private Label lblConfiguraTuCuenta;
        private Button btnRegistrarse;
        private Label lblApellido;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label lblRepetirContraseña;
        private TextBox textBox6;
        private Label lblRequisitosContraseña;
    }
}

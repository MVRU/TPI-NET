namespace ProyectoNET.Forms
{
    partial class formAccount
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
            label1 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtId = new TextBox();
            txtDir = new TextBox();
            txtPwd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblPwd = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnOk = new Button();
            btnEditProfile = new Button();
            lblPwdConfirm = new Label();
            txtPwdConfirm = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(430, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(323, 31);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(430, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(323, 31);
            txtLastName.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(430, 145);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(323, 31);
            txtId.TabIndex = 3;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(430, 202);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(323, 31);
            txtDir.TabIndex = 4;
            // 
            // txtPwd
            // 
            txtPwd.Enabled = false;
            txtPwd.Location = new Point(430, 262);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(323, 31);
            txtPwd.TabIndex = 5;
            txtPwd.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 98);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 148);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Enabled = false;
            lblPwd.Location = new Point(323, 265);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(101, 25);
            lblPwd.TabIndex = 8;
            lblPwd.Text = "Contraseña";
            lblPwd.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 205);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 9;
            label5.Text = "Direccion";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            btnOk.Enabled = false;
            btnOk.Location = new Point(641, 389);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 12;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(430, 389);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(112, 34);
            btnEditProfile.TabIndex = 13;
            btnEditProfile.Text = "Editar perfil";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // lblPwdConfirm
            // 
            lblPwdConfirm.AutoSize = true;
            lblPwdConfirm.Enabled = false;
            lblPwdConfirm.Location = new Point(263, 327);
            lblPwdConfirm.Name = "lblPwdConfirm";
            lblPwdConfirm.Size = new Size(161, 25);
            lblPwdConfirm.TabIndex = 14;
            lblPwdConfirm.Text = "Repetir Contraseña";
            lblPwdConfirm.Visible = false;
            // 
            // txtPwdConfirm
            // 
            txtPwdConfirm.Enabled = false;
            txtPwdConfirm.Location = new Point(430, 324);
            txtPwdConfirm.Name = "txtPwdConfirm";
            txtPwdConfirm.Size = new Size(323, 31);
            txtPwdConfirm.TabIndex = 15;
            txtPwdConfirm.Visible = false;
            // 
            // formAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPwdConfirm);
            Controls.Add(lblPwdConfirm);
            Controls.Add(btnEditProfile);
            Controls.Add(btnOk);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lblPwd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPwd);
            Controls.Add(txtDir);
            Controls.Add(txtId);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "formAccount";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtId;
        private TextBox txtDir;
        private TextBox txtPwd;
        private Label label2;
        private Label label3;
        private Label lblPwd;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnOk;
        private Button btnEditProfile;
        private Label lblPwdConfirm;
        private TextBox txtPwdConfirm;
    }
}
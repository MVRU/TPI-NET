namespace ProyectoNET.Views
{
    partial class ChangePasswordForm
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
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnCambiarContraseña = new Button();
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            label3 = new Label();
            lblConfirmPassword = new Label();
            SuspendLayout();
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(169, 41);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '●';
            txtCurrentPassword.Size = new Size(156, 23);
            txtCurrentPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(169, 87);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(156, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(169, 130);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(156, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Location = new Point(87, 188);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(151, 23);
            btnCambiarContraseña.TabIndex = 3;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(42, 44);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(102, 15);
            lblCurrentPassword.TabIndex = 4;
            lblCurrentPassword.Text = "Contraseña actual";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(42, 90);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(102, 15);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "Contraseña nueva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(867, 345);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirmar contraseña";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(22, 133);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(122, 15);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirmar contraseña";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(372, 253);
            Controls.Add(lblConfirmPassword);
            Controls.Add(label3);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Name = "ChangePasswordForm";
            ShowIcon = false;
            Text = "Cambiar contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnCambiarContraseña;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label label3;
        private Label lblConfirmPassword;
    }
}
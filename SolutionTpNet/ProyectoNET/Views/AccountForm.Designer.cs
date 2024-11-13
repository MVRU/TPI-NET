namespace ProyectoNET
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            lblName = new Label();
            lblLastName = new Label();
            lblFile = new Label();
            lblRole = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtFile = new TextBox();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(88, 45);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(88, 70);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(51, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Apellido";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(88, 95);
            lblFile.Margin = new Padding(2, 0, 2, 0);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(42, 15);
            lblFile.TabIndex = 2;
            lblFile.Text = "Legajo";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(88, 122);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(24, 15);
            lblRole.TabIndex = 3;
            lblRole.Text = "Rol";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(172, 41);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 23);
            txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(172, 67);
            txtLastName.Margin = new Padding(2, 2, 2, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(106, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtFile
            // 
            txtFile.Enabled = false;
            txtFile.Location = new Point(172, 91);
            txtFile.Margin = new Padding(2, 2, 2, 2);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(106, 23);
            txtFile.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(172, 118);
            txtRole.Margin = new Padding(2, 2, 2, 2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(106, 23);
            txtRole.TabIndex = 7;
            // 
            // formCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(txtRole);
            Controls.Add(txtFile);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(lblFile);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "formCuenta";
            Text = "Cuenta";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lblFile;
        private Label lblRole;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtFile;
        private TextBox txtRole;
    }
}
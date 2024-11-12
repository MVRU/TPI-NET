namespace ProyectoNET
{
    partial class formCuenta
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
            lblName.Location = new Point(125, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(125, 117);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(78, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Apellido";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(125, 158);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(64, 25);
            lblFile.TabIndex = 2;
            lblFile.Text = "Legajo";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(125, 203);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 25);
            lblRole.TabIndex = 3;
            lblRole.Text = "Rol";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(245, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(245, 111);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 5;
            // 
            // txtFile
            // 
            txtFile.Enabled = false;
            txtFile.Location = new Point(245, 152);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(150, 31);
            txtFile.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(245, 197);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(150, 31);
            txtRole.TabIndex = 7;
            // 
            // formCuenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRole);
            Controls.Add(txtFile);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(lblFile);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
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
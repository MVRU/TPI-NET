namespace ProyectoNET.Views
{
    partial class EditUserForm
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
            txtFile = new TextBox();
            lblFile = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblRole = new Label();
            btnGuardar = new Button();
            lblPosition = new Label();
            txtPosition = new TextBox();
            cboRole = new ComboBox();
            SuspendLayout();
            // 
            // txtFile
            // 
            txtFile.Location = new Point(144, 42);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(154, 23);
            txtFile.TabIndex = 0;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(70, 45);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(42, 15);
            lblFile.TabIndex = 1;
            lblFile.Text = "Legajo";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(61, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(61, 154);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(51, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Apellido";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(144, 154);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(154, 23);
            txtLastName.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(55, 266);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(144, 263);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(154, 23);
            txtAddress.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(70, 323);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(24, 15);
            lblRole.TabIndex = 11;
            lblRole.Text = "Rol";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(144, 444);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(60, 381);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(52, 15);
            lblPosition.TabIndex = 14;
            lblPosition.Text = "Posición";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(144, 373);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(154, 23);
            txtPosition.TabIndex = 13;
            // 
            // cboRole
            // 
            cboRole.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(144, 323);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(154, 23);
            cboRole.TabIndex = 15;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(373, 479);
            Controls.Add(cboRole);
            Controls.Add(lblPosition);
            Controls.Add(txtPosition);
            Controls.Add(btnGuardar);
            Controls.Add(lblRole);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblFile);
            Controls.Add(txtFile);
            Name = "EditUserForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar usuario";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFile;
        private Label lblFile;
        private Label lblName;
        private TextBox txtName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblRole;
        private Button btnGuardar;
        private Label lblPosition;
        private TextBox txtPosition;
        private ComboBox cboRole;
    }
}
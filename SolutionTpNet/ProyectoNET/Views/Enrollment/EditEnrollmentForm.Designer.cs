namespace ProyectoNET.Views
{
    partial class EditEnrollmentForm
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
            btnSave = new Button();
            cmbCourses = new ComboBox();
            txtStudentFile = new TextBox();
            cmbStatus = new ComboBox();
            dtpEnrollmentDate = new DateTimePicker();
            lblStudentFile = new Label();
            lblStatus = new Label();
            lblEnrollmentDate = new Label();
            lblCourse = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(170, 164);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(174, 23);
            cmbCourses.TabIndex = 1;
            // 
            // txtStudentFile
            // 
            txtStudentFile.Location = new Point(170, 23);
            txtStudentFile.Name = "txtStudentFile";
            txtStudentFile.Size = new Size(174, 23);
            txtStudentFile.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(170, 70);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(174, 23);
            cmbStatus.TabIndex = 3;
            // 
            // dtpEnrollmentDate
            // 
            dtpEnrollmentDate.Location = new Point(170, 114);
            dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            dtpEnrollmentDate.Size = new Size(174, 23);
            dtpEnrollmentDate.TabIndex = 4;
            // 
            // lblStudentFile
            // 
            lblStudentFile.AutoSize = true;
            lblStudentFile.Location = new Point(27, 26);
            lblStudentFile.Name = "lblStudentFile";
            lblStudentFile.Size = new Size(116, 15);
            lblStudentFile.TabIndex = 5;
            lblStudentFile.Text = "Legajo de estudiante";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(27, 73);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Estado";
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Location = new Point(27, 120);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(115, 15);
            lblEnrollmentDate.TabIndex = 7;
            lblEnrollmentDate.Text = "Fecha de inscripción";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(27, 167);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(38, 15);
            lblCourse.TabIndex = 8;
            lblCourse.Text = "Curso";
            // 
            // EditEnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(421, 264);
            Controls.Add(lblCourse);
            Controls.Add(lblEnrollmentDate);
            Controls.Add(lblStatus);
            Controls.Add(lblStudentFile);
            Controls.Add(dtpEnrollmentDate);
            Controls.Add(cmbStatus);
            Controls.Add(txtStudentFile);
            Controls.Add(cmbCourses);
            Controls.Add(btnSave);
            Name = "EditEnrollmentForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nueva matrícula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cmbCourses;
        private TextBox txtStudentFile;
        private ComboBox cmbStatus;
        private DateTimePicker dtpEnrollmentDate;
        private Label lblStudentFile;
        private Label lblStatus;
        private Label lblEnrollmentDate;
        private Label lblCourse;
    }
}
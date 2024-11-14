namespace ProyectoNET.Views
{
    partial class EnrollmentManagementForm
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
            dgvEnrollments = new DataGridView();
            btnEditEnrollment = new Button();
            btnCreateEnrollment = new Button();
            btnDeleteEnrollment = new Button();
            cmbCourses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).BeginInit();
            SuspendLayout();
            // 
            // dgvEnrollments
            // 
            dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollments.Location = new Point(24, 25);
            dgvEnrollments.Name = "dgvEnrollments";
            dgvEnrollments.Size = new Size(557, 235);
            dgvEnrollments.TabIndex = 0;
            // 
            // btnEditEnrollment
            // 
            btnEditEnrollment.Location = new Point(126, 281);
            btnEditEnrollment.Name = "btnEditEnrollment";
            btnEditEnrollment.Size = new Size(75, 23);
            btnEditEnrollment.TabIndex = 1;
            btnEditEnrollment.Text = "Editar";
            btnEditEnrollment.UseVisualStyleBackColor = true;
            btnEditEnrollment.Click += btnEditEnrollment_Click;
            // 
            // btnCreateEnrollment
            // 
            btnCreateEnrollment.Location = new Point(24, 281);
            btnCreateEnrollment.Name = "btnCreateEnrollment";
            btnCreateEnrollment.Size = new Size(75, 23);
            btnCreateEnrollment.TabIndex = 2;
            btnCreateEnrollment.Text = "Agregar";
            btnCreateEnrollment.UseVisualStyleBackColor = true;
            btnCreateEnrollment.Click += btnCreateEnrollment_Click;
            // 
            // btnDeleteEnrollment
            // 
            btnDeleteEnrollment.Location = new Point(224, 281);
            btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            btnDeleteEnrollment.Size = new Size(75, 23);
            btnDeleteEnrollment.TabIndex = 3;
            btnDeleteEnrollment.Text = "Eliminar";
            btnDeleteEnrollment.UseVisualStyleBackColor = true;
            btnDeleteEnrollment.Click += btnDeleteEnrollment_Click;
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(337, 282);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(244, 23);
            cmbCourses.TabIndex = 4;
            // 
            // EnrollmentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(683, 371);
            Controls.Add(cmbCourses);
            Controls.Add(btnDeleteEnrollment);
            Controls.Add(btnCreateEnrollment);
            Controls.Add(btnEditEnrollment);
            Controls.Add(dgvEnrollments);
            Name = "EnrollmentManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de matrículas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEnrollments;
        private Button btnEditEnrollment;
        private Button btnCreateEnrollment;
        private Button btnDeleteEnrollment;
        private ComboBox cmbCourses;
    }
}
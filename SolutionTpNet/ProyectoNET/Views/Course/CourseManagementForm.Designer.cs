﻿namespace ProyectoNET.Views
{
    partial class CourseManagementForm
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
            dataGridViewCourses = new DataGridView();
            btnAddCourse = new Button();
            btnEditCourse = new Button();
            btnDeleteCourse = new Button();
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(33, 36);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.Size = new Size(908, 259);
            dataGridViewCourses.TabIndex = 0;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(33, 323);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(75, 23);
            btnAddCourse.TabIndex = 1;
            btnAddCourse.Text = "Agregar";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnEditCourse
            // 
            btnEditCourse.Location = new Point(135, 323);
            btnEditCourse.Name = "btnEditCourse";
            btnEditCourse.Size = new Size(75, 23);
            btnEditCourse.TabIndex = 2;
            btnEditCourse.Text = "Editar";
            btnEditCourse.UseVisualStyleBackColor = true;
            btnEditCourse.Click += btnEditCourse_Click;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(235, 323);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(75, 23);
            btnDeleteCourse.TabIndex = 3;
            btnDeleteCourse.Text = "Eliminar";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(340, 323);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 4;
            btnReport.Text = "Reporte";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // CourseManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(953, 450);
            Controls.Add(btnReport);
            Controls.Add(btnDeleteCourse);
            Controls.Add(btnEditCourse);
            Controls.Add(btnAddCourse);
            Controls.Add(dataGridViewCourses);
            Name = "CourseManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de cursos";
            WindowState = FormWindowState.Maximized;
            Load += CourseManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCourses;
        private Button btnAddCourse;
        private Button btnEditCourse;
        private Button btnDeleteCourse;
        private Button btnReport;
    }
}
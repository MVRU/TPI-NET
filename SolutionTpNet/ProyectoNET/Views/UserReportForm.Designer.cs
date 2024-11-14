namespace ProyectoNET.Views
{
    partial class UserReportForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblTotalApprovedCourses = new Label();
            lblTotalEnrollments = new Label();
            lblTotalAttendances = new Label();
            tabPage2 = new TabPage();
            tvCourses = new TreeView();
            lblUserName = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(26, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(599, 206);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTotalApprovedCourses);
            tabPage1.Controls.Add(lblTotalEnrollments);
            tabPage1.Controls.Add(lblTotalAttendances);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(591, 178);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "General";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalApprovedCourses
            // 
            lblTotalApprovedCourses.AutoSize = true;
            lblTotalApprovedCourses.Location = new Point(29, 78);
            lblTotalApprovedCourses.Name = "lblTotalApprovedCourses";
            lblTotalApprovedCourses.Size = new Size(144, 15);
            lblTotalApprovedCourses.TabIndex = 2;
            lblTotalApprovedCourses.Text = "Total de cursos aprobados";
            // 
            // lblTotalEnrollments
            // 
            lblTotalEnrollments.AutoSize = true;
            lblTotalEnrollments.Location = new Point(32, 53);
            lblTotalEnrollments.Name = "lblTotalEnrollments";
            lblTotalEnrollments.Size = new Size(132, 15);
            lblTotalEnrollments.TabIndex = 1;
            lblTotalEnrollments.Text = "Total de cursos inscritos";
            // 
            // lblTotalAttendances
            // 
            lblTotalAttendances.AutoSize = true;
            lblTotalAttendances.Location = new Point(32, 22);
            lblTotalAttendances.Name = "lblTotalAttendances";
            lblTotalAttendances.Size = new Size(107, 15);
            lblTotalAttendances.TabIndex = 0;
            lblTotalAttendances.Text = "Total de asistencias";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tvCourses);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(591, 178);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cursos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tvCourses
            // 
            tvCourses.Location = new Point(19, 19);
            tvCourses.Name = "tvCourses";
            tvCourses.Size = new Size(417, 142);
            tvCourses.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(119, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Usuario seleccionado";
            // 
            // UserReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(682, 285);
            Controls.Add(lblUserName);
            Controls.Add(tabControl1);
            Name = "UserReportForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de usuario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblUserName;
        private Label lblTotalApprovedCourses;
        private Label lblTotalEnrollments;
        private Label lblTotalAttendances;
        private TreeView tvCourses;
    }
}
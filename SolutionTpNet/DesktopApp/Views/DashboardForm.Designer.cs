namespace DesktopApp
{
    partial class DashboardForm
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
            lblWelcome = new Label();
            lblUpcomingCourses = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblRecentAttendances = new Label();
            lblAttendanceProblems = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Lexend", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(13, 23, 28);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(870, 64);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Bienvenido de vuelta";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUpcomingCourses
            // 
            lblUpcomingCourses.AutoSize = true;
            lblUpcomingCourses.Font = new Font("Lexend", 14F, FontStyle.Bold);
            lblUpcomingCourses.ForeColor = Color.FromArgb(13, 23, 28);
            lblUpcomingCourses.Location = new Point(12, 131);
            lblUpcomingCourses.Name = "lblUpcomingCourses";
            lblUpcomingCourses.Size = new Size(171, 30);
            lblUpcomingCourses.TabIndex = 8;
            lblUpcomingCourses.Text = "Próximos cursos";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 115);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Lexend", 12F);
            label1.ForeColor = Color.FromArgb(79, 122, 148);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(870, 42);
            label1.TabIndex = 10;
            label1.Text = "Aquí tiene un resumen de sus cursos.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecentAttendances
            // 
            lblRecentAttendances.AutoSize = true;
            lblRecentAttendances.Font = new Font("Lexend", 14F, FontStyle.Bold);
            lblRecentAttendances.ForeColor = Color.FromArgb(13, 23, 28);
            lblRecentAttendances.Location = new Point(12, 267);
            lblRecentAttendances.Name = "lblRecentAttendances";
            lblRecentAttendances.Size = new Size(212, 30);
            lblRecentAttendances.TabIndex = 10;
            lblRecentAttendances.Text = "Asistencias recientes";
            // 
            // lblAttendanceProblems
            // 
            lblAttendanceProblems.AutoSize = true;
            lblAttendanceProblems.Font = new Font("Lexend", 14F, FontStyle.Bold);
            lblAttendanceProblems.ForeColor = Color.FromArgb(13, 23, 28);
            lblAttendanceProblems.Location = new Point(12, 411);
            lblAttendanceProblems.Name = "lblAttendanceProblems";
            lblAttendanceProblems.Size = new Size(407, 30);
            lblAttendanceProblems.TabIndex = 11;
            lblAttendanceProblems.Text = "Estudiantes con problemas de asistencia";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(894, 570);
            Controls.Add(lblAttendanceProblems);
            Controls.Add(lblRecentAttendances);
            Controls.Add(panel1);
            Controls.Add(lblUpcomingCourses);
            Font = new Font("Lexend", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblUpcomingCourses;
        private Panel panel1;
        private Label label1;
        private Label lblRecentAttendances;
        private Label lblAttendanceProblems;
    }
}
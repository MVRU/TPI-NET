using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoNET.Views
{
    partial class CourseReportForm
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
            lblCourseName = new Label();
            lblPendientes = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tvEnrollments = new TreeView();
            lblAprobados = new Label();
            lblLibres = new Label();
            lblRegulares = new Label();
            tabPage2 = new TabPage();
            lblTotalAttendances = new Label();
            tabPage6 = new TabPage();
            lblPercentageAvailable = new Label();
            lblPercentageFulfilled = new Label();
            lblTotalEnrollments = new Label();
            lblQuota = new Label();
            lblWorstAttendance = new Label();
            lblBestAttendance = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(24, 23);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(114, 15);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Curso Seleccionado:";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Location = new Point(368, 84);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(61, 15);
            lblPendientes.TabIndex = 1;
            lblPendientes.Text = "Cursando:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(24, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 260);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tvEnrollments);
            tabPage1.Controls.Add(lblAprobados);
            tabPage1.Controls.Add(lblLibres);
            tabPage1.Controls.Add(lblRegulares);
            tabPage1.Controls.Add(lblPendientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(593, 232);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Matrículas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvEnrollments
            // 
            tvEnrollments.Location = new Point(19, 16);
            tvEnrollments.Name = "tvEnrollments";
            tvEnrollments.Size = new Size(313, 160);
            tvEnrollments.TabIndex = 5;
            // 
            // lblAprobados
            // 
            lblAprobados.AutoSize = true;
            lblAprobados.Location = new Point(368, 28);
            lblAprobados.Name = "lblAprobados";
            lblAprobados.Size = new Size(68, 15);
            lblAprobados.TabIndex = 4;
            lblAprobados.Text = "Aprobados:";
            // 
            // lblLibres
            // 
            lblLibres.AutoSize = true;
            lblLibres.Location = new Point(368, 112);
            lblLibres.Name = "lblLibres";
            lblLibres.Size = new Size(41, 15);
            lblLibres.TabIndex = 3;
            lblLibres.Text = "Libres:";
            // 
            // lblRegulares
            // 
            lblRegulares.AutoSize = true;
            lblRegulares.Location = new Point(368, 55);
            lblRegulares.Name = "lblRegulares";
            lblRegulares.Size = new Size(61, 15);
            lblRegulares.TabIndex = 2;
            lblRegulares.Text = "Regulares:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblBestAttendance);
            tabPage2.Controls.Add(lblWorstAttendance);
            tabPage2.Controls.Add(lblTotalAttendances);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(593, 232);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Asistencia";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalAttendances
            // 
            lblTotalAttendances.AutoSize = true;
            lblTotalAttendances.Location = new Point(30, 29);
            lblTotalAttendances.Name = "lblTotalAttendances";
            lblTotalAttendances.Size = new Size(110, 15);
            lblTotalAttendances.TabIndex = 0;
            lblTotalAttendances.Text = "Total de asistencias:";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lblPercentageAvailable);
            tabPage6.Controls.Add(lblPercentageFulfilled);
            tabPage6.Controls.Add(lblTotalEnrollments);
            tabPage6.Controls.Add(lblQuota);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(593, 232);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Cupos";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblPercentageAvailable
            // 
            lblPercentageAvailable.AutoSize = true;
            lblPercentageAvailable.Location = new Point(69, 115);
            lblPercentageAvailable.Name = "lblPercentageAvailable";
            lblPercentageAvailable.Size = new Size(177, 15);
            lblPercentageAvailable.TabIndex = 3;
            lblPercentageAvailable.Text = "Porcentaje de cupos disponibles";
            // 
            // lblPercentageFulfilled
            // 
            lblPercentageFulfilled.AutoSize = true;
            lblPercentageFulfilled.Location = new Point(77, 159);
            lblPercentageFulfilled.Name = "lblPercentageFulfilled";
            lblPercentageFulfilled.Size = new Size(169, 15);
            lblPercentageFulfilled.TabIndex = 2;
            lblPercentageFulfilled.Text = "Porcentaje de cupos ocupados";
            // 
            // lblTotalEnrollments
            // 
            lblTotalEnrollments.AutoSize = true;
            lblTotalEnrollments.Location = new Point(61, 75);
            lblTotalEnrollments.Name = "lblTotalEnrollments";
            lblTotalEnrollments.Size = new Size(156, 15);
            lblTotalEnrollments.TabIndex = 1;
            lblTotalEnrollments.Text = "Cantidad total de matrículas";
            // 
            // lblQuota
            // 
            lblQuota.AutoSize = true;
            lblQuota.Location = new Point(61, 50);
            lblQuota.Name = "lblQuota";
            lblQuota.Size = new Size(41, 15);
            lblQuota.TabIndex = 0;
            lblQuota.Text = "Cupos";
            // 
            // lblWorstAttendance
            // 
            lblWorstAttendance.AutoSize = true;
            lblWorstAttendance.Location = new Point(30, 93);
            lblWorstAttendance.Name = "lblWorstAttendance";
            lblWorstAttendance.Size = new Size(169, 15);
            lblWorstAttendance.TabIndex = 1;
            lblWorstAttendance.Text = "Estudiante con peor asistencia:";
            // 
            // lblBestAttendance
            // 
            lblBestAttendance.AutoSize = true;
            lblBestAttendance.Location = new Point(30, 59);
            lblBestAttendance.Name = "lblBestAttendance";
            lblBestAttendance.Size = new Size(176, 15);
            lblBestAttendance.TabIndex = 2;
            lblBestAttendance.Text = "Estudiante con mejor asistencia:";
            // 
            // CourseReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(666, 348);
            Controls.Add(tabControl1);
            Controls.Add(lblCourseName);
            Name = "CourseReportForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de curso";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseName;
        private Label lblPendientes;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage6;
        private Label lblAprobados;
        private Label lblLibres;
        private Label lblRegulares;
        private TreeView tvEnrollments;
        private Label lblTotalAttendances;
        private Label lblQuota;
        private Label lblTotalEnrollments;
        private Label lblPercentageFulfilled;
        private Label lblPercentageAvailable;
        private Label lblBestAttendance;
        private Label lblWorstAttendance;
    }
}
namespace ProyectoNET.Forms
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
            pnlDashboard = new Panel();
            dgvEstudiantesProblemas = new DataGridView();
            lbl2Dashboard = new Label();
            dgvProximosCursos = new DataGridView();
            lblProximosCursos = new Label();
            lblResumenCursos = new Label();
            lblBienvenida = new Label();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantesProblemas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProximosCursos).BeginInit();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Anchor = AnchorStyles.None;
            pnlDashboard.Controls.Add(dgvEstudiantesProblemas);
            pnlDashboard.Controls.Add(lbl2Dashboard);
            pnlDashboard.Controls.Add(dgvProximosCursos);
            pnlDashboard.Controls.Add(lblProximosCursos);
            pnlDashboard.Controls.Add(lblResumenCursos);
            pnlDashboard.Controls.Add(lblBienvenida);
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(800, 602);
            pnlDashboard.TabIndex = 1;
            // 
            // dgvEstudiantesProblemas
            // 
            dgvEstudiantesProblemas.Anchor = AnchorStyles.None;
            dgvEstudiantesProblemas.BackgroundColor = Color.FromArgb(247, 250, 250);
            dgvEstudiantesProblemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantesProblemas.Location = new Point(70, 400);
            dgvEstudiantesProblemas.Name = "dgvEstudiantesProblemas";
            dgvEstudiantesProblemas.Size = new Size(660, 190);
            dgvEstudiantesProblemas.TabIndex = 7;
            // 
            // lbl2Dashboard
            // 
            lbl2Dashboard.Anchor = AnchorStyles.None;
            lbl2Dashboard.AutoSize = true;
            lbl2Dashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Dashboard.ForeColor = Color.FromArgb(13, 23, 28);
            lbl2Dashboard.Location = new Point(70, 377);
            lbl2Dashboard.Name = "lbl2Dashboard";
            lbl2Dashboard.Size = new Size(338, 20);
            lbl2Dashboard.TabIndex = 6;
            lbl2Dashboard.Text = "Estudiantes con problemas de asistencia";
            lbl2Dashboard.Click += label1_Click;
            // 
            // dgvProximosCursos
            // 
            dgvProximosCursos.Anchor = AnchorStyles.None;
            dgvProximosCursos.BackgroundColor = Color.FromArgb(247, 250, 250);
            dgvProximosCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProximosCursos.Location = new Point(70, 149);
            dgvProximosCursos.Name = "dgvProximosCursos";
            dgvProximosCursos.Size = new Size(660, 212);
            dgvProximosCursos.TabIndex = 5;
            // 
            // lblProximosCursos
            // 
            lblProximosCursos.Anchor = AnchorStyles.None;
            lblProximosCursos.AutoSize = true;
            lblProximosCursos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProximosCursos.ForeColor = Color.FromArgb(13, 23, 28);
            lblProximosCursos.Location = new Point(70, 126);
            lblProximosCursos.Name = "lblProximosCursos";
            lblProximosCursos.Size = new Size(139, 20);
            lblProximosCursos.TabIndex = 4;
            lblProximosCursos.Text = "Próximos cursos";
            // 
            // lblResumenCursos
            // 
            lblResumenCursos.Anchor = AnchorStyles.None;
            lblResumenCursos.AutoSize = true;
            lblResumenCursos.Font = new Font("Microsoft Sans Serif", 12F);
            lblResumenCursos.ForeColor = Color.FromArgb(79, 122, 148);
            lblResumenCursos.Location = new Point(70, 85);
            lblResumenCursos.Name = "lblResumenCursos";
            lblResumenCursos.Size = new Size(274, 20);
            lblResumenCursos.TabIndex = 3;
            lblResumenCursos.Text = "Aquí tiene un resumen de sus cursos.";
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(13, 23, 28);
            lblBienvenida.Location = new Point(70, 42);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(302, 31);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenido de vuelta, ";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(800, 602);
            Controls.Add(pnlDashboard);
            Name = "DashboardForm";
            ShowIcon = false;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmDashboard_Load;
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantesProblemas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProximosCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashboard;
        private Label lblBienvenida;
        private Label lblResumenCursos;
        private Label lblProximosCursos;
        private DataGridView dgvProximosCursos;
        private DataGridView dgvEstudiantesProblemas;
        private Label lbl2Dashboard;
    }
}
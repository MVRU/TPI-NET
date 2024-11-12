namespace ProyectoNET.Forms
{
    partial class frmDashboard
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
            lblEstudiantesProblemas = new Label();
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
            pnlDashboard.Controls.Add(dgvEstudiantesProblemas);
            pnlDashboard.Controls.Add(lblEstudiantesProblemas);
            pnlDashboard.Controls.Add(dgvProximosCursos);
            pnlDashboard.Controls.Add(lblProximosCursos);
            pnlDashboard.Controls.Add(lblResumenCursos);
            pnlDashboard.Controls.Add(lblBienvenida);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Margin = new Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1143, 1003);
            pnlDashboard.TabIndex = 1;
            // 
            // dgvEstudiantesProblemas
            // 
            dgvEstudiantesProblemas.BackgroundColor = Color.FromArgb(247, 250, 250);
            dgvEstudiantesProblemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantesProblemas.Location = new Point(100, 667);
            dgvEstudiantesProblemas.Margin = new Padding(4, 5, 4, 5);
            dgvEstudiantesProblemas.Name = "dgvEstudiantesProblemas";
            dgvEstudiantesProblemas.RowHeadersWidth = 62;
            dgvEstudiantesProblemas.Size = new Size(943, 317);
            dgvEstudiantesProblemas.TabIndex = 7;
            // 
            // lblEstudiantesProblemas
            // 
            lblEstudiantesProblemas.AutoSize = true;
            lblEstudiantesProblemas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiantesProblemas.ForeColor = Color.FromArgb(13, 23, 28);
            lblEstudiantesProblemas.Location = new Point(100, 628);
            lblEstudiantesProblemas.Margin = new Padding(4, 0, 4, 0);
            lblEstudiantesProblemas.Name = "lblEstudiantesProblemas";
            lblEstudiantesProblemas.Size = new Size(490, 29);
            lblEstudiantesProblemas.TabIndex = 6;
            lblEstudiantesProblemas.Text = "Estudiantes con problemas de asistencia";
            lblEstudiantesProblemas.Click += label1_Click;
            // 
            // dgvProximosCursos
            // 
            dgvProximosCursos.BackgroundColor = Color.FromArgb(247, 250, 250);
            dgvProximosCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProximosCursos.Location = new Point(100, 248);
            dgvProximosCursos.Margin = new Padding(4, 5, 4, 5);
            dgvProximosCursos.Name = "dgvProximosCursos";
            dgvProximosCursos.RowHeadersWidth = 62;
            dgvProximosCursos.Size = new Size(943, 353);
            dgvProximosCursos.TabIndex = 5;
            // 
            // lblProximosCursos
            // 
            lblProximosCursos.AutoSize = true;
            lblProximosCursos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProximosCursos.ForeColor = Color.FromArgb(13, 23, 28);
            lblProximosCursos.Location = new Point(100, 210);
            lblProximosCursos.Margin = new Padding(4, 0, 4, 0);
            lblProximosCursos.Name = "lblProximosCursos";
            lblProximosCursos.Size = new Size(206, 29);
            lblProximosCursos.TabIndex = 4;
            lblProximosCursos.Text = "Próximos cursos";
            // 
            // lblResumenCursos
            // 
            lblResumenCursos.AutoSize = true;
            lblResumenCursos.Font = new Font("Microsoft Sans Serif", 12F);
            lblResumenCursos.ForeColor = Color.FromArgb(79, 122, 148);
            lblResumenCursos.Location = new Point(100, 142);
            lblResumenCursos.Margin = new Padding(4, 0, 4, 0);
            lblResumenCursos.Name = "lblResumenCursos";
            lblResumenCursos.Size = new Size(412, 29);
            lblResumenCursos.TabIndex = 3;
            lblResumenCursos.Text = "Aquí tiene un resumen de sus cursos.";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(13, 23, 28);
            lblBienvenida.Location = new Point(100, 70);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(449, 47);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenido de vuelta, ";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(1143, 1003);
            Controls.Add(pnlDashboard);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDashboard";
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
        private Label lblEstudiantesProblemas;
    }
}
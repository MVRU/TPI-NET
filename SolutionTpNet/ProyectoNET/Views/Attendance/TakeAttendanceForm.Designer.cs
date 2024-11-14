namespace tomarAsistencia
{
    partial class TakeAttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAttendanceForm));
            pnlTomarAsistencia = new Panel();
            btnTerminarClase = new Button();
            btnGuardarAsistencia = new Button();
            lblFecha = new Label();
            lblNombreAsignatura = new Label();
            pnlEstudiantes = new Panel();
            dgvEstudiantes = new DataGridView();
            txtBusquedaEstudiantes = new TextBox();
            pnlTomarAsistencia.SuspendLayout();
            pnlEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // pnlTomarAsistencia
            // 
            resources.ApplyResources(pnlTomarAsistencia, "pnlTomarAsistencia");
            pnlTomarAsistencia.Controls.Add(btnTerminarClase);
            pnlTomarAsistencia.Controls.Add(btnGuardarAsistencia);
            pnlTomarAsistencia.Controls.Add(lblFecha);
            pnlTomarAsistencia.Controls.Add(lblNombreAsignatura);
            pnlTomarAsistencia.Controls.Add(pnlEstudiantes);
            pnlTomarAsistencia.Name = "pnlTomarAsistencia";
            pnlTomarAsistencia.Paint += pnlScroll_Paint;
            // 
            // btnTerminarClase
            // 
            btnTerminarClase.BackColor = Color.FromArgb(232, 237, 242);
            btnTerminarClase.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTerminarClase, "btnTerminarClase");
            btnTerminarClase.ForeColor = Color.FromArgb(13, 23, 28);
            btnTerminarClase.Name = "btnTerminarClase";
            btnTerminarClase.UseVisualStyleBackColor = false;
            btnTerminarClase.Click += button2_Click;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.BackColor = Color.FromArgb(59, 161, 227);
            btnGuardarAsistencia.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnGuardarAsistencia, "btnGuardarAsistencia");
            btnGuardarAsistencia.ForeColor = Color.FromArgb(13, 23, 28);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            resources.ApplyResources(lblFecha, "lblFecha");
            lblFecha.ForeColor = Color.FromArgb(13, 23, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblNombreAsignatura
            // 
            resources.ApplyResources(lblNombreAsignatura, "lblNombreAsignatura");
            lblNombreAsignatura.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombreAsignatura.Name = "lblNombreAsignatura";
            // 
            // pnlEstudiantes
            // 
            pnlEstudiantes.Controls.Add(dgvEstudiantes);
            pnlEstudiantes.Controls.Add(txtBusquedaEstudiantes);
            resources.ApplyResources(pnlEstudiantes, "pnlEstudiantes");
            pnlEstudiantes.Name = "pnlEstudiantes";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.BackgroundColor = Color.FromArgb(247, 250, 250);
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvEstudiantes, "dgvEstudiantes");
            dgvEstudiantes.Name = "dgvEstudiantes";
            // 
            // txtBusquedaEstudiantes
            // 
            txtBusquedaEstudiantes.BackColor = Color.FromArgb(232, 237, 242);
            txtBusquedaEstudiantes.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtBusquedaEstudiantes, "txtBusquedaEstudiantes");
            txtBusquedaEstudiantes.ForeColor = Color.FromArgb(79, 122, 148);
            txtBusquedaEstudiantes.Name = "txtBusquedaEstudiantes";
            // 
            // frmTomarAsistencia
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            Controls.Add(pnlTomarAsistencia);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmTomarAsistencia";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            Load += frmTomarAsistencia_Load;
            pnlTomarAsistencia.ResumeLayout(false);
            pnlTomarAsistencia.PerformLayout();
            pnlEstudiantes.ResumeLayout(false);
            pnlEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTomarAsistencia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.Panel pnlEstudiantes;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox txtBusquedaEstudiantes;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.Button btnTerminarClase;
    }
}


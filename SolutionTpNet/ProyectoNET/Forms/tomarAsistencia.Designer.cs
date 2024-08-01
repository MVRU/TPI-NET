namespace tomarAsistencia
{
    partial class frmTomarAsistencia
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
            pnlScroll = new Panel();
            btnTerminarClase = new Button();
            btnGuardarAsistencia = new Button();
            lblFecha = new Label();
            pnlTop = new Panel();
            picPerfil = new PictureBox();
            lblNombreApp = new Label();
            picLogo = new PictureBox();
            lblNombreAsignatura = new Label();
            pnlPresentes = new Panel();
            dgvPresentes = new DataGridView();
            lblPresentes = new Label();
            txtBusquedaPresentes = new TextBox();
            panel2 = new Panel();
            dgvAusentes = new DataGridView();
            lblAusentes = new Label();
            txtBusquedaAusentes = new TextBox();
            pnlScroll.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlPresentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAusentes).BeginInit();
            SuspendLayout();
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.Controls.Add(btnTerminarClase);
            pnlScroll.Controls.Add(btnGuardarAsistencia);
            pnlScroll.Controls.Add(lblFecha);
            pnlScroll.Controls.Add(pnlTop);
            pnlScroll.Controls.Add(lblNombreAsignatura);
            pnlScroll.Controls.Add(pnlPresentes);
            pnlScroll.Controls.Add(panel2);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(0, 0);
            pnlScroll.Margin = new Padding(5, 6, 5, 6);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(1340, 1050);
            pnlScroll.TabIndex = 0;
            // 
            // btnTerminarClase
            // 
            btnTerminarClase.BackColor = Color.FromArgb(232, 237, 242);
            btnTerminarClase.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTerminarClase.ForeColor = Color.FromArgb(13, 23, 28);
            btnTerminarClase.Location = new Point(983, 1288);
            btnTerminarClase.Margin = new Padding(5, 6, 5, 6);
            btnTerminarClase.Name = "btnTerminarClase";
            btnTerminarClase.Size = new Size(245, 69);
            btnTerminarClase.TabIndex = 15;
            btnTerminarClase.Text = "Terminar clase";
            btnTerminarClase.UseVisualStyleBackColor = false;
            btnTerminarClase.Click += button2_Click;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.BackColor = Color.FromArgb(59, 161, 227);
            btnGuardarAsistencia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarAsistencia.ForeColor = Color.FromArgb(13, 23, 28);
            btnGuardarAsistencia.Location = new Point(932, 1208);
            btnGuardarAsistencia.Margin = new Padding(5, 6, 5, 6);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.Size = new Size(297, 69);
            btnGuardarAsistencia.TabIndex = 14;
            btnGuardarAsistencia.Text = "Guardar asistencia";
            btnGuardarAsistencia.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(13, 23, 28);
            lblFecha.Location = new Point(127, 287);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(235, 37);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Jue, 4 Jul 2024";
            // 
            // pnlTop
            // 
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(picPerfil);
            pnlTop.Controls.Add(lblNombreApp);
            pnlTop.Controls.Add(picLogo);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(5, 6, 5, 6);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1339, 114);
            pnlTop.TabIndex = 9;
            // 
            // picPerfil
            // 
            picPerfil.Location = new Point(1242, 4);
            picPerfil.Margin = new Padding(5, 6, 5, 6);
            picPerfil.Name = "picPerfil";
            picPerfil.Size = new Size(90, 104);
            picPerfil.TabIndex = 2;
            picPerfil.TabStop = false;
            // 
            // lblNombreApp
            // 
            lblNombreApp.AutoSize = true;
            lblNombreApp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreApp.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombreApp.Location = new Point(105, 31);
            lblNombreApp.Margin = new Padding(5, 0, 5, 0);
            lblNombreApp.Name = "lblNombreApp";
            lblNombreApp.Size = new Size(156, 37);
            lblNombreApp.TabIndex = 1;
            lblNombreApp.Text = "CheckInU";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(5, 4);
            picLogo.Margin = new Padding(5, 6, 5, 6);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(90, 104);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNombreAsignatura
            // 
            lblNombreAsignatura.AutoSize = true;
            lblNombreAsignatura.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAsignatura.ForeColor = Color.FromArgb(13, 23, 28);
            lblNombreAsignatura.Location = new Point(125, 190);
            lblNombreAsignatura.Margin = new Padding(5, 0, 5, 0);
            lblNombreAsignatura.Name = "lblNombreAsignatura";
            lblNombreAsignatura.Size = new Size(928, 40);
            lblNombreAsignatura.TabIndex = 10;
            lblNombreAsignatura.Text = "NET 3EK01 - Tecnologías de Desarrollo de Software IDE";
            // 
            // pnlPresentes
            // 
            pnlPresentes.Controls.Add(dgvPresentes);
            pnlPresentes.Controls.Add(lblPresentes);
            pnlPresentes.Controls.Add(txtBusquedaPresentes);
            pnlPresentes.Location = new Point(133, 369);
            pnlPresentes.Margin = new Padding(5, 6, 5, 6);
            pnlPresentes.Name = "pnlPresentes";
            pnlPresentes.Size = new Size(1095, 383);
            pnlPresentes.TabIndex = 12;
            // 
            // dgvPresentes
            // 
            dgvPresentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentes.Location = new Point(10, 150);
            dgvPresentes.Margin = new Padding(5, 6, 5, 6);
            dgvPresentes.Name = "dgvPresentes";
            dgvPresentes.RowHeadersWidth = 62;
            dgvPresentes.Size = new Size(1080, 221);
            dgvPresentes.TabIndex = 6;
            // 
            // lblPresentes
            // 
            lblPresentes.AutoSize = true;
            lblPresentes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPresentes.ForeColor = Color.FromArgb(13, 23, 28);
            lblPresentes.Location = new Point(5, 6);
            lblPresentes.Margin = new Padding(5, 0, 5, 0);
            lblPresentes.Name = "lblPresentes";
            lblPresentes.Size = new Size(122, 29);
            lblPresentes.TabIndex = 4;
            lblPresentes.Text = "Presentes";
            // 
            // txtBusquedaPresentes
            // 
            txtBusquedaPresentes.BackColor = Color.FromArgb(232, 237, 242);
            txtBusquedaPresentes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusquedaPresentes.ForeColor = Color.FromArgb(79, 122, 148);
            txtBusquedaPresentes.Location = new Point(10, 69);
            txtBusquedaPresentes.Margin = new Padding(5, 6, 5, 6);
            txtBusquedaPresentes.Name = "txtBusquedaPresentes";
            txtBusquedaPresentes.Size = new Size(1077, 35);
            txtBusquedaPresentes.TabIndex = 5;
            txtBusquedaPresentes.Text = "Buscar estudiantes";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAusentes);
            panel2.Controls.Add(lblAusentes);
            panel2.Controls.Add(txtBusquedaAusentes);
            panel2.Location = new Point(133, 808);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 383);
            panel2.TabIndex = 13;
            // 
            // dgvAusentes
            // 
            dgvAusentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAusentes.Location = new Point(10, 150);
            dgvAusentes.Margin = new Padding(5, 6, 5, 6);
            dgvAusentes.Name = "dgvAusentes";
            dgvAusentes.RowHeadersWidth = 62;
            dgvAusentes.Size = new Size(1080, 221);
            dgvAusentes.TabIndex = 6;
            // 
            // lblAusentes
            // 
            lblAusentes.AutoSize = true;
            lblAusentes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAusentes.ForeColor = Color.FromArgb(13, 23, 28);
            lblAusentes.Location = new Point(5, 6);
            lblAusentes.Margin = new Padding(5, 0, 5, 0);
            lblAusentes.Name = "lblAusentes";
            lblAusentes.Size = new Size(112, 29);
            lblAusentes.TabIndex = 4;
            lblAusentes.Text = "Ausentes";
            // 
            // txtBusquedaAusentes
            // 
            txtBusquedaAusentes.BackColor = Color.FromArgb(232, 237, 242);
            txtBusquedaAusentes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusquedaAusentes.ForeColor = Color.FromArgb(79, 122, 148);
            txtBusquedaAusentes.Location = new Point(10, 69);
            txtBusquedaAusentes.Margin = new Padding(5, 6, 5, 6);
            txtBusquedaAusentes.Name = "txtBusquedaAusentes";
            txtBusquedaAusentes.Size = new Size(1077, 35);
            txtBusquedaAusentes.TabIndex = 5;
            txtBusquedaAusentes.Text = "Buscar estudiantes";
            // 
            // frmTomarAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(1340, 1050);
            Controls.Add(pnlScroll);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmTomarAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tomar Asistencia";
            WindowState = FormWindowState.Maximized;
            Load += frmTomarAsistencia_Load;
            pnlScroll.ResumeLayout(false);
            pnlScroll.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlPresentes.ResumeLayout(false);
            pnlPresentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAusentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.Panel pnlPresentes;
        private System.Windows.Forms.DataGridView dgvPresentes;
        private System.Windows.Forms.Label lblPresentes;
        private System.Windows.Forms.TextBox txtBusquedaPresentes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAusentes;
        private System.Windows.Forms.Label lblAusentes;
        private System.Windows.Forms.TextBox txtBusquedaAusentes;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.Button btnTerminarClase;
    }
}


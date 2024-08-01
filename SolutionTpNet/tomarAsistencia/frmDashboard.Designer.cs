namespace tomarAsistencia
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
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.lblProximosCursos = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.LinkLabel();
            this.lblCursos = new System.Windows.Forms.LinkLabel();
            this.lblReportes = new System.Windows.Forms.LinkLabel();
            this.lblNotificaciones = new System.Windows.Forms.LinkLabel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.dgvProximosCursos = new System.Windows.Forms.DataGridView();
            this.pnlProximosCursos = new System.Windows.Forms.Panel();
            this.pnlAsistenciasRecientes = new System.Windows.Forms.Panel();
            this.lblAsistenciasRecientes = new System.Windows.Forms.Label();
            this.dgvAsistenciasRecientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlScroll.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximosCursos)).BeginInit();
            this.pnlProximosCursos.SuspendLayout();
            this.pnlAsistenciasRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasRecientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlScroll.Controls.Add(this.pnlFooter);
            this.pnlScroll.Controls.Add(this.panel1);
            this.pnlScroll.Controls.Add(this.pnlAsistenciasRecientes);
            this.pnlScroll.Controls.Add(this.pnlProximosCursos);
            this.pnlScroll.Controls.Add(this.lblBienvenida);
            this.pnlScroll.Controls.Add(this.pnlTop);
            this.pnlScroll.Controls.Add(this.lblNombreAsignatura);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 0);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(804, 749);
            this.pnlScroll.TabIndex = 1;
            this.pnlScroll.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScroll_Paint);
            // 
            // lblProximosCursos
            // 
            this.lblProximosCursos.AutoSize = true;
            this.lblProximosCursos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximosCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblProximosCursos.Location = new System.Drawing.Point(3, 2);
            this.lblProximosCursos.Name = "lblProximosCursos";
            this.lblProximosCursos.Size = new System.Drawing.Size(161, 22);
            this.lblProximosCursos.TabIndex = 11;
            this.lblProximosCursos.Text = "Próximos cursos";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblNotificaciones);
            this.pnlTop.Controls.Add(this.lblReportes);
            this.pnlTop.Controls.Add(this.lblCursos);
            this.pnlTop.Controls.Add(this.lblDashboard);
            this.pnlTop.Controls.Add(this.btnBuscar);
            this.pnlTop.Controls.Add(this.btnConfiguración);
            this.pnlTop.Controls.Add(this.btnAyuda);
            this.pnlTop.Controls.Add(this.picPerfil);
            this.pnlTop.Controls.Add(this.lblNombreApp);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(804, 60);
            this.pnlTop.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Location = new System.Drawing.Point(645, 9);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(40, 40);
            this.btnConfiguración.TabIndex = 4;
            this.btnConfiguración.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(693, 9);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // picPerfil
            // 
            this.picPerfil.Location = new System.Drawing.Point(745, 2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(54, 54);
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblNombreApp.Location = new System.Drawing.Point(63, 16);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(111, 24);
            this.lblNombreApp.TabIndex = 1;
            this.lblNombreApp.Text = "CheckInU";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(54, 54);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblNombreAsignatura
            // 
            this.lblNombreAsignatura.AutoSize = true;
            this.lblNombreAsignatura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblNombreAsignatura.Location = new System.Drawing.Point(75, 99);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(395, 32);
            this.lblNombreAsignatura.TabIndex = 10;
            this.lblNombreAsignatura.Text = "Bienvenido de vuelta, Prof. ...";
            // 
            // lblDashboard
            // 
            this.lblDashboard.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblDashboard.Location = new System.Drawing.Point(266, 22);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(78, 15);
            this.lblDashboard.TabIndex = 6;
            this.lblDashboard.TabStop = true;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblCursos
            // 
            this.lblCursos.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblCursos.Location = new System.Drawing.Point(350, 22);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(53, 15);
            this.lblCursos.TabIndex = 6;
            this.lblCursos.TabStop = true;
            this.lblCursos.Text = "Cursos";
            this.lblCursos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblReportes
            // 
            this.lblReportes.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblReportes.Location = new System.Drawing.Point(409, 22);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(66, 15);
            this.lblReportes.TabIndex = 6;
            this.lblReportes.TabStop = true;
            this.lblReportes.Text = "Reportes";
            this.lblReportes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblNotificaciones.Location = new System.Drawing.Point(481, 22);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(101, 15);
            this.lblNotificaciones.TabIndex = 6;
            this.lblNotificaciones.TabStop = true;
            this.lblNotificaciones.Text = "Notificaciones";
            this.lblNotificaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(122)))), ((int)(((byte)(148)))));
            this.lblBienvenida.Location = new System.Drawing.Point(79, 141);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(213, 12);
            this.lblBienvenida.TabIndex = 16;
            this.lblBienvenida.Text = "Aquí tiene un resumen de sus cursos.";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // dgvProximosCursos
            // 
            this.dgvProximosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProximosCursos.Location = new System.Drawing.Point(3, 27);
            this.dgvProximosCursos.Name = "dgvProximosCursos";
            this.dgvProximosCursos.Size = new System.Drawing.Size(633, 158);
            this.dgvProximosCursos.TabIndex = 17;
            // 
            // pnlProximosCursos
            // 
            this.pnlProximosCursos.Controls.Add(this.lblProximosCursos);
            this.pnlProximosCursos.Controls.Add(this.dgvProximosCursos);
            this.pnlProximosCursos.Location = new System.Drawing.Point(81, 169);
            this.pnlProximosCursos.Name = "pnlProximosCursos";
            this.pnlProximosCursos.Size = new System.Drawing.Size(636, 189);
            this.pnlProximosCursos.TabIndex = 18;
            // 
            // pnlAsistenciasRecientes
            // 
            this.pnlAsistenciasRecientes.Controls.Add(this.lblAsistenciasRecientes);
            this.pnlAsistenciasRecientes.Controls.Add(this.dgvAsistenciasRecientes);
            this.pnlAsistenciasRecientes.Location = new System.Drawing.Point(84, 378);
            this.pnlAsistenciasRecientes.Name = "pnlAsistenciasRecientes";
            this.pnlAsistenciasRecientes.Size = new System.Drawing.Size(636, 189);
            this.pnlAsistenciasRecientes.TabIndex = 19;
            // 
            // lblAsistenciasRecientes
            // 
            this.lblAsistenciasRecientes.AutoSize = true;
            this.lblAsistenciasRecientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistenciasRecientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblAsistenciasRecientes.Location = new System.Drawing.Point(3, 2);
            this.lblAsistenciasRecientes.Name = "lblAsistenciasRecientes";
            this.lblAsistenciasRecientes.Size = new System.Drawing.Size(205, 22);
            this.lblAsistenciasRecientes.TabIndex = 11;
            this.lblAsistenciasRecientes.Text = "Asistencias recientes";
            this.lblAsistenciasRecientes.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAsistenciasRecientes
            // 
            this.dgvAsistenciasRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciasRecientes.Location = new System.Drawing.Point(3, 27);
            this.dgvAsistenciasRecientes.Name = "dgvAsistenciasRecientes";
            this.dgvAsistenciasRecientes.Size = new System.Drawing.Size(633, 158);
            this.dgvAsistenciasRecientes.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(84, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 189);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estudiantes con problemas de asistencia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 158);
            this.dataGridView1.TabIndex = 17;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 776);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(804, 68);
            this.pnlFooter.TabIndex = 21;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 749);
            this.Controls.Add(this.pnlScroll);
            this.Name = "frmDashboard";
            this.Text = "Form2";
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximosCursos)).EndInit();
            this.pnlProximosCursos.ResumeLayout(false);
            this.pnlProximosCursos.PerformLayout();
            this.pnlAsistenciasRecientes.ResumeLayout(false);
            this.pnlAsistenciasRecientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciasRecientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label lblProximosCursos;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.LinkLabel lblDashboard;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfiguración;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNombreAsignatura;
        private System.Windows.Forms.LinkLabel lblCursos;
        private System.Windows.Forms.LinkLabel lblNotificaciones;
        private System.Windows.Forms.LinkLabel lblReportes;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel pnlProximosCursos;
        private System.Windows.Forms.DataGridView dgvProximosCursos;
        private System.Windows.Forms.Panel pnlAsistenciasRecientes;
        private System.Windows.Forms.Label lblAsistenciasRecientes;
        private System.Windows.Forms.DataGridView dgvAsistenciasRecientes;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
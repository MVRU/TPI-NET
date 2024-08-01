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
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.btnTerminarClase = new System.Windows.Forms.Button();
            this.btnGuardarAsistencia = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreAsignatura = new System.Windows.Forms.Label();
            this.pnlPresentes = new System.Windows.Forms.Panel();
            this.dgvPresentes = new System.Windows.Forms.DataGridView();
            this.txtBusquedaPresentes = new System.Windows.Forms.TextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnConfiguración = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlScroll.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlPresentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.btnTerminarClase);
            this.pnlScroll.Controls.Add(this.btnGuardarAsistencia);
            this.pnlScroll.Controls.Add(this.lblFecha);
            this.pnlScroll.Controls.Add(this.pnlTop);
            this.pnlScroll.Controls.Add(this.lblNombreAsignatura);
            this.pnlScroll.Controls.Add(this.pnlPresentes);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 0);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(804, 749);
            this.pnlScroll.TabIndex = 0;
            // 
            // btnTerminarClase
            // 
            this.btnTerminarClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.btnTerminarClase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.btnTerminarClase.Location = new System.Drawing.Point(590, 685);
            this.btnTerminarClase.Name = "btnTerminarClase";
            this.btnTerminarClase.Size = new System.Drawing.Size(147, 36);
            this.btnTerminarClase.TabIndex = 15;
            this.btnTerminarClase.Text = "Terminar clase";
            this.btnTerminarClase.UseVisualStyleBackColor = false;
            this.btnTerminarClase.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardarAsistencia
            // 
            this.btnGuardarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(161)))), ((int)(((byte)(227)))));
            this.btnGuardarAsistencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.btnGuardarAsistencia.Location = new System.Drawing.Point(559, 643);
            this.btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            this.btnGuardarAsistencia.Size = new System.Drawing.Size(178, 36);
            this.btnGuardarAsistencia.TabIndex = 14;
            this.btnGuardarAsistencia.Text = "Guardar asistencia";
            this.btnGuardarAsistencia.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblFecha.Location = new System.Drawing.Point(76, 149);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(160, 24);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Jue, 4 Jul 2024";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.lblNombreAsignatura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblNombreAsignatura.Location = new System.Drawing.Point(75, 99);
            this.lblNombreAsignatura.Name = "lblNombreAsignatura";
            this.lblNombreAsignatura.Size = new System.Drawing.Size(662, 28);
            this.lblNombreAsignatura.TabIndex = 10;
            this.lblNombreAsignatura.Text = "NET 3EK01 - Tecnologías de Desarrollo de Software IDE";
            // 
            // pnlPresentes
            // 
            this.pnlPresentes.Controls.Add(this.dgvPresentes);
            this.pnlPresentes.Controls.Add(this.txtBusquedaPresentes);
            this.pnlPresentes.Location = new System.Drawing.Point(80, 192);
            this.pnlPresentes.Name = "pnlPresentes";
            this.pnlPresentes.Size = new System.Drawing.Size(657, 428);
            this.pnlPresentes.TabIndex = 12;
            // 
            // dgvPresentes
            // 
            this.dgvPresentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresentes.Location = new System.Drawing.Point(6, 39);
            this.dgvPresentes.Name = "dgvPresentes";
            this.dgvPresentes.Size = new System.Drawing.Size(648, 386);
            this.dgvPresentes.TabIndex = 6;
            // 
            // txtBusquedaPresentes
            // 
            this.txtBusquedaPresentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtBusquedaPresentes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPresentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(122)))), ((int)(((byte)(148)))));
            this.txtBusquedaPresentes.Location = new System.Drawing.Point(6, 7);
            this.txtBusquedaPresentes.Name = "txtBusquedaPresentes";
            this.txtBusquedaPresentes.Size = new System.Drawing.Size(648, 26);
            this.txtBusquedaPresentes.TabIndex = 5;
            this.txtBusquedaPresentes.Text = "Buscar estudiantes";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(693, 9);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Location = new System.Drawing.Point(645, 9);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Size = new System.Drawing.Size(40, 40);
            this.btnConfiguración.TabIndex = 4;
            this.btnConfiguración.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmTomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(804, 749);
            this.Controls.Add(this.pnlScroll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTomarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomar Asistencia";
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlPresentes.ResumeLayout(false);
            this.pnlPresentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentes)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtBusquedaPresentes;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.Button btnTerminarClase;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfiguración;
    }
}


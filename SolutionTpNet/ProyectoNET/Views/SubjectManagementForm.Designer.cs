namespace ProyectoNET.Views
{
    partial class SubjectManagementForm
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
            dgvSubjects = new DataGridView();
            btnModificarAsignatura = new Button();
            btnEliminarAsignatura = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(45, 44);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(392, 258);
            dgvSubjects.TabIndex = 0;
            // 
            // btnModificarAsignatura
            // 
            btnModificarAsignatura.Location = new Point(71, 340);
            btnModificarAsignatura.Name = "btnModificarAsignatura";
            btnModificarAsignatura.Size = new Size(75, 23);
            btnModificarAsignatura.TabIndex = 1;
            btnModificarAsignatura.Text = "Modificar";
            btnModificarAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAsignatura
            // 
            btnEliminarAsignatura.Location = new Point(223, 340);
            btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            btnEliminarAsignatura.Size = new Size(75, 23);
            btnEliminarAsignatura.TabIndex = 2;
            btnEliminarAsignatura.Text = "Eliminar";
            btnEliminarAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(346, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // SubjectManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminarAsignatura);
            Controls.Add(btnModificarAsignatura);
            Controls.Add(dgvSubjects);
            Name = "SubjectManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de asignaturas";
            WindowState = FormWindowState.Maximized;
            Load += SubjectManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSubjects;
        private Button btnModificarAsignatura;
        private Button btnEliminarAsignatura;
        private Button btnGuardar;
    }
}
namespace ProyectoNET.Views
{
    partial class UsersManagementForm
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
            components = new System.ComponentModel.Container();
            dgvUsuarios = new DataGridView();
            allowNullCourseIdBindingSource = new BindingSource(components);
            btnModificarUsuario = new Button();
            btnEliminarUsuario = new Button();
            allowNullCourseIdBindingSource1 = new BindingSource(components);
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(37, 36);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(717, 291);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // allowNullCourseIdBindingSource
            // 
            allowNullCourseIdBindingSource.DataSource = typeof(Migrations.AllowNullCourseId);
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(37, 352);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(75, 23);
            btnModificarUsuario.TabIndex = 2;
            btnModificarUsuario.Text = "Editar";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(150, 352);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 3;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // allowNullCourseIdBindingSource1
            // 
            allowNullCourseIdBindingSource1.DataSource = typeof(Migrations.AllowNullCourseId);
            // 
            // btnReport
            // 
            btnReport.Location = new Point(267, 352);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 4;
            btnReport.Text = "Reporte";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // UsersManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(841, 509);
            Controls.Add(btnReport);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(dgvUsuarios);
            Name = "UsersManagementForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += frmUsersManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private BindingSource allowNullCourseIdBindingSource;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private BindingSource allowNullCourseIdBindingSource1;
        private Button btnReport;
    }
}
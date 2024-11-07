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
            button2 = new Button();
            button3 = new Button();
            allowNullCourseIdBindingSource1 = new BindingSource(components);
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
            // button2
            // 
            button2.Location = new Point(37, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(127, 352);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // allowNullCourseIdBindingSource1
            // 
            allowNullCourseIdBindingSource1.DataSource = typeof(Migrations.AllowNullCourseId);
            // 
            // UsersManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 509);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvUsuarios);
            Name = "UsersManagementForm";
            Text = "Gestionar Usuarios";
            Load += frmUsersManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allowNullCourseIdBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private BindingSource allowNullCourseIdBindingSource;
        private Button button2;
        private Button button3;
        private BindingSource allowNullCourseIdBindingSource1;
    }
}
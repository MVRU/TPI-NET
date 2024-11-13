namespace ProyectoNET.Views
{
    partial class EditSubjectForm
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
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblRequiredAttendancePercentage = new Label();
            txtRequiredAttendancePercentage = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(243, 45);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(197, 23);
            txtDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(50, 48);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(125, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Nombre de asignatura";
            // 
            // lblRequiredAttendancePercentage
            // 
            lblRequiredAttendancePercentage.AutoSize = true;
            lblRequiredAttendancePercentage.Location = new Point(50, 95);
            lblRequiredAttendancePercentage.Name = "lblRequiredAttendancePercentage";
            lblRequiredAttendancePercentage.Size = new Size(187, 15);
            lblRequiredAttendancePercentage.TabIndex = 3;
            lblRequiredAttendancePercentage.Text = "Porcentaje de asistencia requerido";
            // 
            // txtRequiredAttendancePercentage
            // 
            txtRequiredAttendancePercentage.Location = new Point(243, 92);
            txtRequiredAttendancePercentage.Name = "txtRequiredAttendancePercentage";
            txtRequiredAttendancePercentage.Size = new Size(197, 23);
            txtRequiredAttendancePercentage.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(50, 160);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(162, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CreateSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(503, 214);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblRequiredAttendancePercentage);
            Controls.Add(txtRequiredAttendancePercentage);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Name = "CreateSubjectForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nueva asignatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Label lblDescription;
        private Label lblRequiredAttendancePercentage;
        private TextBox txtRequiredAttendancePercentage;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
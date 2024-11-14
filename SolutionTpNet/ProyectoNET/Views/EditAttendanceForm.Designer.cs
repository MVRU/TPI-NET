namespace ProyectoNET.Views
{
    partial class EditAttendanceForm
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
            dtpAttendanceDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            comboBoxEnrollment = new ComboBox();
            lblDate = new Label();
            lblEnrollment = new Label();
            SuspendLayout();
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(117, 28);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(200, 23);
            dtpAttendanceDate.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 124);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(127, 124);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBoxEnrollment
            // 
            comboBoxEnrollment.FormattingEnabled = true;
            comboBoxEnrollment.Location = new Point(117, 69);
            comboBoxEnrollment.Name = "comboBoxEnrollment";
            comboBoxEnrollment.Size = new Size(200, 23);
            comboBoxEnrollment.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(31, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Fecha";
            // 
            // lblEnrollment
            // 
            lblEnrollment.AutoSize = true;
            lblEnrollment.Location = new Point(31, 72);
            lblEnrollment.Name = "lblEnrollment";
            lblEnrollment.Size = new Size(65, 15);
            lblEnrollment.TabIndex = 5;
            lblEnrollment.Text = "Inscripción";
            // 
            // EditAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(384, 184);
            Controls.Add(lblEnrollment);
            Controls.Add(lblDate);
            Controls.Add(comboBoxEnrollment);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpAttendanceDate);
            Name = "EditAttendanceForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar asistencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpAttendanceDate;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox comboBoxEnrollment;
        private Label lblDate;
        private Label lblEnrollment;
    }
}
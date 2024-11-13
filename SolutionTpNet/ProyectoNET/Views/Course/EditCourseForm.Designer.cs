namespace ProyectoNET.Views
{
    partial class EditCourseForm
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
            txtYear = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtQuota = new TextBox();
            cmbSubject = new ComboBox();
            btnSave = new Button();
            lblYear = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblQuota = new Label();
            lblSubject = new Label();
            tvSchedules = new TreeView();
            SuspendLayout();
            // 
            // txtYear
            // 
            txtYear.AcceptsReturn = true;
            txtYear.Location = new Point(185, 38);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(185, 84);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(185, 133);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // txtQuota
            // 
            txtQuota.AcceptsReturn = true;
            txtQuota.Location = new Point(185, 184);
            txtQuota.Name = "txtQuota";
            txtQuota.Size = new Size(100, 23);
            txtQuota.TabIndex = 3;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(185, 237);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(200, 23);
            cmbSubject.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(45, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(45, 41);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(90, 15);
            lblYear.TabIndex = 6;
            lblYear.Text = "Año de cursado";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(45, 90);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(86, 15);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "Fecha de inicio";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(45, 139);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(117, 15);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "Fecha de finalización";
            // 
            // lblQuota
            // 
            lblQuota.AutoSize = true;
            lblQuota.Location = new Point(45, 187);
            lblQuota.Name = "lblQuota";
            lblQuota.Size = new Size(87, 15);
            lblQuota.TabIndex = 10;
            lblQuota.Text = "Cupo del curso";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(45, 240);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(64, 15);
            lblSubject.TabIndex = 11;
            lblSubject.Text = "Asignatura";
            // 
            // tvSchedules
            // 
            tvSchedules.Location = new Point(185, 286);
            tvSchedules.Name = "tvSchedules";
            tvSchedules.Size = new Size(281, 151);
            tvSchedules.TabIndex = 13;
            // 
            // EditCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(731, 482);
            Controls.Add(tvSchedules);
            Controls.Add(lblSubject);
            Controls.Add(lblQuota);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblYear);
            Controls.Add(btnSave);
            Controls.Add(cmbSubject);
            Controls.Add(txtQuota);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtYear);
            Name = "EditCourseForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear un nuevo curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYear;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtQuota;
        private ComboBox cmbSubject;
        private Button btnSave;
        private Label lblYear;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblQuota;
        private Label lblSubject;
        private TreeView tvSchedules;
    }
}
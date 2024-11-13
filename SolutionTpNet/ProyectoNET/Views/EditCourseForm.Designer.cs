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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtYear
            // 
            txtYear.AcceptsReturn = true;
            txtYear.Location = new Point(166, 38);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(299, 174);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(286, 214);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // txtQuota
            // 
            txtQuota.AcceptsReturn = true;
            txtQuota.Location = new Point(308, 282);
            txtQuota.Name = "txtQuota";
            txtQuota.Size = new Size(100, 23);
            txtQuota.TabIndex = 3;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(291, 334);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(525, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "button1";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 218);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 7;
            label1.Text = "Año de cursado";
            // 
            // EditCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblYear);
            Controls.Add(btnSave);
            Controls.Add(cmbSubject);
            Controls.Add(txtQuota);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtYear);
            Name = "EditCourseForm";
            Text = "EditCourseForm";
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
        private Label label1;
    }
}
namespace ProyectoNET.Views
{
    partial class AssignScheduleForm
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
            lblCourseInfo = new Label();
            comboBoxDay = new ComboBox();
            comboBoxSchedule = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblCourseInfo
            // 
            lblCourseInfo.AutoSize = true;
            lblCourseInfo.Location = new Point(26, 26);
            lblCourseInfo.Name = "lblCourseInfo";
            lblCourseInfo.Size = new Size(81, 15);
            lblCourseInfo.TabIndex = 0;
            lblCourseInfo.Text = "Info del Curso";
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new Point(76, 69);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(121, 23);
            comboBoxDay.TabIndex = 1;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            // 
            // comboBoxSchedule
            // 
            comboBoxSchedule.FormattingEnabled = true;
            comboBoxSchedule.Location = new Point(76, 122);
            comboBoxSchedule.Name = "comboBoxSchedule";
            comboBoxSchedule.Size = new Size(121, 23);
            comboBoxSchedule.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(88, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AssignScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 287);
            Controls.Add(btnSave);
            Controls.Add(comboBoxSchedule);
            Controls.Add(comboBoxDay);
            Controls.Add(lblCourseInfo);
            Name = "AssignScheduleForm";
            Text = "AssignScheduleForm";
            Load += AssignScheduleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseInfo;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxSchedule;
        private Button btnSave;
    }
}
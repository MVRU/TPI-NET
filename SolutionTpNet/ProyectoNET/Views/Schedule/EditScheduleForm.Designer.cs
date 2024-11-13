namespace ProyectoNET.Views
{
    partial class EditScheduleForm
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
            btnGuardar = new Button();
            lblDay = new Label();
            lblStartTime = new Label();
            lblEndTime = new Label();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            cmbDay = new ComboBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(115, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(34, 31);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(96, 15);
            lblDay.TabIndex = 4;
            lblDay.Text = "Día de la semana";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(34, 79);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(104, 15);
            lblStartTime.TabIndex = 5;
            lblStartTime.Text = "Hora de comienzo";
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(34, 130);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(66, 15);
            lblEndTime.TabIndex = 6;
            lblEndTime.Text = "Hora de fin";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(151, 73);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(135, 23);
            dtpStartTime.TabIndex = 7;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(151, 124);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(135, 23);
            dtpEndTime.TabIndex = 8;
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cmbDay.Location = new Point(151, 28);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(135, 23);
            cmbDay.TabIndex = 9;
            // 
            // EditScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 250);
            Controls.Add(cmbDay);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(lblEndTime);
            Controls.Add(lblStartTime);
            Controls.Add(lblDay);
            Controls.Add(btnGuardar);
            Name = "EditScheduleForm";
            Text = "Agregar nuevo horario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblDay;
        private Label lblStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private ComboBox cmbDay;
    }
}
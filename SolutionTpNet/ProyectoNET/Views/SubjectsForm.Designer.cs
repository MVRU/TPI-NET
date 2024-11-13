namespace ProyectoNET.Views
{
    partial class SubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            subject_dataGrid = new DataGridView();
            label1 = new Label();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)subject_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // subject_dataGrid
            // 
            subject_dataGrid.Anchor = AnchorStyles.None;
            subject_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subject_dataGrid.Location = new Point(29, 65);
            subject_dataGrid.Name = "subject_dataGrid";
            subject_dataGrid.Size = new Size(739, 373);
            subject_dataGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Todas las materias";
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.None;
            add_btn.Location = new Point(200, 39);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 2;
            add_btn.Text = "Registrar";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Anchor = AnchorStyles.None;
            update_btn.Location = new Point(281, 39);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 23);
            update_btn.TabIndex = 3;
            update_btn.Text = "Modificar";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.None;
            delete_btn.BackColor = Color.IndianRed;
            delete_btn.Location = new Point(693, 39);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 4;
            delete_btn.Text = "Eliminar";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(label1);
            Controls.Add(subject_dataGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SubjectsForm";
            Text = "SubjectsForm";
            Load += SubjectsForm_Load;
            ((System.ComponentModel.ISupportInitialize)subject_dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView subject_dataGrid;
        private Label label1;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
    }
}
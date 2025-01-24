namespace DesktopApp
{
    partial class HelpForm
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
            panel1 = new Panel();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 66);
            panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Lexend", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(13, 23, 28);
            lblWelcome.Location = new Point(3, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(960, 64);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "Ayuda";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(966, 515);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(13, 23, 28);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HelpForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayuda";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
    }
}
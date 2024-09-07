namespace ProyectoNET
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            msnMainMenu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            crearCuentaToolStripMenuItem = new ToolStripMenuItem();
            asistenciaCuentaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            msnMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msnMainMenu
            // 
            msnMainMenu.AutoSize = false;
            msnMainMenu.ImageScalingSize = new Size(24, 24);
            msnMainMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            msnMainMenu.Location = new Point(0, 0);
            msnMainMenu.Name = "msnMainMenu";
            msnMainMenu.Padding = new Padding(4, 1, 0, 1);
            msnMainMenu.Size = new Size(797, 24);
            msnMainMenu.Stretch = false;
            msnMainMenu.TabIndex = 1;
            msnMainMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, crearCuentaToolStripMenuItem, asistenciaCuentaToolStripMenuItem, salirToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(51, 22);
            menuToolStripMenuItem.Text = "Menú";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(144, 22);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += mnuLogIn_Click;
            // 
            // crearCuentaToolStripMenuItem
            // 
            crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            crearCuentaToolStripMenuItem.Size = new Size(144, 22);
            crearCuentaToolStripMenuItem.Text = "Crear cuenta";
            crearCuentaToolStripMenuItem.Click += mnuSignIn_Click;
            // 
            // asistenciaCuentaToolStripMenuItem
            // 
            asistenciaCuentaToolStripMenuItem.Name = "asistenciaCuentaToolStripMenuItem";
            asistenciaCuentaToolStripMenuItem.Size = new Size(144, 22);
            asistenciaCuentaToolStripMenuItem.Text = "Asistencia";
            asistenciaCuentaToolStripMenuItem.Click += mnuAsistencia_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(144, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += mnuSalir_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(797, 403);
            Controls.Add(msnMainMenu);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = msnMainMenu;
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "CheckInU";
            WindowState = FormWindowState.Maximized;
            Load += formMain_Load;
            msnMainMenu.ResumeLayout(false);
            msnMainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip msnMainMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem crearCuentaToolStripMenuItem;
        private ToolStripMenuItem asistenciaCuentaToolStripMenuItem;
    }
}
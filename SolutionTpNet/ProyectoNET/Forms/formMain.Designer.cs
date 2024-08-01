namespace ProyectoNET
{
    partial class formMain
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
            msnMainMenu = new MenuStrip();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            mnuAsistencia = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            crearCuentaToolStripMenuItem = new ToolStripMenuItem();
            mnuQuit = new ToolStripMenuItem();
            msnMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msnMainMenu
            // 
            msnMainMenu.ImageScalingSize = new Size(24, 24);
            msnMainMenu.Items.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem });
            msnMainMenu.Location = new Point(0, 0);
            msnMainMenu.Name = "msnMainMenu";
            msnMainMenu.Size = new Size(800, 33);
            msnMainMenu.TabIndex = 1;
            msnMainMenu.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAsistencia, ingresarToolStripMenuItem, crearCuentaToolStripMenuItem, mnuQuit });
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(83, 29);
            cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // mnuAsistencia
            // 
            mnuAsistencia.Name = "mnuAsistencia";
            mnuAsistencia.Size = new Size(270, 34);
            mnuAsistencia.Text = "Asistencia";
            mnuAsistencia.Click += mnuAsistencia_Click;
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(270, 34);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += mnuLogIn_Click;
            // 
            // crearCuentaToolStripMenuItem
            // 
            crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            crearCuentaToolStripMenuItem.Size = new Size(270, 34);
            crearCuentaToolStripMenuItem.Text = "Crear cuenta";
            crearCuentaToolStripMenuItem.Click += mnuSignIn_Click;
            // 
            // mnuQuit
            // 
            mnuQuit.Name = "mnuQuit";
            mnuQuit.Size = new Size(270, 34);
            mnuQuit.Text = "Salir";
            mnuQuit.Click += mnuSalir_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msnMainMenu);
            IsMdiContainer = true;
            MainMenuStrip = msnMainMenu;
            Name = "formMain";
            Text = "Sysacad";
            WindowState = FormWindowState.Maximized;
            msnMainMenu.ResumeLayout(false);
            msnMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msnMainMenu;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem mnuQuit;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem crearCuentaToolStripMenuItem;
        private ToolStripMenuItem mnuAsistencia;
    }
}
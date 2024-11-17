namespace DesktopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesiónToolStripMenuItem = new ToolStripMenuItem();
            registrarseToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            gestionarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            gestionarCursosToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            verAyudaToolStripMenuItem = new ToolStripMenuItem();
            sobreCheckInUToolStripMenuItem = new ToolStripMenuItem();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Font = new Font("Lexend", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, usuariosToolStripMenuItem, cursosToolStripMenuItem, ayudaToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(914, 29);
            MainMenu.TabIndex = 1;
            MainMenu.Text = "MainMenu";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, iniciarSesiónToolStripMenuItem, registrarseToolStripMenuItem, configuraciónToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(70, 25);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
            dashboardToolStripMenuItem.Size = new Size(256, 26);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            iniciarSesiónToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            iniciarSesiónToolStripMenuItem.Size = new Size(256, 26);
            iniciarSesiónToolStripMenuItem.Text = "Iniciar sesión";
            iniciarSesiónToolStripMenuItem.Click += iniciarSesiónToolStripMenuItem_Click;
            // 
            // registrarseToolStripMenuItem
            // 
            registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            registrarseToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            registrarseToolStripMenuItem.Size = new Size(256, 26);
            registrarseToolStripMenuItem.Text = "Registrarse";
            registrarseToolStripMenuItem.Click += registrarseToolStripMenuItem_Click;
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            configuraciónToolStripMenuItem.Size = new Size(256, 26);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            salirToolStripMenuItem.Size = new Size(256, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.U;
            usuariosToolStripMenuItem.Size = new Size(77, 25);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            gestionarUsuariosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.U;
            gestionarUsuariosToolStripMenuItem.Size = new Size(287, 26);
            gestionarUsuariosToolStripMenuItem.Text = "Gestionar usuarios";
            gestionarUsuariosToolStripMenuItem.Click += gestionarUsuariosToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarCursosToolStripMenuItem });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            cursosToolStripMenuItem.Size = new Size(64, 25);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // gestionarCursosToolStripMenuItem
            // 
            gestionarCursosToolStripMenuItem.Name = "gestionarCursosToolStripMenuItem";
            gestionarCursosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            gestionarCursosToolStripMenuItem.Size = new Size(273, 26);
            gestionarCursosToolStripMenuItem.Text = "Gestionar cursos";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verAyudaToolStripMenuItem, sobreCheckInUToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.ShortcutKeys = Keys.F1;
            ayudaToolStripMenuItem.Size = new Size(63, 25);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            verAyudaToolStripMenuItem.ShortcutKeys = Keys.F1;
            verAyudaToolStripMenuItem.Size = new Size(228, 26);
            verAyudaToolStripMenuItem.Text = "Ver ayuda";
            verAyudaToolStripMenuItem.Click += verAyudaToolStripMenuItem_Click;
            // 
            // sobreCheckInUToolStripMenuItem
            // 
            sobreCheckInUToolStripMenuItem.Name = "sobreCheckInUToolStripMenuItem";
            sobreCheckInUToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            sobreCheckInUToolStripMenuItem.Size = new Size(228, 26);
            sobreCheckInUToolStripMenuItem.Text = "Sobre CheckInU";
            sobreCheckInUToolStripMenuItem.Click += sobreCheckInUToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 250);
            ClientSize = new Size(914, 569);
            Controls.Add(MainMenu);
            Font = new Font("Lexend", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(13, 23, 28);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckInU";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MainMenu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private ToolStripMenuItem registrarseToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem sobreCheckInUToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem verAyudaToolStripMenuItem;
        private ToolStripMenuItem gestionarCursosToolStripMenuItem;
    }
}
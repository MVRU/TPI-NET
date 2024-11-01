﻿namespace ProyectoNET
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
            msnMainMenu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesionToolStripMenuItem = new ToolStripMenuItem();
            registrarseToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            tomarAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            historialAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            listaDeCursosToolStripMenuItem = new ToolStripMenuItem();
            crearNuevoCursoToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            preferenciasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            guíaDeAyudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            msnMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msnMainMenu
            // 
            msnMainMenu.AutoSize = false;
            msnMainMenu.ImageScalingSize = new Size(24, 24);
            msnMainMenu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, asistenciaToolStripMenuItem, cursosToolStripMenuItem, configuraciónToolStripMenuItem, ayudaToolStripMenuItem });
            msnMainMenu.Location = new Point(0, 0);
            msnMainMenu.Name = "msnMainMenu";
            msnMainMenu.Padding = new Padding(4, 1, 0, 1);
            msnMainMenu.Size = new Size(797, 24);
            msnMainMenu.Stretch = false;
            msnMainMenu.TabIndex = 1;
            msnMainMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, iniciarSesionToolStripMenuItem, registrarseToolStripMenuItem, cuentaToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(58, 22);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(146, 22);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // iniciarSesionToolStripMenuItem
            // 
            iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            iniciarSesionToolStripMenuItem.Size = new Size(146, 22);
            iniciarSesionToolStripMenuItem.Text = "Iniciar sesión";
            iniciarSesionToolStripMenuItem.Click += mnuLogIn_Click;
            // 
            // registrarseToolStripMenuItem
            // 
            registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            registrarseToolStripMenuItem.Size = new Size(146, 22);
            registrarseToolStripMenuItem.Text = "Registrarse";
            registrarseToolStripMenuItem.Click += mnuSignIn_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(146, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += mnuSalir_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tomarAsistenciaToolStripMenuItem, historialAsistenciaToolStripMenuItem });
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(72, 22);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            asistenciaToolStripMenuItem.Click += menúToolStripMenuItem_Click;
            // 
            // tomarAsistenciaToolStripMenuItem
            // 
            tomarAsistenciaToolStripMenuItem.Name = "tomarAsistenciaToolStripMenuItem";
            tomarAsistenciaToolStripMenuItem.Size = new Size(188, 22);
            tomarAsistenciaToolStripMenuItem.Text = "Tomar asistencia";
            tomarAsistenciaToolStripMenuItem.Click += asistenciaCuentaToolStripMenuItem_Click;
            // 
            // historialAsistenciaToolStripMenuItem
            // 
            historialAsistenciaToolStripMenuItem.Name = "historialAsistenciaToolStripMenuItem";
            historialAsistenciaToolStripMenuItem.Size = new Size(188, 22);
            historialAsistenciaToolStripMenuItem.Text = "Historial de asistencia";
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCursosToolStripMenuItem, crearNuevoCursoToolStripMenuItem });
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(55, 22);
            cursosToolStripMenuItem.Text = "Cursos";
            // 
            // listaDeCursosToolStripMenuItem
            // 
            listaDeCursosToolStripMenuItem.Name = "listaDeCursosToolStripMenuItem";
            listaDeCursosToolStripMenuItem.Size = new Size(170, 22);
            listaDeCursosToolStripMenuItem.Text = "Lista de cursos";
            // 
            // crearNuevoCursoToolStripMenuItem
            // 
            crearNuevoCursoToolStripMenuItem.Name = "crearNuevoCursoToolStripMenuItem";
            crearNuevoCursoToolStripMenuItem.Size = new Size(170, 22);
            crearNuevoCursoToolStripMenuItem.Text = "Crear nuevo curso";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferenciasToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 22);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // preferenciasToolStripMenuItem
            // 
            preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            preferenciasToolStripMenuItem.Size = new Size(138, 22);
            preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guíaDeAyudaToolStripMenuItem, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // guíaDeAyudaToolStripMenuItem
            // 
            guíaDeAyudaToolStripMenuItem.Name = "guíaDeAyudaToolStripMenuItem";
            guíaDeAyudaToolStripMenuItem.Size = new Size(180, 22);
            guíaDeAyudaToolStripMenuItem.Text = "Guía de usuario";
            guíaDeAyudaToolStripMenuItem.Click += guíaDeAyudaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(146, 22);
            cuentaToolStripMenuItem.Text = "Cuenta";
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
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private ToolStripMenuItem registrarseToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem tomarAsistenciaToolStripMenuItem;
        private ToolStripMenuItem historialAsistenciaToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem listaDeCursosToolStripMenuItem;
        private ToolStripMenuItem crearNuevoCursoToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem preferenciasToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem guíaDeAyudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
    }
}
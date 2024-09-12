using tomarAsistencia;
using LogIn;
using Signin;
using System.Xml.Serialization;

namespace ProyectoNET

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserController oper = new UserController();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}
using System;
using System.Windows.Forms;

using DesignSidebar.Salles.components.smallComponents;
namespace DesignSidebar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();


            form1.BringToFront();
        
            Application.Run(form1);
       

        }
    }
}

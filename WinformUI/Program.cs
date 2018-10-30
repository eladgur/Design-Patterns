using System;
using System.Windows.Forms;

// $G$ THE-001 (-26) your grade on diagrams document - 70 please see comments inside the document. (50% of your grade).

// $G$ RUL-003 (-10) No submission report attached to the solution

namespace WinformUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

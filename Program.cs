using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaEvidencija
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new frm_Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frm_MainForm());
                }
                // Ako nije OK, aplikacija se već zatvara iz login forme
            }
        }
    }
}

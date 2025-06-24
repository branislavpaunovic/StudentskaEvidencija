using System;
using System.Windows.Forms;

namespace StudentskaEvidencija.Controls
{
    public class ExitButton : Button
    {
        public ExitButton()
        {
            this.Text = "Exit";
            this.Click += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form == null) return;

            // Proveri da li je glavna forma
            if (form.Name == "frm_MainForm")
            {
                // Zatvori konekciju sa bazom ako postoji
                CloseDatabaseConnection();

                // Zatvori celu aplikaciju
                Application.Exit();
            }
            else
            {
                form.Close();
            }
        }

        private void CloseDatabaseConnection()
        {
            // Primer: ako imaš statičku konekciju
            // Database.Connection?.Close();

            // Ako koristiš drugačije, ovde pozovi kod za zatvaranje konekcije
        }
    }
}
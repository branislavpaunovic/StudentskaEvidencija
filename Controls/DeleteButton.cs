using System;
using System.Windows.Forms;

namespace StudentskaEvidencija.Controls
{
    public class DeleteButton : Button
    {
        public DeleteButton()
        {
            this.Text = "Delete";
            this.Click += DeleteButton_Click;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form == null) return;

            // Pozovi virtuelnu metodu za brisanje sloga
            OnDeleteRecord(form);
        }

        // Ovo treba override-ovati u formi ili povezati sa eventom
        protected virtual void OnDeleteRecord(Form form)
        {
            // Ova metoda treba biti implementirana u formi
        }
    }
}
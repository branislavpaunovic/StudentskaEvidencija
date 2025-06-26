using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentskaEvidencija.Controls
{
    public class AddNewButton : Button
    {
        public event EventHandler AddNewClicked;

        public AddNewButton()
        {
            this.Text = "Add New";
            this.Click += AddNewButton_Click;
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form == null) return;

            // Enable all input controls
            foreach (Control ctrl in form.Controls)
            {
                EnableInputControls(ctrl);
            }

            // Pozovi virtuelnu metodu za dodavanje sloga
            AddNewClicked?.Invoke(this, EventArgs.Empty);

        }

        private void EnableInputControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                    ctrl.Enabled = true;

                // Rekurzivno za panele, groupbox itd.
                if (ctrl.HasChildren)
                    EnableInputControls(ctrl);
            }
        }

        // Ovo treba override-ovati u formi ili povezati sa eventom
        protected virtual void OnAddNewRecord(Form form)
        {
            // Ova metoda treba biti implementirana u formi
        }
    }
}
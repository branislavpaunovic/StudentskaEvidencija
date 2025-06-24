using System;
using System.Windows.Forms;

namespace StudentskaEvidencija.Controls
{
    public class SaveButton : Button
    {
        public SaveButton()
        {
            this.Text = "Save";
            this.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form == null) return;

            // Pozovi virtuelnu metodu za čuvanje podataka
            OnSaveRecord(form);

            // Disable all input controls
            foreach (Control ctrl in form.Controls)
            {
                DisableInputControls(ctrl);
            }
        }

        private void DisableInputControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                    ctrl.Enabled = false;

                if (ctrl.HasChildren)
                    DisableInputControls(ctrl);
            }
        }

        // Ovo treba override-ovati u formi ili povezati sa eventom
        protected virtual void OnSaveRecord(Form form)
        {
            // Ova metoda treba biti implementirana u formi
        }
    }
}
using System;
using System.Windows.Forms;

namespace StudentskaEvidencija
{
    public class EditButton : Button
    {
        public event EventHandler EditRecordRequested;

        public EditButton()
        {
            this.Text = "Edit";
            this.Click += EditButton_Click;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form == null) return;

            EnableAllInputControls(form);

            // Pozovi event za izmenu sloga
            EditRecordRequested?.Invoke(this, EventArgs.Empty);
        }

        private void EnableAllInputControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is DateTimePicker || ctrl is CheckBox)
                    ctrl.Enabled = true;

                if (ctrl.HasChildren)
                    EnableAllInputControls(ctrl);
            }
        }
    }
}
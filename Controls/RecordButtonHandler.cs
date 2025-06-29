using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaEvidencija.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class RecordButtonHandler
    {
        private readonly Button btnNew;
        private readonly Button btnEdit;
        private readonly Button btnDelete;
        private readonly Button btnSave;
        private readonly List<Control> formFields;
        private bool isEditing = false;

        public RecordButtonHandler(Button newBtn, Button editBtn, Button deleteBtn, Button saveBtn, List<Control> fields)
        {
            btnNew = newBtn;
            btnEdit = editBtn;
            btnDelete = deleteBtn;
            btnSave = saveBtn;
            formFields = fields;

            InitializeButtons();
            //SetShortcuts();
            SetDefaultState();
        }

        private void InitializeButtons()
        {
            Font buttonFont = new Font("Poppins", 12, FontStyle.Bold);

            btnNew.Text = "New";
            btnEdit.Text = "Edit";
            btnDelete.Text = "Delete";
            btnSave.Text = "Save";

            btnNew.Font = buttonFont;
            btnEdit.Font = buttonFont;
            btnDelete.Font = buttonFont;
            btnSave.Font = buttonFont;

            btnNew.Click += (s, e) => EnterEditMode("new");
            btnEdit.Click += (s, e) => EnterEditMode("edit");
            btnSave.Click += (s, e) => SaveOrCancel();
            btnDelete.Click += (s, e) => DeleteRecord();
        }

        //private void SetShortcuts()
        //{
        //    btnNew.ShortcutKeys(Keys.Control | Keys.N);
        //    btnEdit.ShortcutKeys(Keys.Control | Keys.E);
        //    btnDelete.ShortcutKeys(Keys.Control | Keys.D);
        //    btnSave.ShortcutKeys(Keys.Control | Keys.S);
        //}

        private void SetDefaultState()
        {
            SetFieldsEnabled(false);
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnSave.Text = "Save";
            isEditing = false;
        }

        private void SetFieldsEnabled(bool enabled)
        {
            foreach (var field in formFields)
            {
                field.Enabled = enabled;
            }
        }

        private void EnterEditMode(string mode)
        {
            SetFieldsEnabled(true);
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Text = "Cancel";
            isEditing = true;
        }

        private void SaveOrCancel()
        {
            if (!isEditing)
                return;

            if (btnSave.Text == "Cancel")
            {
                SetDefaultState();
                return;
            }

            if (!ValidateFields())
                return;

            // Save logic here

            SetDefaultState();
        }

        private bool ValidateFields()
        {
            foreach (var field in formFields)
            {
                if (field is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Niste uneli sva polja.");
                        txt.Focus();
                        return false;
                    }
                    // Add more detailed validation here as needed
                }
            }
            return true;
        }

        private void DeleteRecord()
        {
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete podatak?", "Potvrda", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Delete logic here
                MessageBox.Show("Podatak obrisan.");
            }
        }
    }

}

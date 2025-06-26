using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StudentskaEvidencija
{
    public partial class frm_Student : Form
    {
        private readonly string _connStr = @"Server=localhost\AUTODESKVAULT;Database=StudentskaEvidencija;Integrated Security=True;";
        private SqlConnection _conn;
        private DataTable _studentsTable;
        private int _currentIndex = 0;

        private bool _isAddingNew = false;

        public frm_Student()
        {
            InitializeComponent();
            SetFieldsEnabled(false);
            this.Load += frm_Student_Load;
            this.FormClosing += frm_Student_FormClosing;
        }

        private void frm_Student_Load(object sender, EventArgs e)

        {
            SetFieldsEnabled(false);

            _conn = new SqlConnection(_connStr);
            _conn.Open();

            string query = @"
SELECT 
    s.Ime, s.Prezime, s.DatumRodjenja, s.BrojIndeksa, s.Telefon, s.Email, s.Ulica, s.BrojKuce, s.PTT, s.Grad, s.Zemlja,
    sm.NazivSmera,
    p.NazivPola,
    s.JeAdministrator
FROM dbo.Student s
LEFT JOIN dbo.Smer sm ON s.SmerId = sm.SmerId
LEFT JOIN dbo.Pol p ON s.PolID = p.PolID
LEFT JOIN dbo.Korisnik k ON s.KorisnikID = k.KorisnikID
ORDER BY s.StudentId ASC";

            using (var adapter = new SqlDataAdapter(query, _conn))
            {
                _studentsTable = new DataTable();
                adapter.Fill(_studentsTable);
            }

            if (_studentsTable.Rows.Count > 0)
            {
                ShowStudent(_currentIndex);
            }
        }

        private void frm_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
                _conn.Close();
        }

        private void SetFieldsEnabled(bool enabled)
        {
            txtIme.Enabled = enabled;
            txtPrezime.Enabled = enabled;
            txtDatumRodjenja.Enabled = enabled;
            txtBrojIndeksa.Enabled = enabled;
            txtTelefon.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtUlica.Enabled = enabled;
            txtBrojKuce.Enabled = enabled;
            txtPtt.Enabled = enabled;
            txtGrad.Enabled = enabled;
            txtZemlja.Enabled = enabled;
            txtSmer.Enabled = enabled;
            txtPol.Enabled = enabled;
            chkAdministrator.Enabled = enabled;
        }

        private void ShowStudent(int index)
        {
            SetFieldsEnabled(false);

            if (_studentsTable == null || _studentsTable.Rows.Count == 0)
                return;

            var row = _studentsTable.Rows[index];
            txtIme.Text = row["Ime"].ToString();
            txtPrezime.Text = row["Prezime"].ToString();
            txtDatumRodjenja.Text = Convert.ToDateTime(row["DatumRodjenja"]).ToShortDateString();
            txtBrojIndeksa.Text = row["BrojIndeksa"].ToString();
            txtTelefon.Text = row["Telefon"].ToString();
            txtEmail.Text = row["Email"].ToString();
            txtUlica.Text = row["Ulica"].ToString();
            txtBrojKuce.Text = row["BrojKuce"].ToString();
            txtPtt.Text = row["PTT"].ToString();
            txtGrad.Text = row["Grad"].ToString();
            txtZemlja.Text = row["Zemlja"].ToString();
            txtSmer.Text = row["NazivSmera"].ToString();
            txtPol.Text = row["NazivPola"].ToString();
            chkAdministrator.Checked = Convert.ToBoolean(row["JeAdministrator"]);
        }

        // Navigacija kroz slogove
        private void btnFirst_Click(object sender, EventArgs e)
        {
            _currentIndex = 0;
            ShowStudent(_currentIndex);
            if (_isAddingNew)
            {
                var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                             "Potvrda", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return; // ne dozvoljava izlazak
                else
                    _isAddingNew = false; // prekidamo "add mode"
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                ShowStudent(_currentIndex);
                if (_isAddingNew)
                {
                    var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                                 "Potvrda", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        return; // ne dozvoljava izlazak
                    else
                        _isAddingNew = false; // prekidamo "add mode"
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_studentsTable != null && _currentIndex < _studentsTable.Rows.Count - 1)
            {
                _currentIndex++;
                ShowStudent(_currentIndex);
                if (_isAddingNew)
                {
                    var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                                 "Potvrda", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        return; // ne dozvoljava izlazak
                    else
                        _isAddingNew = false; // prekidamo "add mode"
                }
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_studentsTable != null)
            {
                _currentIndex = _studentsTable.Rows.Count - 1;
                ShowStudent(_currentIndex);
                if (_isAddingNew)
                {
                    var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                                 "Potvrda", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        return; // ne dozvoljava izlazak
                    else
                        _isAddingNew = false; // prekidamo "add mode"
                }
            }
        }

        private void frm_Student_Load_1(object sender, EventArgs e)
        {

        }

        private void addNewButton1_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            SetFieldsEnabled(true);
            txtIme.Focus();
        }
        private void ClearFields()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtDatumRodjenja.Text = "";
            txtBrojIndeksa.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtUlica.Text = "";
            txtBrojKuce.Text = "";
            txtPtt.Text = "";
            txtGrad.Text = "";
            txtZemlja.Text = "";
            txtSmer.Text = "";
            txtPol.Text = "";
            chkAdministrator.Checked = false;
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                // Kreiraj INSERT upit
                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    string insertQuery = @"INSERT INTO Student (Ime, Prezime, ...) 
                                   VALUES (@Ime, @Prezime, ...)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ime", txtIme.Text);
                        // Dodaj sve ostale parametre...

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Novi student je uspešno dodat.");
                _isAddingNew = false;
                SetFieldsEnabled(false);
                LoadDataAgain(); // metoda koja osvežava DataTable i prikazuje poslednji slog
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                             "Potvrda", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return; // ne dozvoljava izlazak
                else
                    _isAddingNew = false; // prekidamo "add mode"
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                             "Potvrda", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return; // ne dozvoljava izlazak
                else
                    _isAddingNew = false; // prekidamo "add mode"
            }
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                var result = MessageBox.Show("Niste sačuvali novi unos. Da li želite da odustanete?",
                                             "Potvrda", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return; // ne dozvoljava izlazak
                else
                    _isAddingNew = false; // prekidamo "add mode"
            }
        }
        private void LoadDataAgain()
        {
            string query = @"
SELECT 
    s.Ime, s.Prezime, s.DatumRodjenja, s.BrojIndeksa, s.Telefon, s.Email, s.Ulica, s.BrojKuce, s.PTT, s.Grad, s.Zemlja,
    sm.NazivSmera,
    p.NazivPola,
    s.JeAdministrator
FROM dbo.Student s
LEFT JOIN dbo.Smer sm ON s.SmerId = sm.SmerId
LEFT JOIN dbo.Pol p ON s.PolID = p.PolID
LEFT JOIN dbo.Korisnik k ON s.KorisnikID = k.KorisnikID
ORDER BY s.StudentId ASC";

            using (var adapter = new SqlDataAdapter(query, _conn))
            {
                _studentsTable.Clear(); // obriši prethodne podatke
                adapter.Fill(_studentsTable); // učitaj svež set
            }

            _currentIndex = _studentsTable.Rows.Count - 1; // pozicioniraj se na poslednji slog
            ShowStudent(_currentIndex); // prikaži ga u formi
        }


    }
}
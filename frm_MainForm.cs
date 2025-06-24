   // Uvozi standardne .NET biblioteke koje omogućavaju razne funkcionalnosti
using System; // Osnovne stvari (npr. DateTime, Console, Exception...)
using System.Collections.Generic; // Korišćenje generičkih kolekcija (List, Dictionary...)
using System.ComponentModel; // Komponentni model – korisno za rad sa komponentama
using System.Data; // Podrška za rad sa podacima i bazama
using System.Data.SqlClient; // Omogućava rad sa SQL Server bazom podataka kroz .NET klase (kao što su SqlConnection, SqlCommand, SqlDataReader itd.)
using System.Data.SqlTypes; // koristi SE kada želiš da koristiš SQL Server specifične tipove podataka kao što su SqlDateTime, SqlInt32, SqlDecimal itd., umesto običnih C# tipova (DateTime, int, decimal).
using System.Xml; //System.Xml – omogućava rad sa XML dokumentima, XmlReader, XmlWriter, XmlDocument, XPath, itd. Možeš koristiti npr. za eksport podataka iz baze u XML.
using System.Drawing; // Crtanje i rad sa bojama, fontovima, slikama
using System.Linq;  // LINQ – upiti nad kolekcijama
using System.Text; // Rad sa tekstovima i enkodiranjem
using System.Threading.Tasks; // Paralelno programiranje i asinhroni zadaci
using System.Windows.Forms; // Sve vezano za WinForms (forme, kontrole itd.)
using StudentskaEvidencija.Controls; // Uvozi kontrole iz StudentskaEvidencija.Controls namespace-a


// Deklaracija namespace-a (logička grupa u kojoj se nalazi tvoj kod)
namespace StudentskaEvidencija
{
    // Definiše klasu MainForm koja nasleđuje (extends) Windows Formu
    public partial class frm_MainForm : Form
    {
        // Konstruktor – poziva se kad se instanca (objekat) MainForm napravi
        public frm_MainForm()
        {
            InitializeComponent(); // Automatski generisan kod za kreiranje i postavljanje elemenata forme
            this.IsMdiContainer = true; // Postavlja ovu formu kao MDI (Multiple Document Interface) roditelj formu, koja može da sadrži i prikazuje druge forme unutar sebe kao podformulare.
            this.Text = "Studentska Evidencija"; //Postavljanje naziva forme

            this.IsMdiContainer = true;
            this.Text = "Studentska Evidencija";

            this.Size = new System.Drawing.Size(1440, 900); // Fiksna veličina
            this.MinimumSize = new System.Drawing.Size(1440, 900); // Minimalna veličina
            this.MaximumSize = new System.Drawing.Size(1440, 900); // Maksimalna veličina
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Onemogućava promenu veličine

        }


        // Ova metoda se automatski poziva kad se forma učita (Load event)
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void frm_MainForm_Load(object sender, EventArgs e)
        {
            // Pretpostavljamo da je ExitButton tvoja custom klasa
            var exitButton = new ExitButton();

            // Pronađi poslednju ćeliju
            int lastRow = tableLayoutPanel1.RowCount - 1;
            int lastCol = tableLayoutPanel1.ColumnCount - 1;

            // Dodaj dugme u poslednju ćeliju
            tableLayoutPanel1.Controls.Add(exitButton, lastCol, lastRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cmd_Student_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuto je na Student dugme!");
            // Proveri da li je već otvorena forma Student
            foreach (Form child in this.MdiChildren)
            {
                if (child is frm_Student) // zameni sa StudentForm ako je tako nazvana
                {
                    child.WindowState = FormWindowState.Maximized;
                    child.BringToFront();
                    return;
                }
            }

            // Ako nije otvorena, kreiraj novu
            frm_Student studentForm = new frm_Student(); // zameni sa StudentForm ako je tako nazvana
            studentForm.MdiParent = this;
            studentForm.StartPosition = FormStartPosition.Manual;

            // Izračunaj poziciju:
            int x = this.ClientSize.Width - studentForm.Width - 10; // skroz desno
            int y = (this.ClientSize.Height - studentForm.Height) / 2; // po sredini vertikalno

            studentForm.Location = new System.Drawing.Point(x, y);
                studentForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



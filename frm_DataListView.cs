using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskaEvidencija.Models;
using StudentskaEvidencija.DAL;
using System.Configuration;

namespace StudentskaEvidencija
{
    
    public partial class frm_DataListView : Form
    {
        private int currentRowIndex = 0;
        public frm_DataListView()
        {
            InitializeComponent();
        }

        private void frm_DataListView_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["StudentskaEvidencija"].ConnectionString;

            StudentDAL studentDAL = new StudentDAL(connString);
            SmerDAL smerDAL = new SmerDAL(connString);
            PolDAL polDAL = new PolDAL(connString);

            List<Student> studenti = studentDAL.GetAllStudents();
            Dictionary<int, Smer> smerovi = new Dictionary<int, Smer>();
            foreach (var s in smerDAL.GetAllSmerovi())
                if (!smerovi.ContainsKey(s.SmerId))
                    smerovi.Add(s.SmerId, s);

            Dictionary<int, Pol> polovi = new Dictionary<int, Pol>();
            foreach (var p in polDAL.GetAllPolovi())
                if (!polovi.ContainsKey(p.PolID))
                    polovi.Add(p.PolID, p);

            lsvStudent.View = View.Details;
            lsvStudent.FullRowSelect = true;
            lsvStudent.GridLines = true;
            lsvStudent.Columns.Clear();

            lsvStudent.Columns.Add("ID", 50);
            lsvStudent.Columns.Add("Ime", 100);
            lsvStudent.Columns.Add("Prezime", 100);
            lsvStudent.Columns.Add("Datum rođenja", 100);
            lsvStudent.Columns.Add("Broj indeksa", 100);
            lsvStudent.Columns.Add("Telefon", 100);
            lsvStudent.Columns.Add("Email", 150);
            lsvStudent.Columns.Add("Ulica", 100);
            lsvStudent.Columns.Add("Broj kuće", 80);
            lsvStudent.Columns.Add("PTT", 60);
            lsvStudent.Columns.Add("Grad", 100);
            lsvStudent.Columns.Add("Zemlja", 100);
            lsvStudent.Columns.Add("Smer", 120);
            lsvStudent.Columns.Add("Pol", 80);
            lsvStudent.Columns.Add("Administrator", 80);

            lsvStudent.Items.Clear();

            foreach (var s in studenti)
            {
                string nazivSmera = "Nepoznat";
                if (smerovi.ContainsKey(s.SmerId))
                    nazivSmera = smerovi[s.SmerId].NazivSmera;

                string nazivPola = "Nepoznat";

                if (polovi.ContainsKey(s.PolID))
                    nazivPola = polovi[s.PolID].NazivPola;


                ListViewItem item = new ListViewItem(s.StudentId.ToString());
                item.SubItems.Add(s.Ime ?? "");
                item.SubItems.Add(s.Prezime ?? "");
                item.SubItems.Add(s.DatumRodjenja.ToShortDateString());
                item.SubItems.Add(s.BrojIndeksa ?? "");
                item.SubItems.Add(s.Telefon ?? "");
                item.SubItems.Add(s.Email ?? "");
                item.SubItems.Add(s.Ulica ?? "");
                item.SubItems.Add(s.BrojKuce ?? "");
                item.SubItems.Add(s.PTT ?? "");
                item.SubItems.Add(s.Grad ?? "");
                item.SubItems.Add(s.Zemlja ?? "");
                item.SubItems.Add(nazivSmera);
                item.SubItems.Add(nazivPola);

                lsvStudent.Items.Add(item);
            }
                SelectRow(0);
        }
        private void SelectRow(int index)
        {
            if (index >= 0 && index < lsvStudent.Items.Count)
            {
                // Očisti prethodni izbor
                lsvStudent.SelectedItems.Clear();

                // Selektuj novi red
                lsvStudent.Items[index].Selected = true;
                lsvStudent.Items[index].EnsureVisible();

                currentRowIndex = index;
            }
        }
    
        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
                SelectRow(currentRowIndex - 1);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentRowIndex < lsvStudent.Items.Count - 1)
                SelectRow(currentRowIndex + 1);
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            SelectRow(lsvStudent.Items.Count - 1);
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            SelectRow(0);
        }
    }

}

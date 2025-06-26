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
    public partial class frm_DataGreedView : Form
    {
        public frm_DataGreedView()
        {
            InitializeComponent();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {

        }

        private void frm_DataGreedView_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["StudentskaEvidencija"].ConnectionString;

            StudentDAL studentDAL = new StudentDAL(connString);
            SmerDAL smerDAL = new SmerDAL(connString);
            PolDAL polDAL = new PolDAL(connString);

            List<Student> studenti = studentDAL.GetAllStudents();
            var smerovi = smerDAL.GetAllSmerovi().ToDictionary(s => s.SmerId);
            var polovi = polDAL.GetAllPolovi().ToDictionary(p => p.PolID);

            var prikazPodaci = studenti.Select(s => new
            {
                s.StudentId,
                s.Ime,
                s.Prezime,
                s.DatumRodjenja,
                s.BrojIndeksa,
                s.Telefon,
                s.Email,
                s.Ulica,
                s.BrojKuce,
                s.PTT,
                s.Grad,
                s.Zemlja,
                NazivSmera = smerovi.ContainsKey(s.SmerId) ? smerovi[s.SmerId].NazivSmera : "Nepoznat smer",
                NazivPola = polovi.ContainsKey(s.PolID) ? polovi[s.PolID].NazivPola : "Nepoznat pol",
                s.JeAdministrator
            }).ToList();

            dgv_Student.DataSource = prikazPodaci;
        }
    }
}

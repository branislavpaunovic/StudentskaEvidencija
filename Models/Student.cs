using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaEvidencija.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojIndeksa { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Ulica { get; set; }
        public string BrojKuce { get; set; }
        public string PTT { get; set; }
        public string Grad { get; set; }
        public string Zemlja { get; set; }

        public int SmerId { get; set; }
        
        public int PolID { get; set; }
      
    }
}

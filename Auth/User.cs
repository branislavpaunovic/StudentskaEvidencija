using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskaEvidencija.DAL;
using StudentskaEvidencija.Models;
using StudentskaEvidencija.Auth;

namespace StudentskaEvidencija.Auth
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int StudentID { get; set; }
        public UserRole Role { get; set; }

        // Prava
        public bool CanView { get; set; }
        public bool CanPrint { get; set; }
        public bool CanQuery { get; set; }
        public bool CanEdit { get; set; }
        public bool CanManageUsers { get; set; }

        // SUPERADMIN kreira se bez baze
        public static User CreateSuperAdmin()
        {
            return new User
            {
                Id = 0,
                Username = "administrator",
                Ime = "Glavni",
                Prezime = "Administrator",
                StudentID = 0,
                Role = UserRole.SuperAdmin,
                CanView = true,
                CanPrint = true,
                CanQuery = true,
                CanEdit = true,
                CanManageUsers = true
            };
        }

        // ADMIN i USER se dobijaju iz baze (KorisnikDAL)
        public static User FromKorisnik(Korisnik k)
        {
            var role = k.IsAdmin ? UserRole.Admin : UserRole.User;

            return new User
            {
                Id = k.KorisnikId,
                Username = k.Username,
                Ime = k.Ime,
                Prezime = k.Prezime,
                StudentID = k.StudentID,
                Role = role,
                CanView = true,
                CanPrint = true,
                CanQuery = true,
                CanEdit = k.IsAdmin,
                CanManageUsers = false
            };
        }
    }
}
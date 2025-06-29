using System;
using System.Windows.Forms;
using StudentskaEvidencija.DAL;
using StudentskaEvidencija.Models;
using StudentskaEvidencija.Auth;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StudentskaEvidencija.Services
{
    public class LoginService
    {
        private int brojNeuspelihPokusaja = 0;
        private readonly KorisnikDAL _korisnikDAL;
        private int _attemptsUsername = 0;
        private int _attemptsPassword = 0;

        public LoginService(string connString)
        {
            _korisnikDAL = new KorisnikDAL(connString);
        }

        public bool TryLogin(string username, string password)
        {
            // 1. Provera za SuperAdmin (administrator/password)
            if (username == "administrator" && password == "password")
            {
                var superUser = User.CreateSuperAdmin();
                LoginManager.Instance.SetCurrentUser(superUser);
                return true;
            }

            // 2. Provera baze – admin/user preko tabele Korisnik
            var korisnik = _korisnikDAL.Login(username, password);
            if (korisnik != null)
            {
                var user = User.FromKorisnik(korisnik);
                LoginManager.Instance.SetCurrentUser(user);
                return true;
            }

            return false;
        }

        public void HandleInvalidLogin(Form loginForm)
        {
            brojNeuspelihPokusaja++;

            if (brojNeuspelihPokusaja >= 3)
            {
                MessageBox.Show(
                    "Previše neuspelih pokušaja. Program će se zatvoriti.",
                    "Prijava neuspešna",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Pogrešno korisničko ime ili lozinka.\nPreostali pokušaji: {3 - brojNeuspelihPokusaja}\n\nDa li želite da pokušate ponovo?",
                "Prijava neuspešna",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

    }
}

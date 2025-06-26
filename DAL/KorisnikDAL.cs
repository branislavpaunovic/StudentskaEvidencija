using StudentskaEvidencija.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaEvidencija.DAL
{
    public class KorisnikDAL
    {
        private readonly string connectionString;

        public KorisnikDAL(string connString)
        {
            connectionString = connString;
        }

        public List<Korisnik> GetAllKorisnici()
        {
            List<Korisnik> korisnici = new List<Korisnik>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Korisnik";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Korisnik k = new Korisnik
                    {
                        KorisnikId = Convert.ToInt32(reader["KorisnikId"]),
                        Ime = reader["Ime"].ToString(),
                        Prezime = reader["Prezime"].ToString(),
                        Username = reader["Username"].ToString(),
                        Lozinka = reader["Lozinka"].ToString(),
                        IsAdmin = Convert.ToBoolean(reader["IsAdmin"])
                    };

                    korisnici.Add(k);
                }

                reader.Close();
            }

            return korisnici;
        }

        public Korisnik Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Korisnik WHERE Username = @Username AND Lozinka = @Lozinka";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Lozinka", password);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Korisnik
                    {
                        KorisnikId = Convert.ToInt32(reader["KorisnikId"]),
                        Ime = reader["Ime"].ToString(),
                        Prezime = reader["Prezime"].ToString(),
                        Username = reader["Username"].ToString(),
                        Lozinka = reader["Lozinka"].ToString(),
                        IsAdmin = Convert.ToBoolean(reader["IsAdmin"])
                    };
                }

                return null;
            }
        }
    }
}

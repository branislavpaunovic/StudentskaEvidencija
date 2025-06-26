using StudentskaEvidencija.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaEvidencija.DAL
{
    public class SmerDAL
    {
        private readonly string connectionString;

        public SmerDAL(string connString)
        {
            connectionString = connString;
        }

        public List<Smer> GetAllSmerovi()
        {
            List<Smer> smerovi = new List<Smer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Smer";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Smer s = new Smer
                    {
                        SmerId = Convert.ToInt32(reader["SmerId"]),
                        NazivSmera = reader["NazivSmera"].ToString(),
                        OznakaSmera = reader["OznakaSmera"].ToString()
                    };

                    smerovi.Add(s);
                }

                reader.Close();
            }

            return smerovi;
        }
    }
}

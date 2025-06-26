using StudentskaEvidencija.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaEvidencija.DAL
{
    public class PolDAL
    {
        private readonly string connectionString;

        public PolDAL(string connString)
        {
            connectionString = connString;
        }

        public List<Pol> GetAllPolovi()
        {
            List<Pol> polovi = new List<Pol>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pol";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pol p = new Pol
                    {
                        PolID = Convert.ToInt32(reader["PolID"]),
                        SifraPola = reader["SifraPola"].ToString(),
                        NazivPola = reader["NazivPola"].ToString()
                    };

                    polovi.Add(p);
                }

                reader.Close();
            }

            return polovi;
        }
    }
}

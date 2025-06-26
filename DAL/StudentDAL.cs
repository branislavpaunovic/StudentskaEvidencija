using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using StudentskaEvidencija.Models;

namespace StudentskaEvidencija.DAL
{
    public class StudentDAL
    {
        private readonly string connectionString;

        public StudentDAL(string connString)
        {
            connectionString = connString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student
                    {
                        StudentId = Convert.ToInt32(reader["StudentId"]),
                        Ime = reader["Ime"].ToString(),
                        Prezime = reader["Prezime"].ToString(),
                        DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                        BrojIndeksa = reader["BrojIndeksa"].ToString(),
                        Telefon = reader["Telefon"] as string,
                        Email = reader["Email"] as string,
                        Ulica = reader["Ulica"] as string,
                        BrojKuce = reader["BrojKuce"] as string,
                        PTT = reader["PTT"] as string,
                        Grad = reader["Grad"] as string,
                        Zemlja = reader["Zemlja"] as string,
                        SmerId = Convert.ToInt32(reader["SmerId"]),
                        JeAdministrator = Convert.ToBoolean(reader["JeAdministrator"]),
                        PolID = reader["PolID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PolID"]),
                        KorisnikID = Convert.ToInt32(reader["KorisnikID"])
                    };

                    students.Add(s);
                }

                reader.Close();
            }

            return students;
        }
    }
}

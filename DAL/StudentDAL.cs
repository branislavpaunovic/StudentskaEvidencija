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
                        StudentId = reader["StudentId"] != DBNull.Value ? Convert.ToInt32(reader["StudentId"]) : 0,
                        Ime = reader["Ime"] != DBNull.Value ? reader["Ime"].ToString() : "",
                        Prezime = reader["Prezime"] != DBNull.Value ? reader["Prezime"].ToString() : "",
                        DatumRodjenja = reader["DatumRodjenja"] != DBNull.Value ? Convert.ToDateTime(reader["DatumRodjenja"]) : DateTime.MinValue,
                        BrojIndeksa = reader["BrojIndeksa"] != DBNull.Value ? reader["BrojIndeksa"].ToString() : "",
                        Telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : "",
                        Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                        Ulica = reader["Ulica"] != DBNull.Value ? reader["Ulica"].ToString() : "",
                        BrojKuce = reader["BrojKuce"] != DBNull.Value ? reader["BrojKuce"].ToString() : "",
                        PTT = reader["PTT"] != DBNull.Value ? reader["PTT"].ToString() : "",
                        Grad = reader["Grad"] != DBNull.Value ? reader["Grad"].ToString() : "",
                        Zemlja = reader["Zemlja"] != DBNull.Value ? reader["Zemlja"].ToString() : "",
                        SmerId = reader["SmerId"] != DBNull.Value ? Convert.ToInt32(reader["SmerId"]) : 0,
                        PolID = reader["PolID"] != DBNull.Value ? Convert.ToInt32(reader["PolID"]) : 0,
                    };

                    students.Add(s);
                }

                reader.Close();
            }

            return students;
        }
    }
}

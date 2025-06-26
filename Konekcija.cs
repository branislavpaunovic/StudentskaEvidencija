using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StudentskaEvidencija
{
    public static class Konekcija
    {
        public static string Get()
        {
            return ConfigurationManager.ConnectionStrings["StudentskaEvidencija"].ConnectionString;
        }
    }
}

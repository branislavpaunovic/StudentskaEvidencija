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
    public enum UserRole
    {
        Guest,
        User,
        Admin,
        SuperAdmin
    }
}

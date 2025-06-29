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
    public class LoginManager
    {
        private static LoginManager _instance;

        private LoginManager() { }

        public static LoginManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginManager();
                }
                return _instance;
            }
        }

        public User CurrentUser { get; private set; }

        public void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        public bool IsLoggedIn => CurrentUser != null;

        public bool IsAdmin() => CurrentUser != null && CurrentUser.Role == UserRole.Admin;
        public bool IsSuperAdmin() => CurrentUser != null && CurrentUser.Role == UserRole.SuperAdmin;
        public bool IsUser() => CurrentUser != null && CurrentUser.Role == UserRole.User;
    }
}

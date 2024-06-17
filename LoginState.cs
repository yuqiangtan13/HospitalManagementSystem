using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{

    public static class LoginState
    {
        private static bool _isLoggedIn = false;

        private static bool _isPatient = false;

        private static string loggedInUserId = string.Empty;

        public static bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }

        public static bool IsPatient
        {
            get { return _isPatient; }
            set { _isPatient = value; }
        }

        public static string GetLoggedInUserId
        {
            get { return loggedInUserId; }
            set { loggedInUserId = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheCosmosHotel
{
    class Login
    {
        private string username;
        private string password;
        private string userType;

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
       
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Login()
        {

        }

        public Login(string username, string password, string userType)
        {
            this.username = username;
            this.password = password;
            this.userType = userType;
        }
    }
}

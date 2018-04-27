using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS_Entitiy
{
    public class UserLogin
    {
        String username;
        String pass;
        String name;
        String lastName;
        int userType;

        public UserLogin(string username, string password, string name, string lastName, int userType)
        {
            this.username = username;
            this.pass = password;
            this.name = name;
            this.lastName = lastName;
            this.userType = userType;
        }
        public UserLogin()
        {
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int UserType
        {
            get
            {
                return userType;
            }

            set
            {
                userType = value;
            }
        }
    }
}
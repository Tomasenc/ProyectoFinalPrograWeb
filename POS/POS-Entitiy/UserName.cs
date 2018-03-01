using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS_Entitiy
{
    public class UserName
    {
        int idUserName;
        String username;
        String password;
        String name;
        String lastName;
        int userType;

        public UserName(int idUserName, string username, string password, string name, string lastName, int userType)
        {
            this.idUserName = idUserName;
            this.username = username;
            this.password = password;
            this.name = name;
            this.lastName = lastName;
            this.userType = userType;
        }

        public int IdUserName
        {
            get
            {
                return idUserName;
            }

            set
            {
                idUserName = value;
            }
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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
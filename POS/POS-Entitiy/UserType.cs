using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS_Entitiy
{
    public class UserType
    {
        int idUserType;
        String description;

        public UserType(int idUserType, string description)
        {
            this.idUserType = idUserType;
            this.description = description;
        }

        public int IdUserType
        {
            get
            {
                return idUserType;
            }

            set
            {
                idUserType = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
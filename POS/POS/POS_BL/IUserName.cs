using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface IUserName
    {
        UserName GetUserName(String nombreUsuario);

        Boolean GetLogIn(String nombreUsuario, String Password);

        List<UserName> UserNameList();

        void AddUserName(UserName pUserName);

        void ModifyUserName(UserName pUsername);

    }
}

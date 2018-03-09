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
        UserLogin GetUserName(String nombreUsuario);

        List<UserLogin> UserNameList();

        void AddUserName(UserLogin pUserName);

        void ModifyUserName(UserLogin pUsername);

    }
}

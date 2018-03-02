using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_BL;
using POS_Entitiy;
using POS_Data;

namespace POS_DATA
{
    public class MUserName : IUserName
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUserName()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void AddUserName(UserName pUserName)
        {
            _db.Insert(pUserName);
        }

        public UserName GetUserName(string pUserName)
        {
            return _db.Select<UserName>(x => x.Username == pUserName).FirstOrDefault();
        }

        Boolean GetLogIn(String pNombreUsuario, String pPassword)
        {
            UserName auxUserName = this.GetUserName(pNombreUsuario);
            if (auxUserName.Password == pPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void ModifyUserName(UserName pUsername)
        {
            _db.Update(pUsername);
        }
        
        public List<UserName> UserNameList()
        {
            return _db.Select<UserName>();
        }
    }
}

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

        public void AddUserName(UserLogin pUserName)
        {
            _db.Insert(pUserName);
        }

        public UserLogin GetUserName(string pUserName)
        {
            return _db.Select<UserLogin>(x => x.Username == pUserName).FirstOrDefault();

        }

        public void ModifyUserName(UserLogin pUsername)
        {
            _db.Update(pUsername);
        }
        
        public List<UserLogin> UserNameList()
        {
            return _db.Select<UserLogin>();
        }
    }
}

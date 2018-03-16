using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POS_Entitiy;
using POS_BL;

namespace POS_Data
{
    public class MUserType : IUserType
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUserType()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        List<UserType> IUserType.UserTypeList()
        {
            return _db.Select<UserType>();
        }
    }
}
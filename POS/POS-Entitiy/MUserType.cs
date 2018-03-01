using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POS_DATA
{
    public class MUserType
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUserType()
        {
            _conexion = new OrmLiteConnectionFactory(DBAcess.Default.Conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }



    }
}
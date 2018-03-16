using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_BL;
using POS_Entitiy;
using ServiceStack.OrmLite;
using System.Data;

namespace POS_Data
{
    public class MTableStatus : ITableStatus
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MTableStatus()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<TableStatus> TableStatusList()
        {
            return _db.Select<TableStatus>();
        }

        public TableStatus GetTableStatus(int idStatus)
        {
            return _db.Select<TableStatus>(x => x.idStatus == idStatus).FirstOrDefault();
        }

    }
}

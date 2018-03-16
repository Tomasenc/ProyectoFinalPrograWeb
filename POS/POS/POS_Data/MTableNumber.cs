using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using System.Data;
using POS_BL;
using POS_Data;
using POS_Entitiy;

namespace POS_Data
{
    public class MTableNumber : ITableNumber
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MTableNumber()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void addTable(TableNumber idTableStatus)
        {
            _db.Insert(idTableStatus);
        }

        public TableNumber getTable(int idTable)
        {
            return _db.Select<TableNumber>(x => x.Idtable == idTable).FirstOrDefault(); 
        }

        public void ModifyTable(TableNumber idTable)
        {
            _db.Update(idTable);
        }

        public List<TableNumber> TableList()
        {
            return _db.Select<TableNumber>();
        }
    }
}

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
    public class MProductCategory : IProductCategory
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProductCategory()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public List<ProductCategory> ProducCategoryList()
        {
            return _db.Select<ProductCategory>();
        }
    }
}

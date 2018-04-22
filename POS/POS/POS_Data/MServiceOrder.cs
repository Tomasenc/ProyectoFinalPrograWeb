using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;
using POS_BL;
using ServiceStack.OrmLite;
using System.Data;

namespace POS_Data
{
    public class MServiceOrder : IServiceOrder
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MServiceOrder()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<ServiceOrder> ListServiceOrder()
        {
            return _db.Select<ServiceOrder>();
        }

        public ServiceOrder SearchServiceOrder(int idServiceOrder)
        {
            return _db.Select<ServiceOrder>(x => x.IdServiceOrder == idServiceOrder).FirstOrDefault();
        }

        public void InsertServiceOrder(ServiceOrder serviceOrder)
        {
            _db.Insert(serviceOrder);
        }

        public void UpdateServiceOrder(ServiceOrder serviceOrder)
        {
            _db.Update(serviceOrder);
        }

        public void DeleteServiceOrder(int idServiceOrder)
        {
            _db.Delete<ServiceOrder>(x => x.IdServiceOrder == idServiceOrder);
        }
    }
}

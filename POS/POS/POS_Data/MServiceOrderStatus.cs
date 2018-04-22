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
    public class MServiceOrderStatus : IServiceOrderStatus
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MServiceOrderStatus()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<ServiceOrderStatus> ListServiceOrderStatus()
        {
            return _db.Select<ServiceOrderStatus>();
        }

        public ServiceOrderStatus SearchServiceOrderStatus(int idServiceOrderStatus)
        {
            return _db.Select<ServiceOrderStatus>(x => x.IdServiceOrderStatus == idServiceOrderStatus).FirstOrDefault();
        }

        public void InsertServiceOrderStatus(ServiceOrderStatus serviceOrderStatus)
        {
            _db.Insert(serviceOrderStatus);
        }

        public void UpdateServiceOrderStatus(ServiceOrderStatus serviceOrderStatus)
        {
            _db.Update(serviceOrderStatus);
        }

        public void DeleteServiceOrderStatus(int idServiceOrderStatus)
        {
            _db.Delete<ServiceOrderStatus>(x => x.IdServiceOrderStatus == idServiceOrderStatus);
        }
    }
}

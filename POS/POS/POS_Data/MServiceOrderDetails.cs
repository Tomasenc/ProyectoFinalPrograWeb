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
    public class MServiceOrderDetails : IServiceOrderDetails
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MServiceOrderDetails()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        public List<ServiceOrderDetails> ListServiceOrderDetails(int idServiceOrder)
        {
            return _db.Select<ServiceOrderDetails>(x => x.IdServiceOrder == idServiceOrder);
        }

        public ServiceOrderDetails SearchServiceOrderDetails(int idServiceOrderDetails)
        {
            return _db.Select<ServiceOrderDetails>(x => x.IdServiceOrderDetails == idServiceOrderDetails).FirstOrDefault();
        }

        public void InsertServiceOrderDetails(ServiceOrderDetails serviceOrderDetails)
        {
            _db.Insert(serviceOrderDetails);
        }

        public void UpdateServiceOrderDetails(ServiceOrderDetails serviceOrderStatus)
        {
            _db.Update(serviceOrderStatus);
        }

        public void DeleteServiceOrderDetails(int idServiceOrderDetails)
        {
            _db.Delete<ServiceOrderDetails>(x => x.IdServiceOrderDetails == idServiceOrderDetails);
        }
    }
}

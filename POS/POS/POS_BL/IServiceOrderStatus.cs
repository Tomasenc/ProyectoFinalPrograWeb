using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface IServiceOrderStatus
    {
        List<ServiceOrderStatus> ListServiceOrderStatus();
        ServiceOrderStatus SearchServiceOrderStatus(int idServiceOrderStatus);
        void InsertServiceOrderStatus(ServiceOrderStatus ServiceOrderStatus);
        void UpdateServiceOrderStatus(ServiceOrderStatus ServiceOrderStatus);
        void DeleteServiceOrderStatus(int idServiceOrderStatus);
    }
}

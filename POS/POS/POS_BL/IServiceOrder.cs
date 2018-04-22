using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface IServiceOrder
    {
        List<ServiceOrder> ListServiceOrder();
        ServiceOrder SearchServiceOrder(int idServiceOrder);
        void InsertServiceOrder(ServiceOrder ServiceOrder);
        void UpdateServiceOrder(ServiceOrder ServiceOrder);
        void DeleteServiceOrder(int ServiceOrder);
    }
}

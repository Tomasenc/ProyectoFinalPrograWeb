using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface IServiceOrderDetails
    {
        List<ServiceOrderDetails> ListServiceOrderDetails(int idServiceOrder);
        ServiceOrderDetails SearchServiceOrderDetails(int idServiceOrderDetails);
        void InsertServiceOrderDetails(ServiceOrderDetails ServiceOrderDetails);
        void UpdateServiceOrderDetails(ServiceOrderDetails ServiceOrderDetails);
        void DeleteServiceOrderDetails(int idServiceOrderDetails);
    }
}

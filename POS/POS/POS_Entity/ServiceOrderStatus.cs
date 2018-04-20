using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entity
{
    public class ServiceOrderStatus
    {
        int idServiceOrderStatus;
        String ServiceOrderDescription;

        public ServiceOrderStatus()
        {

        }

        public ServiceOrderStatus(int idServiceOrderStatus, string serviceOrderDescription)
        {
            this.idServiceOrderStatus = idServiceOrderStatus;
            ServiceOrderDescription = serviceOrderDescription;
        }

        public int IdServiceOrderStatus
        {
            get
            {
                return idServiceOrderStatus;
            }

            set
            {
                idServiceOrderStatus = value;
            }
        }

        public string ServiceOrderDescription1
        {
            get
            {
                return ServiceOrderDescription;
            }

            set
            {
                ServiceOrderDescription = value;
            }
        }
    }
}

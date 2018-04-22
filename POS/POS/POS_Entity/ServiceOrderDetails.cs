using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class ServiceOrderDetails
    {
        int idServiceOrderDetails;
        int idServiceOrder;
        int idProduct;
        String serviceOrderNotes;

        public ServiceOrderDetails(int idServiceOrderDetails, int idServiceOrder, int idProduct, string serviceOrderNotes)
        {
            this.idServiceOrderDetails = idServiceOrderDetails;
            this.idServiceOrder = idServiceOrder;
            this.idProduct = idProduct;
            this.serviceOrderNotes = serviceOrderNotes;
        }

        public int IdServiceOrderDetails
        {
            get
            {
                return idServiceOrderDetails;
            }

            set
            {
                idServiceOrderDetails = value;
            }
        }

        public int IdServiceOrder
        {
            get
            {
                return idServiceOrder;
            }

            set
            {
                idServiceOrder = value;
            }
        }

        public int IdProduct
        {
            get
            {
                return idProduct;
            }

            set
            {
                idProduct = value;
            }
        }

        public string ServiceOrderNotes
        {
            get
            {
                return serviceOrderNotes;
            }

            set
            {
                serviceOrderNotes = value;
            }
        }
    }
}

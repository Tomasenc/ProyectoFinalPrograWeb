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
        int quantity;
        decimal total;
        String serviceOrderNotes;

        public ServiceOrderDetails(int idServiceOrderDetails, int idServiceOrder, int idProduct, string serviceOrderNotes, int quantity, decimal total)
        {
            this.idServiceOrderDetails = idServiceOrderDetails;
            this.idServiceOrder = idServiceOrder;
            this.idProduct = idProduct;
            this.serviceOrderNotes = serviceOrderNotes;
            this.Quantity = quantity;
            this.Total = total;
        }

        public ServiceOrderDetails()
        {
            
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

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}

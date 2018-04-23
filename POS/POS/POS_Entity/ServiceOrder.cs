using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class ServiceOrder
    {
        int idServiceOrder;
        String idUserLogin;
        int idTableNumber;
        int idServiceOrderStatus;

        public ServiceOrder()
        {

        }

        public ServiceOrder(int idServiceOrder, string idUserLogin, int idTableNumber, int idServiceOrderStatus)
        {
            this.IdServiceOrder = idServiceOrder;
            this.IdUserLogin = idUserLogin;
            this.IdTableNumber = idTableNumber;
            this.IdServiceOrderStatus = idServiceOrderStatus;
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

        public string IdUserLogin
        {
            get
            {
                return idUserLogin;
            }

            set
            {
                idUserLogin = value;
            }
        }

        public int IdTableNumber
        {
            get
            {
                return idTableNumber;
            }

            set
            {
                idTableNumber = value;
            }
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
    }
}

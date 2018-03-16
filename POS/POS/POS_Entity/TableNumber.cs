using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class TableNumber
    {
        int idtable;
        int idTableStatus;

        public TableNumber(int idtable, int idTableStatus)
        {
            this.Idtable = idtable;
            this.IdTableStatus = idTableStatus;
        }

        public int Idtable
        {
            get
            {
                return idtable;
            }

            set
            {
                idtable = value;
            }
        }

        public int IdTableStatus
        {
            get
            {
                return idTableStatus;
            }

            set
            {
                idTableStatus = value;
            }
        }
    }
}

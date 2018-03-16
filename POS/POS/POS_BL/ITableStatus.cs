using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface ITableStatus
    {
        List<TableNumber> UserTypeList();

        void ModifyTableStatus(TableNumber idTableStatus);

    }
}

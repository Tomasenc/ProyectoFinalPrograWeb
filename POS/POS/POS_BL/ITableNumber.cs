using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface ITableNumber
    {
        TableNumber getTable(int idTable);

        List<TableNumber> TableList();

        void addTable(TableNumber idTableStatus);

        void ModifyTable(TableNumber idTable);
    }
}

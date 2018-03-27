using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_Entitiy;

namespace POS_BL
{
    public interface IProduct
    {
        Product getTable(int idProduct);

        List<Product> ProductList();

        void addTable(Product pProduct);

        void ModifyTable(Product pProduct);
    }
}

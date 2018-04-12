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
        Product getProduct(int idProduct);

        List<Product> ProductList();

        void addProduct(Product pProduct);

        void ModifyProduct(Product pProduct);
    }
}

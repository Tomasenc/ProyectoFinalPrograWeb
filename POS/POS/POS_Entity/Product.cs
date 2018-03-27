using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class Product
    {
        int idProduct;
        String description;
        int idProductCategory;
        int productStatus;

        public Product( string description, int idProductCategory, int productStatus)
        {
            this.description = description;
            this.idProductCategory = idProductCategory;
            this.productStatus = productStatus;
        }

        public Product()
        {
            
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int IdProductCategory
        {
            get
            {
                return idProductCategory;
            }

            set
            {
                idProductCategory = value;
            }
        }

        public int ProductStatus
        {
            get
            {
                return productStatus;
            }

            set
            {
                productStatus = value;
            }
        }
    }
}

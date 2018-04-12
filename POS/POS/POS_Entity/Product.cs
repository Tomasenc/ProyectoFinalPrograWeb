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
        String productDescription;
        int idProductCategory;
        int productStatus;
        String productCategoryDescription;

        public Product( string description, int idProductCategory, int productStatus)
        {
            this.productDescription = description;
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

        public string ProductDescription
        {
            get
            {
                return productDescription;
            }

            set
            {
                productDescription = value;
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

        public string ProductCategoryDescription
        {
            get
            {
                return productCategoryDescription;
            }

            set
            {
                productCategoryDescription = value;
            }
        }
    }
}

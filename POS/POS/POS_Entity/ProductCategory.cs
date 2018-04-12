using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class ProductCategory
    {
        int idProductCategory;
        String productCategoryDescription;

        public ProductCategory(int idProductCategory, string descrition)
        {
            this.IdProductCategory = idProductCategory;
            this.productCategoryDescription = descrition;
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

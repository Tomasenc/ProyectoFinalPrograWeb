using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Entitiy
{
    public class ProductCategory
    {
        int idProducCategory;
        String descrition;

        public ProductCategory(int idProducCategory, string descrition)
        {
            this.IdProducCategory = idProducCategory;
            this.Descrition = descrition;
        }

        public int IdProducCategory
        {
            get
            {
                return idProducCategory;
            }

            set
            {
                idProducCategory = value;
            }
        }

        public string Descrition
        {
            get
            {
                return descrition;
            }

            set
            {
                descrition = value;
            }
        }

        
    }
}

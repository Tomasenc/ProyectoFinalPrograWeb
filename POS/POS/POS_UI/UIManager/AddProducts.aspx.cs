using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POS_Data;
using POS_Entitiy;
using POS_BL;

namespace POS_UI.UIManager
{
    public partial class AddProducts : System.Web.UI.Page
    {
        IProduct IProducGV;
        IProductCategory IProductCategoryGV;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Load the created tables from DB
                if (!IsPostBack)
                {
                    this.IProducGV = new MProduct();

                    List<Product> PL = IProducGV.ProductList();

                    this.dgvProducts.DataSource = PL;
                    this.dgvProducts.DataBind();
                    
                    //Fill the select (dropDown) with the Table Status created on db


                    /*this.ITableStatus = new MTableStatus();

                    sltTableStatus.DataValueField = "description";
                    rbtlTableList2.DataTextField = "idStatus";

                    this.TS = ITableStatus.TableStatusList();

                    sltTableStatus.DataSource = TS;
                    sltTableStatus.DataBind();*/
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
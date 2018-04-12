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
                    LoadDataGridView();
                    
                    //Fill the select (dropDown) with the Table Status created on db


                    this.IProductCategoryGV = new MProductCategory();

                    stlCategory.DataValueField = "idProductCategory";
                    stlCategory.DataTextField = "productCategoryDescription";

                    List<ProductCategory> TS = IProductCategoryGV.ProductCategoryList();

                    stlCategory.DataSource = TS;
                    stlCategory.DataBind();


                    //Fill the select Status

                    
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void LoadDataGridView()
        {
            this.IProducGV = new MProduct();

            List<Product> PL = IProducGV.ProductList();

            this.dgvProducts.DataSource = PL;
            this.dgvProducts.DataBind();
        }

        protected void dgvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(this.dgvProducts.SelectedDataKey.Value.ToString());
            this.IProducGV = new MProduct();

            Product auxProduct = IProducGV.getProduct(productID);

            this.txtIdProduct.Text = auxProduct.IdProduct.ToString();
            this.txtDecription.Text = auxProduct.ProductDescription;
            this.stlCategory.SelectedIndex = auxProduct.IdProductCategory-1;
            this.ddlStatus.SelectedIndex = auxProduct.ProductStatus;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            this.IProducGV = new MProduct();

            Product auxProduct = new Product();

            auxProduct.IdProduct = Convert.ToInt32(this.txtIdProduct.Text);
            auxProduct.ProductDescription = this.txtDecription.Text;
            auxProduct.IdProductCategory = Convert.ToInt32(this.stlCategory.SelectedIndex);
            auxProduct.ProductStatus = Convert.ToInt32(this.ddlStatus.SelectedIndex);

            IProducGV.ModifyProduct(auxProduct);
            this.LoadDataGridView();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.IProducGV = new MProduct();
            Product auxProduct = new Product();

            auxProduct.ProductDescription = this.txtDecription.Text;
            auxProduct.IdProductCategory = Convert.ToInt32(this.stlCategory.SelectedIndex);
            auxProduct.ProductStatus = Convert.ToInt32(this.ddlStatus.SelectedIndex);

            IProducGV.addProduct(auxProduct);
            this.LoadDataGridView();
        }
    }
}
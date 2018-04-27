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
    public partial class AddServiceOrder : System.Web.UI.Page
    {
        IServiceOrderDetails ISODGV;
        IServiceOrder ISOGV;
        IProduct IProducGV;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int detailServiceOrder = Convert.ToInt32(Request.QueryString["idServiceOrder"]);

                if (detailServiceOrder != 0)
                {
                    if (!IsPostBack)
                    {
                        this.ISODGV = new MServiceOrderDetails();
                        this.ISOGV = new MServiceOrder();

                        ServiceOrder auxSO = ISOGV.SearchServiceOrder(detailServiceOrder);

                        List<ServiceOrderDetails> SODL = ISODGV.ListServiceOrderDetails(detailServiceOrder);

                        this.dgvServiceOrderDetails.DataSource = SODL;
                        this.dgvServiceOrderDetails.DataBind();

                        this.txtIdServiceOrder.Text = auxSO.IdServiceOrder.ToString();
                        this.txtTableNumber.Text = auxSO.IdTableNumber.ToString();
                        this.txtWaiter.Text = auxSO.IdUserLogin;
                        this.txtTotal.Text = auxSO.Total.ToString();

                        this.IProducGV = new MProduct();

                        List<Product> PL = IProducGV.ProductList();

                        stlProductDecription.DataValueField = "idProduct";
                        stlProductDecription.DataTextField = "productDescription";

                        stlProductDecription.DataSource = PL;
                        stlProductDecription.DataBind();
                    }
                }
                else
                {
                    Response.Redirect("ListServiceOrder.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        protected void dgvServiceOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SODid = Convert.ToInt32(this.dgvServiceOrderDetails.SelectedDataKey.Value.ToString());
            this.txtIdProduct.Text = this.dgvServiceOrderDetails.SelectedDataKey.Value.ToString();
            this.stlProductDecription.SelectedIndex = SODid-1;
        }

        

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProduct.Text != "")
                {
                    this.ISODGV = new MServiceOrderDetails();

                    ISODGV.DeleteServiceOrderDetails(Convert.ToInt32(this.txtIdProduct.Text), Convert.ToInt32(this.txtIdProduct.Text));
                    int detailServiceOrder = Convert.ToInt32(Request.QueryString["idServiceOrder"]);

                    if (detailServiceOrder != 0)
                    {
                        if (!IsPostBack)
                        {
                            this.ISODGV = new MServiceOrderDetails();
                            this.ISOGV = new MServiceOrder();

                            ServiceOrder auxSO = ISOGV.SearchServiceOrder(detailServiceOrder);

                            List<ServiceOrderDetails> SODL = ISODGV.ListServiceOrderDetails(detailServiceOrder);

                            this.dgvServiceOrderDetails.DataSource = SODL;
                            this.dgvServiceOrderDetails.DataBind();

                        }
                    }
                    else
                    {
                        Response.Redirect("ListServiceOrder.aspx");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

    }
}

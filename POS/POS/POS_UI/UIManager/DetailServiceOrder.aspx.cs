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
        IServiceOrderDetails ISDGV;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int detailServiceOrder = Convert.ToInt32(Request.QueryString["DetailServiceOrder"]);
                if (!IsPostBack)
                {
                    this.ISDGV = new MServiceOrderDetails();

                    List<ServiceOrderDetails> PL = ISDGV.ListServiceOrderDetails(detailServiceOrder);

                    this.dgvServiceOrderDetails.DataSource = PL;
                    this.dgvServiceOrderDetails.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
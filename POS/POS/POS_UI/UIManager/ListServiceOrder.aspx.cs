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
    public partial class RegistrarCommanda : System.Web.UI.Page
    {
        IServiceOrder ISOGV;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Load the created tables from DB
                if (!IsPostBack)
                {
                    this.ISOGV = new MServiceOrder();

                    List<ServiceOrder> PL = ISOGV.ListServiceOrder();

                    this.dgvServiceOrder.DataSource = PL;
                    this.dgvServiceOrder.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void dgvServiceOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SOid = Convert.ToInt32(this.dgvServiceOrder.SelectedDataKey.Value.ToString());
            this.ISOGV = new MServiceOrder();

            ServiceOrder auxSO = ISOGV.SearchServiceOrder(SOid);

            this.txtIdServiceOrder.Text = auxSO.IdServiceOrder.ToString();
        }

        protected void btnDetails_Click(object sender, EventArgs e)
        {
            int SOid = Convert.ToInt32(this.txtIdServiceOrder.Text);
            Response.Redirect("DetailServiceOrder.aspx?idServiceOrder=" + SOid);
        }
    }
}
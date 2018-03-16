using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POS_UI.UIManager
{
    public partial class Manager : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                this.lblUserName.Text = Session["usuario"].ToString();
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("../Login.aspx");
        }
    }
}
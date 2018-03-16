using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POS_Data;
using POS_BL;
using POS_Entitiy;

namespace POS_UI
{
    public partial class Login : System.Web.UI.Page
    {
        public IUserName iUserNamelGV;  
        protected void Page_Load(object sender, EventArgs e)
        {
            iUserNamelGV = new MUserName();
            if (!IsPostBack)
            {
                this.lblError.Visible=false;
            }
        }
    

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = this.txtUserName.Text;
                String userPassword = this.txtPassword.Text;

                UserLogin auxUser = (UserLogin)iUserNamelGV.GetUserName(userName);

                if (auxUser!=null)
                {
                    if (auxUser.Pass == userPassword)
                    {
                        Session["usuario"] = userName;
                        if (auxUser.UserType == 0) //Waiter user
                        {
                            Response.Redirect("/UIWaiter/index.aspx");
                        }
                        else // Manager user
                        {
                            Response.Redirect("/UIManager/AddTables.aspx");
                        }

                    }
                }
                else
                {
                    this.lblError.Text = "Usuario o password in correcto";
                    this.txtUserName.CssClass = "form-control form-control-lg rounded-0 alert-danger";
                    this.txtPassword.CssClass = "form-control form-control-lg rounded-0 alert-danger";
                    this.lblError.Visible = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
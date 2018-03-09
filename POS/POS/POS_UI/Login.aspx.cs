using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POS_DATA;
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
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = this.txtUserName.Text;
                String userPassword = this.txtPassword.Text;
                UserName auxUser = (UserName)iUserNamelGV.GetUserName(userName);
                if (auxUser.Username == userName)
                {
                    Session["usuario"] = userName;
                    if (auxUser.UserType==0) //Waiter user
                    {
                        Response.Redirect("/index.aspx");
                    }
                    else // Manager user
                    {
                        Response.Redirect("/UIManager/index.aspx");
                    }
                    
                }
                else
                {
                    this.lblError.Text = "Usuario o password in correcto";
                    this.lblError.Visible = true;
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
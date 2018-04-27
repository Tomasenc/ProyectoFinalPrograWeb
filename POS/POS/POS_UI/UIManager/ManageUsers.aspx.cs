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
    public partial class ManageUsers : System.Web.UI.Page
    {
        IUserName IUNGV;
        IUserType IUNTGV;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Load the created tables from DB
                if (!IsPostBack)
                {
                    LoadDataGridView();
                    
                    //Fill the select (dropDown) with the Table Status created on db


                    this.IUNTGV = new MUserType();

                    this.sltUserType.DataValueField = "idUserType";
                    this.sltUserType.DataTextField = "description";

                    List<UserType> UT = IUNTGV.UserTypeList();

                    this.sltUserType.DataSource = UT;
                    this.sltUserType.DataBind();


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
            this.IUNGV = new MUserName();

            List<UserLogin> UT = IUNGV.UserNameList();

            this.dgvUsers.DataSource = UT;
            this.dgvUsers.DataBind();
        }

        protected void dgvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            String userName = this.dgvUsers.SelectedDataKey.Value.ToString();
            this.IUNGV = new MUserName();

            UserLogin auxUser = IUNGV.GetUserName(userName);

            this.txtUserName.Text = auxUser.Username;
            this.txtName.Text = auxUser.Name;
            this.sltUserType.SelectedIndex = auxUser.UserType-1;
            this.txtLastName.Text = auxUser.LastName;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text!=""&&this.txtConfirmPassword.Text!="")
            {
                if (this.txtPassword.Text==this.txtConfirmPassword.Text)
                {
                    this.IUNGV = new MUserName();
                    UserLogin auxUser = new UserLogin();

                    auxUser.Username = this.txtUserName.Text;
                    auxUser.Name = this.txtName.Text;
                    auxUser.LastName = this.txtLastName.Text;
                    auxUser.UserType = this.sltUserType.SelectedIndex;
                    auxUser.Pass = this.txtPassword.Text;

                    IUNGV.ModifyUserName(auxUser);
                    this.LoadDataGridView();
                }
                
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text != "" && this.txtConfirmPassword.Text != "")
            {
                if (this.txtPassword.Text == this.txtConfirmPassword.Text)
                {
                    this.IUNGV = new MUserName();
                    UserLogin auxUser = new UserLogin();

                    auxUser.Username = this.txtUserName.Text;
                    auxUser.Name = this.txtName.Text;
                    auxUser.LastName = this.txtLastName.Text;
                    auxUser.UserType = this.sltUserType.SelectedIndex+1;
                    auxUser.Pass = this.txtPassword.Text;

                    IUNGV.AddUserName(auxUser);
                    this.LoadDataGridView();
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!="")
            {

            }
        }
    }
}
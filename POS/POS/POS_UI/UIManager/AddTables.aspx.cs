using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POS_BL;
using POS_Data;
using POS_Entitiy;

namespace POS_UI.UIManager
{
    public partial class AddTables : System.Web.UI.Page
    {
        ITableNumber ITableNumberGV;
        ITableStatus ITableStatus;
        List<TableStatus> TS;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Load the created tables from DB
                if (!IsPostBack)
                {
                    this.ITableNumberGV = new MTableNumber();

                    rbtlTableList.DataValueField = "idTableStatus";
                    rbtlTableList.DataTextField = "idTable";

                    List<TableNumber> TL = ITableNumberGV.TableList();
                    var tableNumberList = TL.Select(x => new
                    {
                        x.Idtable,
                        x.IdTableStatus
                    }).ToList();
                    rbtlTableList.DataSource = tableNumberList;
                    rbtlTableList.DataBind();

                    //Fill the select (dropDown) with the Table Status created on db


                    this.ITableStatus = new MTableStatus();

                    sltTableStatus.DataValueField = "description";
                    rbtlTableList.DataTextField = "idStatus";

                    this.TS = ITableStatus.TableStatusList();
                    var tableStatusList = TS.Select(x => new
                    {
                        x.idStatus,
                        x.description
                    }).ToList();
                    sltTableStatus.DataSource = tableStatusList;
                    sltTableStatus.DataBind();
                }
                


            }
            catch (Exception)
            {

                throw;
            }
            

        }

        protected void rbtlTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.txtTableNumber.Text = this.rbtlTableList.SelectedValue.ToString();
                this.sltTableStatus.SelectedIndex = this.rbtlTableList.SelectedIndex;
            }
            
        }
    }
}
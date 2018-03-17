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
                        x.IdTableStatus,
                        x.Idtable
                    }).ToList();
                    rbtlTableList.DataSource = TL;
                    rbtlTableList.DataBind();

                    GridView1.DataSource = tableNumberList;
                    GridView1.DataBind();

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
            String auxString = this.rbtlTableList.SelectedItem.Text;
            int auxInt = Convert.ToInt32( this.rbtlTableList.SelectedValue);
            this.txtTableNumber.Text = auxString;
            this.sltTableStatus.SelectedIndex = auxInt;
        }
    }
}
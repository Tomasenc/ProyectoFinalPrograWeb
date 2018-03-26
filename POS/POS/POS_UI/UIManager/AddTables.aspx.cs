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
        List<TableNumber> TL;

        public object RtDialysisSummary { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                //Load the created tables from DB
                if (!IsPostBack)
                {
                    this.ITableNumberGV = new MTableNumber();

                    TL = ITableNumberGV.TableList();
                    
                    rbtlTableList2.DataValueField = "idTable";
                    rbtlTableList2.DataTextField = "idTable";

                    rbtlTableList2.DataSource = TL;
                    rbtlTableList2.DataBind();

                    

                    //Fill the select (dropDown) with the Table Status created on db


                    this.ITableStatus = new MTableStatus();

                    sltTableStatus.DataValueField = "description";
                    rbtlTableList2.DataTextField = "idStatus";

                    this.TS = ITableStatus.TableStatusList();
                    
                    sltTableStatus.DataSource = TS;
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
            int auxNumTable = this.rbtlTableList2.SelectedIndex+1;

            this.ITableNumberGV = new MTableNumber();

            TableNumber auxTableNumber = ITableNumberGV.getTable(auxNumTable);

            this.txtTableNumber.Text = auxNumTable.ToString();
            this.sltTableStatus.SelectedIndex = auxTableNumber.IdTableStatus-1;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTableNumber.Text != "Unselected table")
                {
                    this.ITableNumberGV = new MTableNumber();
                    TableNumber pTable = new TableNumber(Convert.ToInt32(this.txtTableNumber.Text), this.sltTableStatus.SelectedIndex+1);

                    ITableNumberGV.ModifyTable(pTable);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTableNumber.Text != "Unselected table")
                {
                    this.ITableNumberGV = new MTableNumber();
                    TableNumber pTable = new TableNumber();
                    pTable.IdTableStatus = 1; //Free status 

                    ITableNumberGV.addTable(pTable);
                    Response.Redirect("Addtables.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
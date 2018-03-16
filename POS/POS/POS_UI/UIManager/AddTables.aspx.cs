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
        protected void Page_Load(object sender, EventArgs e)
        {
            ITableNumberGV = new MTableNumber();

            rbtlTableList.DataValueField = "idtable";
            rbtlTableList.DataTextField = "idTableStatus";
            



            List<TableNumber> TL = ITableNumberGV.TableList();
            var lista = TL.Select(x => new
            {
                x.Idtable,
                x.IdTableStatus
            }).ToList();
            rbtlTableList.DataSource = TL;
            rbtlTableList.DataBind();

        }
    }
}
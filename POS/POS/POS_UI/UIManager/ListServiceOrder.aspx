<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="ListServiceOrder.aspx.cs" Inherits="POS_UI.UIManager.RegistrarCommanda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-4 mb-3"> 
                Seected Service Order: <asp:TextBox ID="txtIdServiceOrder" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3 pt-4"> 
                <asp:Button ID="btnDetails" CssClass="btn btn-primary mr-2" runat="server" Text="Details" />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" />
            </div>

        </div>  
    </div>
    <hr />
    <div class="containerTable mt-3">
        
        <asp:GridView ID="dgvServiceOrder" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="idServiceOrder" EmptyDataText="There are no data records to display." AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvServiceOrder_SelectedIndexChanged">
            <Columns>  
                <asp:BoundField DataField="idServiceOrder" HeaderText="Order number" ReadOnly="True" />  
                <asp:BoundField DataField="idUserLogin" HeaderText="Waiter" />  
                <asp:BoundField DataField="idTableNumber" HeaderText="Table N°" />  
                <asp:BoundField DataField="idServiceOrderStatus" HeaderText="Status" />  
                <asp:BoundField DataField="total" HeaderText="Total" />  
            </Columns>  
        </asp:GridView>  
        
    </div>

</asp:Content>

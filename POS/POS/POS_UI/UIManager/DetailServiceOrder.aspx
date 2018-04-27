<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="DetailServiceOrder.aspx.cs" Inherits="POS_UI.UIManager.AddServiceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Service Orde N°: 
                <asp:TextBox ID="txtIdServiceOrder" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md2 mb-3"> 
                Waiter: 
                <asp:TextBox ID="txtWaiter" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md-2 mb-3"> 
                Table N°: 
                <asp:TextBox ID="txtTableNumber" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md-2 mb-3 pt-4"> 
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" />
            </div>
        </div>  
    </div>
    <hr />
    <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Selected product ID:
                <asp:TextBox ID="txtIdProduct" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div class="col-md2 mb-3"> 
                Description: 
                <select class="custom-select" id="stlProductDecription" runat="server"> </select>
            </div>
            <div class="col-md2 mb-3"> 
                <br />
                <asp:Button ID="btnDelete" CssClass="btn btn-danger mr-2" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
        </div>  
    </div>
    <div class="containerTable mt-3">

        
        <asp:GridView ID="dgvServiceOrderDetails" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="idProduct" EmptyDataText="There are no data records to display." AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvServiceOrderDetails_SelectedIndexChanged" >  
            <Columns>  
                <asp:BoundField DataField="idServiceOrderDetails" HeaderText="idServiceOrderDetails" ReadOnly="True" Visible="true"/>  
                <asp:BoundField DataField="idProduct" HeaderText="Product ID" />  
                <asp:BoundField DataField="quantity" HeaderText="Price" />  
                <asp:BoundField DataField="Total" HeaderText="Status"  />  
                <asp:BoundField DataField="serviceOrderNotes" HeaderText="Notes" />  
            </Columns>  
        </asp:GridView>  
        
    </div>
    <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Total: <asp:TextBox ID="txtTotal" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>

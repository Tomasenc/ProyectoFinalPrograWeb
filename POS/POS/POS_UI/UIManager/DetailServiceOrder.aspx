<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="DetailServiceOrder.aspx.cs" Inherits="POS_UI.UIManager.AddServiceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Service Orde N°: <asp:Label ID="lblIdServiceOrder" CssClass="form-control" runat="server"></asp:Label>
            </div>
            <div class="col-md2 mb-3"> 
                Waiter: <asp:Label ID="lblWaiter" CssClass="form-control" runat="server" ></asp:Label>
            </div>
            <div class="col-md-2 mb-3"> 
                Table N°: <asp:Label ID="lblTableNumber" CssClass="form-control" runat="server" ></asp:Label>
            </div>
            <div class="col-md-2 mb-3 pt-4"> 
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mr-2" runat="server" Text="Update" />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" />
            </div>
        </div>  
    </div>
    <hr />
    <div class="containerTable mt-3">
        
        <asp:GridView ID="dgvServiceOrderDetails" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="idProduct" EmptyDataText="There are no data records to display." AutoGenerateSelectButton="True">  
            <Columns>  
                <asp:BoundField DataField="idProduct" HeaderText="ID" ReadOnly="True" />  
                <asp:BoundField DataField="quantity" HeaderText="Price" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
                <asp:BoundField DataField="Total" HeaderText="Status" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
                <asp:BoundField DataField="serviceOrderNotes" HeaderText="Notes" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
            </Columns>  
        </asp:GridView>  
        
    </div>
    <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Total: <asp:Label ID="lbltotal" CssClass="form-control" runat="server"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

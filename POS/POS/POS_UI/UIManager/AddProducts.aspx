<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="POS_UI.UIManager.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-3 mb-3"> 
                Table: <asp:TextBox ID="txtTableNumber" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3"> 
                Description: <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>
        
            <div class="col-md-3 mb-3"> 
                Category: <select class="custom-select" id="stlCategory" runat="server"> </select>
            </div>
            <div class="col-md-3 mb-3 pt-4"> 
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mr-2" runat="server" Text="Update" />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" />
            </div>
        </div>  
    </div>
    <hr />
    <div class="containerTable mt-3">
        <asp:GridView ID="dgvProducts" runat="server" EnableSortingAndPagingCallbacks="True"></asp:GridView>
        
        
        
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="POS_UI.UIManager.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Table: <asp:TextBox ID="txtIdProduct" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-md2 mb-3"> 
                Description: <asp:TextBox ID="txtDecription" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>
        
            <div class="col-md-2 mb-3"> 
                Category: <select class="custom-select" id="stlCategory" runat="server"> </select>
            </div>
            <div class="col-md-2 mb-3"> 
                Category: <asp:DropDownList ID="ddlStatus" CssClass="custom-select" runat="server">
                            <asp:ListItem value="0" text="Disable"></asp:ListItem>
                            <asp:ListItem value="1" text="Enable"></asp:ListItem>
                          </asp:DropDownList> 
            </div>
            <div class="col-md-2 mb-3 pt-4"> 
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mr-2" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </div>

        </div>  
    </div>
    <hr />
    <div class="containerTable mt-3">
        
        <asp:GridView ID="dgvProducts" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="idProduct" EmptyDataText="There are no data records to display." AutoGenerateSelectButton="True"  OnSelectedIndexChanged="dgvProducts_SelectedIndexChanged">  
            <Columns>  
                <asp:BoundField DataField="idProduct" HeaderText="ID" ReadOnly="True" />  
                <asp:BoundField DataField="ProductDescription" HeaderText="Dish name" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />  
                <asp:BoundField DataField="productCategoryDescription" HeaderText="Category" ItemStyle-CssClass="visible-xs" HeaderStyle-CssClass="visible-xs" />  
                <asp:BoundField DataField="productStatus" HeaderText="Status" HeaderStyle-CssClass="visible-md" ItemStyle-CssClass="visible-md" />  
            </Columns>  
        </asp:GridView>  
        
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="AddTables.aspx.cs" Inherits="POS_UI.UIManager.AddTables" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-4 mb-3"> 
                Table: <asp:TextBox ID="txtTableNumber" CssClass="form-control" placeholder="Unselected table" runat="server" Enabled="False"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3"> 
                Status: <select class="custom-select" id="sltTableStatus" runat="server"> </select>
            </div>
            <div class="col-md-4 mb-3 pt-4"> 
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mr-2" runat="server" Text="Update" OnClick="btnUpdate_Click"   />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" OnClick="btnAdd_Click"/>
            </div>
        </div>  
    </div>
    <hr />
    <div class="containerTable mt-3">
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
        
        <asp:RadioButtonList ID="rbtlTableList2" runat="server" OnSelectedIndexChanged="rbtlTableList_SelectedIndexChanged" AutoPostBack="True" Width="100%" RepeatLayout="OrderedList" ></asp:RadioButtonList>
        
    </div>
</asp:Content>


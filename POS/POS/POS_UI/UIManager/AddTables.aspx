<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="AddTables.aspx.cs" Inherits="POS_UI.UIManager.AddTables" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Button ID="btnUpdate" CssClass="btn btn-primary" runat="server" Text="Update" />
        <asp:Button ID="btnAdd" CssClass="btn btn-primary" runat="server" Text="Add" />
        <asp:Button ID="btnDelete" CssClass="btn btn-primary" runat="server" Text="Delete" />
    </div>
    <div class="container">
        <asp:RadioButtonList ID="rbtlTableList" runat="server"></asp:RadioButtonList>

    </div>

</asp:Content>


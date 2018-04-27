<%@ Page Title="" Language="C#" MasterPageFile="~/UIManager/Manager.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="POS_UI.UIManager.ManageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/siteStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container mt-4">
        <div class="form-row">
            <div class="col-md-2 mb-3"> 
                Username: <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server" ></asp:TextBox>

            </div>
            <div class="col-md2 mb-3"> 
                Password: <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="col-md-2 mb-3"> 
                Confirm Password: <asp:TextBox ID="txtConfirmPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>
         </div>
         <div class="form-row">
            <div class="col-md-2 mb-3"> 
                User type:  <select class="custom-select" id="sltUserType" runat="server"> </select> 
            </div>
            <div class="col-md-2 mb-3"> 
                Name: <asp:TextBox ID="txtName" CssClass="form-control" runat="server" ></asp:TextBox>   
            </div>
            <div class="col-md-2 mb-3"> 
                Last name: <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>
            <div class="col-md-2 mb-3 pt-4"> 
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mr-2" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnAdd" CssClass="btn btn-success mr-2" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnDelete" CssClass="btn btn-danger mr-2" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </div>
        </div>
    </div>  
    
    <hr />
    <div class="containerTable mt-3">
        
        <asp:GridView ID="dgvUsers" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="UserName" EmptyDataText="There are no data records to display." AutoGenerateSelectButton="True"  OnSelectedIndexChanged="dgvProducts_SelectedIndexChanged">  
            <Columns>  
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" />  
                <asp:BoundField DataField="Name" HeaderText="Name"  />  
                <asp:BoundField DataField="lastname" HeaderText="Last Name" />  
                <asp:BoundField DataField="usertype" HeaderText="User Type" />  
            </Columns>  
        </asp:GridView>  
        
    </div>
</asp:Content>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="POS_UI.Login" %>

<!DOCTYPE html>

<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="UTF-8">
    <title>POS-Restaurant | Login </title>
    <link href="css/bootstrap.css" rel="stylesheet"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/Login.js"></script>
    <link href="css/siteStyle.css" rel="stylesheet" />
    <style type="text/css" media="screen">
        html,body {overflow:hidden;}
     </style>
</head>
<body>
    <div class="FullLoginContainer">

    <div class="containerLogin py-5">
    <div class="row">
        <div class="col-md-12">
            <h2 class="text-center text-white mb-4">POS-Restaurant</h2>
            <div class="row">
                <div class="col-md-6 mx-auto">
                    <!-- form card login -->
                    <div class="card rounded-0">
                        <div class="card-header">
                            <h3 class="mb-0">Login</h3>
                        </div>
                        <div class="card-body">
                            <form class="form" role="form" autocomplete="off" id="formLogin" runat="server">
                                <div class="form-group">
                                    <asp:TextBox ID="txtUserName" placeholder="User name" runat="server" CssClass="form-control form-control-lg rounded-0"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="txtPassword" placeholder="Password" runat="server" CssClass="form-control form-control-lg rounded-0" TextMode="Password"></asp:TextBox>
                                </div>
                                <asp:Button ID="btnSubmit" runat="server" Text="Login" CssClass="btn btn-success btn-lg float-right"/>
                            </form>
                        </div>
                        <!--/card-block-->
                    </div>
                    <!-- /form card login -->
                </div>
            </div>
            <!--/row-->

        </div>
        <!--/col-->
    </div>
    <!--/row-->
</div>
<!--/container-->
</div>
</body>
</html>

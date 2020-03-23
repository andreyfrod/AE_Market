<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PracticaWeb.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/sweetalert2.min.js"></script>
    <script src="Scripts/mensaje.js"></script>
    <link href="Content/bootstrap.simplex.min.css" rel="stylesheet" />
    <link href="Content/sweetalert2.min.css" rel="stylesheet" />
    <title>Login AE_Market</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="col align-self-start">
                <asp:HyperLink ID="HyperLink1" CssClass="navbar-brand" NavigateUrl="~/login.aspx" runat="server">Login</asp:HyperLink>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </div>

        </nav>
        <div class="container">
            <div class="row justify-content-md-center">
                <div class="col col-lg-6">
                    <fieldset>
                        <legend>Login</legend>
                        <div class="form-group row">
                            <asp:Label ID="Label1" runat="server" class="col-sm-2 col-form-label" Text="Nombre Usuario"></asp:Label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtNombreUsuario" class="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                    runat="server"
                                    ErrorMessage="* El email es requerido"
                                    ControlToValidate="txtNombreUsuario"
                                    ValidationGroup="login"
                                    SetFocusOnError="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="Label2" runat="server" class="col-sm-2 col-form-label" Text="Password"></asp:Label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtPassword" class="form-control" TextMode="Password" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                    runat="server"
                                    ErrorMessage="* El password es requerido"
                                    ControlToValidate="txtPassword"
                                    ValidationGroup="login"
                                    SetFocusOnError="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <asp:Button ID="btnLogin" class="btn btn-primary" ValidationGroup="login" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </fieldset>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
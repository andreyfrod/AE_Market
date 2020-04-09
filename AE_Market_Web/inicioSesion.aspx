<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicioSesion.aspx.cs" Inherits="AE_Market_Web.inicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    
    <script src="Scripts/sweetalert2.all.min.js"></script>
    <script src="Scripts/mensaje.js"></script>
    <link href="Content/sweetalert2.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.materia.min.css" rel="stylesheet" />
   
    <title>Inicio Sesion</title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-primary" >
            <div class="col align-self-start" >
                <asp:HyperLink ID="HyperLink1" CssClass="navbar-brand" NavigateUrl="~/login.aspx" runat="server">Incio Sesion</asp:HyperLink>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </div>

        </nav>
        <div class="container">
            <div class="row justify-content-md-center">
                <div class="col col-lg-6">
                    <fieldset>
                        <legend>Inicie Sesion</legend>
                        <div class="form-group row">
                            <asp:Label ID="Label1" runat="server" CssClass="col-sm-2 col-form-label" Text="Email"></asp:Label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                    runat="server"
                                    ErrorMessage="* El email es requerido"
                                    ControlToValidate="txtEmail"
                                    ValidationGroup="login"
                                    SetFocusOnError="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group row">
                            <asp:Label ID="Label2" runat="server" CssClass="col-sm-2 col-form-label" Text="Contraseña"></asp:Label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtContrasenna" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                    runat="server"
                                    ErrorMessage="* La contraseña es requerida"
                                    ControlToValidate="txtContrasenna"
                                    ValidationGroup="login"
                                    SetFocusOnError="true" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <asp:Button ID="btnLogin" CssClass="btn btn-primary" ValidationGroup="login" runat="server" Text="Iniciar Sesion" OnClick="btnLogin_Click"  />
                        <asp:Button ID="btnCompras" CssClass="btn btn-primary" runat="server" Text="Comprar sin iniciar Sesion" OnClick="btnCompras_Click"  />
                    </fieldset>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
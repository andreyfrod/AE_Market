<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="AE_Market_Web.RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
   
       
            <fieldset>
                <legend>Nuevo Usuario</legend>
                <div class="form-group row">
                    <asp:Label ID="Label6" runat="server" CssClass="col-sm-2 col-form-label" Text="Nombre">Nombre</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtNombre"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1"
                            runat="server"
                            ErrorMessage="El Nombre es requerida*"
                            ControlToValidate="txtNombre"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblTipoUsuario" runat="server" CssClass="col-sm-2 col-form-label" Text="Tipo Usuario">Tipo Usuario</asp:Label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlTipoUsuario" 
                            CssClass="form-control"
                            runat="server"
                            
                            AutoPostBack="true">
                            <asp:ListItem>Seleccione el tipo de usuario</asp:ListItem>
                            <asp:ListItem>Administrador</asp:ListItem>
                            <asp:ListItem>Cliente</asp:ListItem>
                        </asp:DropDownList>

                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label2" runat="server" CssClass="col-sm-2 col-form-label" Text="Direccion">Direccion</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2"
                            runat="server"
                            ErrorMessage="La direccion del cliente es requerido*"
                            ControlToValidate="txtDireccion"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                      
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label1" runat="server" CssClass="col-sm-2 col-form-label">Número Telefonico</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtTelefono"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3"
                            runat="server"
                            ErrorMessage="El número contacto del cliente es requerido*"
                            ControlToValidate="txtTelefono"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="form-group row">
                    <asp:Label ID="Label4" runat="server" CssClass="col-sm-2 col-form-label" Text="Correo Electronico">Correo Electronico</asp:Label>
                    <div class="col-sm-10">
                         <asp:TextBox ID="txtCorreo" CssClass="form-control"
                            Text="@" TextMode="Email"
                            runat="server"
                          ></asp:TextBox>
                      
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator4"
                            runat="server"
                            ErrorMessage="El correo es requerido*"
                            ControlToValidate="txtCorreo"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                        
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label5" runat="server" CssClass="col-sm-2 col-form-label" Text="Contraseña">Contraseña</asp:Label>
                    <div class="col-sm-10">
                         <asp:TextBox ID="txtContrasenna" CssClass="form-control"
                            TextMode="Password"
                            runat="server"
                           ></asp:TextBox>
                      
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator5"
                            runat="server"
                            ErrorMessage="La contraseña es requerida*"
                            ControlToValidate="txtContrasenna"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                        
                    </div>
                </div>
             


                <asp:Button ID="btnRegistrar" ValidationGroup="registrar" OnClick="btnRegistrar_Click" CssClass="btn btn-primary" runat="server" Text="Registrar" />
            </fieldset>
       
        
   
</asp:Content>
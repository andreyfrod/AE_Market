<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registroCupones.aspx.cs" Inherits="AE_Market_Web.registroCupones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
   <div class="row">
     <div class="col col-lg-6">
            <fieldset>
                <legend>Nuevo Cupon</legend>
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
                    <asp:Label ID="Label2" runat="server" CssClass="col-sm-2 col-form-label" Text="Descripcion">Descripcion</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2"
                            runat="server"
                            ErrorMessage="La direccion del cliente es requerido*"
                            ControlToValidate="txtDescripcion"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="registrar"></asp:RequiredFieldValidator>
                      
                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="lblTipoUsuario" runat="server" CssClass="col-sm-2 col-form-label" Text="Tipo Cupon">Tipo Cupon</asp:Label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlTipoCupon" 
                            CssClass="form-control"
                            runat="server"
                            
                            AutoPostBack="true">
                            <asp:ListItem>Seleccione el tipo de Cupon</asp:ListItem>
                            <asp:ListItem>Descuento</asp:ListItem>
                            <asp:ListItem>Regalia</asp:ListItem>
                        </asp:DropDownList>

                    </div>
                </div>
                
                <div class="form-group row">
                    <asp:Label ID="Label1" runat="server" CssClass="col-sm-2 col-form-label" Text="Nivel">Nivel</asp:Label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlNivel" 
                            CssClass="form-control"
                            runat="server"
                            AutoPostBack="true">
                        </asp:DropDownList>

                    </div>
                </div>

               <div class="form-group row">
                    <asp:Label ID="Label3" runat="server" CssClass="col-sm-2 col-form-label" Text="Usuario">Usuario</asp:Label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlUsuario" 
                            CssClass="form-control"
                            runat="server"
                            AutoPostBack="true">
                        </asp:DropDownList>

                    </div>
                </div>
                <div class="form-group row">
                    <asp:Label ID="Label4" runat="server" CssClass="col-sm-2 col-form-label" Text="Producto">Priducto</asp:Label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlProducto" 
                            CssClass="form-control"
                            runat="server"
                            AutoPostBack="true">
                        </asp:DropDownList>

                    </div>
                </div>
             


                <asp:Button ID="btnRegistrar" ValidationGroup="registrar" OnClick="btnRegistrar_Click" CssClass="btn btn-primary" runat="server" Text="Registrar" />
            <div class="form-group row">
                    <asp:Label ID="lblMensaje" runat="server" CssClass="col-sm-2 col-form-label" ></asp:Label>
                </div>
            
            </fieldset>
       </div>
 
        
  </div> 
</asp:Content>
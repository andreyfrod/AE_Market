<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CambioContrasenna.aspx.cs" Inherits="AE_Market_Web.CambioContrasenna" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
   
       
            <fieldset>
                <legend>Nueva Contraseña</legend>
                <div class="form-group row">
                    <asp:Label ID="Label6" runat="server" CssClass="col-sm-2 col-form-label" Text="Nombre">Contraseña Actual</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtContrasennaActual"  CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1"
                            runat="server"
                            ErrorMessage="La contraseña actual es requerida*"
                            ControlToValidate="txtContrasennaActual"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="cambioContrasenna"></asp:RequiredFieldValidator>
                    </div>
                </div>
                
                <div class="form-group row">
                    <asp:Label ID="Label2" runat="server" CssClass="col-sm-2 col-form-label" >Contraseña Nueva</asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtContrasennaNueva" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2"
                            runat="server"
                            ErrorMessage="La contraseña nueva es requerida*"
                            ControlToValidate="txtContrasennaNueva"
                            ForeColor="Red"
                            SetFocusOnError="true"
                            Display="Dynamic"
                            ValidationGroup="cambioContrasenna"></asp:RequiredFieldValidator>
                      
                    </div>
                </div>
            
                <asp:Button ID="btnCambiar" ValidationGroup="cambioContrasenna" OnClick="btnCambiar_Click" CssClass="btn btn-primary" runat="server" Text="Cambiar" />
            <div class="form-group row">
                    <asp:Label ID="lblMensaje" runat="server" CssClass="col-sm-2 col-form-label" ></asp:Label>
                </div>
                </fieldset>
       
        
   
</asp:Content>

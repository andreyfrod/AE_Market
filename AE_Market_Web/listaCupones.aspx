<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaCupones.aspx.cs" Inherits="AE_Market_Web.listaCupones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView runat="server" ID="gvCupones" AutoGenerateColumns="false" EmptyDataText="No hay cupones disponibles para su usuario." GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="idCupon" SelectMethod="gvCupones_GetData">
        <HeaderStyle HorizontalAlign="Left" BackColor="yellowgreen" ForeColor="#FFFFFF" />
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Cupon" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="tipoCupon" HeaderText="Tipo de Cupon" />
            <asp:BoundField DataField="idNivel" HeaderText="Nivel" />
            <asp:BoundField DataField="idProducto" HeaderText="Producto" />
        </Columns>
    </asp:GridView>

</asp:Content>
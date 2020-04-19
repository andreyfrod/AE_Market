<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaProductosHogar.aspx.cs" Inherits="AE_Market_Web.listaProductosHogar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2>Productos</h2>
    <div class="form-group row">
            
<%--            <div class="col-sm-10">
                <br />
                <asp:DropDownList ID="ddlProducto" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducto_SelectedIndexChanged"></asp:DropDownList>
            </div>--%>
        </div>
         <asp:ListView ID="listaProductoHogar" runat="server" GroupItemCount="3"
        DataKeyNames="idProducto"
        ItemType="Entidades.ProductoEntidad"
        SelectMethod="listaProductoHogar_GetData"
             >
        <EmptyDataTemplate>
            <div class="col-lg-4">
                No hay datos
            </div>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <div class="card text-center border-primary mb-4">
            </div>
        </EmptyItemTemplate>
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-lg-4">
            <div class="card text-center border-primary mb-4">
                <div class="card-body">
                    <img />
                    <h5 class="card-title"><%#:Item.nombre %></h5>
                    <p class="card-text"><%#:Item.descripcion %></p>
                    <p class="card-text"><%#:Item.tipoProducto %></p>
                    <p class="card-text"><%# Eval("precio","₡{0:N2}") %></p>
                    <asp:Button CssClass="btn btn-primary" 
                        ID="btnAgregar" 
                        runat="server" Text="Agregar" 
                        CommandArgument='<%#:Item.idProducto %>'
                        OnCommand="btnAgregar_Command" />
                
                </div>
            </div>
                </div>
        </ItemTemplate>
        <LayoutTemplate>
            <div class="container">
                <asp:PlaceHolder ID="groupPlaceHolder" runat="server"></asp:PlaceHolder>
            </div>
        </LayoutTemplate>

    </asp:ListView>
    
    <a href="#" id="back-to-top" title="Back to top" style="display: none;">&uarr;</a>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="carritoCompras.aspx.cs" Inherits="AE_Market_Web.carritoCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Start Cart  -->
    <div class="cart-box-main">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="table-main table-responsive">

                        <asp:GridView runat="server" ID="gvShoppingCart" AutoGenerateColumns="false" EmptyDataText="No hay nada en su carrito, agrege algun articulo." GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="idProducto" SelectMethod="gvShoppingCart_GetData">
                            <Columns>
                                <asp:BoundField DataField="nombre" HeaderText="Producto" />
                                <asp:BoundField DataField="precio" HeaderText="Precio" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" DataFormatString="₡{0:N}" />
                                <asp:TemplateField HeaderText="Cantidad">
                                    <ItemTemplate>
                                        <asp:TextBox runat="server" ID="txtQuantity" Columns="5" TextMode="Number" min="1" max="20" step="1" AutoPostBack="true" Text='<%# Eval("cantidadProductos") %>' OnTextChanged="txtQuantity_TextChanged"></asp:TextBox><br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="total" HeaderText="Total" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" DataFormatString="₡{0:N}" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton runat="server" ID="btnRemove" Text="Eliminar" CommandName="Remove" CommandArgument='<%# Eval("idProducto") %>' style="font-size:12px;" OnClick="btnRemove_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>

                        <% foreach (var item in listaCarrito)
                            {
                                totalcantidad = totalcantidad + item.total;

                            } %>

                    </div>
                </div>
            </div>

            <div class="row my-5">
                <div class="col-lg-12 col-sm-6">
                    <div class="coupon-box">
                        <div class="input-group input-group-sm">
                            <input class="form-control" placeholder="Ingrese el codigo de su cupon" aria-label="Coupon code" type="text">
                            <div class="input-group-append">
                                <button class="btn btn-theme" type="button">Aplicar Cupon</button>
                            </div>
                        </div>
                    </div>
                </div>
<%--                <div class="col-lg-6 col-sm-6">
                    <div class="update-box">
                        <input value="Actulizar orden" type="submit">
                    </div>
                </div>--%>
            </div>

            <div class="row my-5">
                <div class="col-lg-8 col-sm-12"></div>
                <div class="col-lg-8 col-sm-12">
                    <div class="order-box">
                        <h3>Resumen</h3>
                        <div class="d-flex">
                            <h4>Sub Total</h4>
                            <div class="ml-auto font-weight-bold"> ₡ <%= totalcantidad %> </div>
                        </div>
                        <div class="d-flex">
                            <h4>Descuento General</h4>
                            <div class="ml-auto font-weight-bold"> ₡ 0 </div>
                        </div>
                        <hr class="my-1">
                        <div class="d-flex">
                            <h4>Descuento por cupon</h4>
                            <div class="ml-auto font-weight-bold"> ₡ 0 </div>
                        </div>
                        <div class="d-flex">
                            <h4>IVA</h4>
                            <div class="ml-auto font-weight-bold"> ₡ 0 </div>
                        </div>
                        <div class="d-flex">
                            <h4>Costo de envio</h4>
                            <div class="ml-auto font-weight-bold"> Gratis </div>
                        </div>
                        <hr>
                        <div class="d-flex gr-total">
                            <h5>Total</h5>
                            <div class="ml-auto h5"> ₡ <%= totalcantidad %> </div>
                        </div>
                        <hr> </div>
                </div>
                <div class="col-12 d-flex shopping-box"><a href="checkout.html" class="ml-auto btn hvr-hover">Pagar</a> </div>
            </div>

        </div>
    </div>
    <!-- End Cart -->  

    <a href="#" id="back-to-top" title="Back to top" style="display: none;">&uarr;</a>

</asp:Content>


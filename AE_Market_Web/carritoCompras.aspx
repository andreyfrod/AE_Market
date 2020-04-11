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
                        <table class="table">
                            <thead>
                                <tr>
                                   <%-- <th></th>--%>
                                    <th>Producto</th>
                                    <th>Precio</th>
                                    <th>Cantidad</th>
                                    <th>Total</th>
                                    <th>Eliminar</th>
                                </tr>
                            </thead>
                            <tbody>
                                <% foreach (var Carrito in listaCarrito)
                                   { %>
                                
                                <tr>
                                    <%--<td class="thumbnail-img"><a href="#">
                                        <img class="img-fluid" src="images/img-pro-01.jpg" alt="" /></a>
                                    </td>--%>
                                    <td class="name-pr"><a href="#"> <%= Carrito.nombre %> </a>
                                    </td>
                                    <td class="price-pr">
                                        <p> ₡ <%= Carrito.precio %> </p>
                                    </td>
                                    <td class="quantity-box">
                                        <asp:TextBox id="cantidadItems" TextMode="Number" Text="1" runat="server" min="1" max="20" step="1" AutoPostBack="true" OnTextChanged="cantidadItems_TextChanged"/>
                                        <%--<input runat="server" id="cantidad" type="number" size="4" value="1" min="0" step="1" class="c-input-text qty text">--%>
                                    </td>
                                    <td class="total-pr">
                                        <p id="totalxCantidad"> ₡ <%= Carrito.precio * Convert.ToInt32(cantidadItems.Text) %> </p>
                                    </td>
                                    <td class="remove-pr"><a href="#"><i class="fas fa-times"></i></a>
                                    </td>
                                </tr>
                                
                                <% } %>
                               
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

            <div class="row my-5">
                <div class="col-lg-6 col-sm-6">
                    <div class="coupon-box">
                        <div class="input-group input-group-sm">
                            <input class="form-control" placeholder="Ingrese el codigo de su cupon" aria-label="Coupon code" type="text">
                            <div class="input-group-append">
                                <button class="btn btn-theme" type="button">Aplicar Cupon</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6 col-sm-6">
                    <div class="update-box">
                        <input value="Actulizar orden" type="submit">
                    </div>
                </div>
            </div>

            <div class="row my-5">
                <div class="col-lg-8 col-sm-12"></div>
                <div class="col-lg-4 col-sm-12">
                    <div class="order-box">
                        <h3>Resumen</h3>
                        <div class="d-flex">
                            <h4>Sub Total</h4>
                            <div class="ml-auto font-weight-bold"> $ </div>
                        </div>
                        <div class="d-flex">
                            <h4>Descuento General</h4>
                            <div class="ml-auto font-weight-bold"> $ 40 </div>
                        </div>
                        <hr class="my-1">
                        <div class="d-flex">
                            <h4>Descuento por cupon</h4>
                            <div class="ml-auto font-weight-bold"> $ 10 </div>
                        </div>
                        <div class="d-flex">
                            <h4>IVA</h4>
                            <div class="ml-auto font-weight-bold"> $ 2 </div>
                        </div>
                        <div class="d-flex">
                            <h4>Costo de envio</h4>
                            <div class="ml-auto font-weight-bold"> Free </div>
                        </div>
                        <hr>
                        <div class="d-flex gr-total">
                            <h5>Total</h5>
                            <div class="ml-auto h5"> $ 388 </div>
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


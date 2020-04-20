<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaNiveles.aspx.cs" Inherits="AE_Market_Web.listaNiveles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="about-box-main">
        <div class="container">
            <div class="row">
				<div class="col-lg-6">
                    <div class="banner-frame"> <img class="img-fluid" src="images/about-img.jpg" alt="" />
                    </div>
                </div>
                <div class="col-lg-6">
                    <h2 class="noo-sh-title-top">Conozca nuestros <span>niveles de usuarios</span></h2>
                    <p>Los niveles de usuario son una idea que surge de parte de AE Market para reconocer a nuestros mejores clientes, consiste en 4 niveles de clasificasion para cada cliente, con los cuales cada cliente tendra beneficios especiales en sus compras, como descuentos, productos de regalia y mas.</p>
                    <p>Con esto esperamos poder retribuir un poco a nuestros usuarios y darle las gracias por preferirnos todos los dias. </p>
                </div>
            </div>

            <div>
                <br />
                <h2 class="noo-sh-title">Conozca los niveles</h2>
            </div>

            <div class="row my-5">
                <div class="col-sm-6 col-lg-3">
                    <div class="service-block-inner">
                        <h3>Bronce</h3>
                        <p>Este nivel de usuario se consigue al realizar compras por mas de ¢20,000, y le permite al usuario tener un descuento de un 2% en sus compras. </p>
                    </div>
                </div>
                <div class="col-sm-6 col-lg-3">
                    <div class="service-block-inner">
                        <h3>Plata</h3>
                        <p>Este nivel de usuario se consigue al realizar compras por mas de ¢50,000, y le permite al usuario tener un descuento de un 5% en sus compras. </p>
                    </div>
                </div>
                <div class="col-sm-6 col-lg-3">
                    <div class="service-block-inner">
                        <h3>Oro</h3>
                        <p>Este nivel de usuario se consigue al realizar compras por mas de ¢150,000, y le permite al usuario tener un descuento de un 7% en sus compras. </p>
                    </div>
                </div>
                <div class="col-sm-6 col-lg-3">
                    <div class="service-block-inner">
                        <h3>Diamante</h3>
                        <p>Este nivel de usuario se consigue al realizar compras por mas de ¢300,000, y le permite al usuario tener un descuento de un 10% en sus compras. </p>
                    </div>
                </div>
            </div>

        </div>
    </div>
    
    <a href="#" id="back-to-top" title="Back to top" style="display: none;">&uarr;</a>
</asp:Content>

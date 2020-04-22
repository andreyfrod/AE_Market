<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AE_Market_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Start Slider -->
    <div id="slides-shop" class="cover-slides">
        <ul class="slides-container">
            <li class="text-center">
                <img src="images/bannerN-01.jpg" alt=""/>
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <h1 class="m-b-20"><strong>Bienvenido a <br> AE Market</strong></h1>
                            <p class="m-b-40">Calidad y respaldo 100% nacional, de y para los ticos <br> compre con confianza y seguridad en nuestro sitio.</p>
                            <p><a class="btn hvr-hover" href="listaProductos.aspx">Comprar</a></p>
                        </div>
                    </div>
                </div>
            </li>
            <li class="text-center">
                <img src="images/bannerN-02.jpeg" alt="">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <h1 class="m-b-20"><strong>Bienvenido a <br> AE Market</strong></h1>
                            <p class="m-b-40">Entregas garantizadas en menos de 48 horas, <br> de nuestras bodegas a su casa en un abrir y cerrar de ojos.</p>
                            <p><a class="btn hvr-hover" href="listaProductos.aspx">Comprar</a></p>
                        </div>
                    </div>
                </div>
            </li>
            <li class="text-center">
                <img src="images/bannerN-03.jpg" alt="">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <h1 class="m-b-20"><strong>Bienvenido a <br> AE Market</strong></h1>
                            <p class="m-b-40">5 estrellas en seguridad con nuestros sistema de pago, <br> con nosotros su compra esta garantizada.</p>
                            <p><a class="btn hvr-hover" href="listaProductos.aspx">Comprar</a></p>
                        </div>
                    </div>
                </div>
            </li>
        </ul>
        <div class="slides-navigation">
            <a href="#" class="next"><i class="fa fa-angle-right" aria-hidden="true"></i></a>
            <a href="#" class="prev"><i class="fa fa-angle-left" aria-hidden="true"></i></a>
        </div>
    </div>
    <!-- End Slider -->

    <!-- Start Categories  -->
    <div class="categories-shop">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12">
                    <div class="shop-cat-box">
                        <img class="img-fluid" src="images/bannerN-01.jpg" alt="" />
                        <a class="btn hvr-hover" href="listaProductosHogar.aspx">Hogar</a>
                    </div>
                </div>
                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12">
                    <div class="shop-cat-box">
                        <img class="img-fluid" src="images/bannerN-03.jpg" alt="" />
                        <a class="btn hvr-hover" href="listaProductosVehiculo.aspx">Vehiculo</a>
                    </div>
                </div>
                <div class="col-lg-4 col-md-4 col-sm-12 col-xs-12">
                    <div class="shop-cat-box">
                        <img class="img-fluid" src="images/bannerN-02.jpeg" alt="" />
                        <a class="btn hvr-hover" href="listaProductosElectronicos.aspx">Electronico</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Categories -->
	
	<div class="box-add-products">
		<div class="container">
			<div class="row">
				<div class="col-lg-6 col-md-6 col-sm-12">
					<div class="offer-box-products">
						<img class="img-fluid" src="images/addN-01.jpg" alt="" />
					</div>
				</div>
				<div class="col-lg-6 col-md-6 col-sm-12">
					<div class="offer-box-products">
						<img class="img-fluid" src="images/addN-02.jpg" alt="" />
					</div>
				</div>
			</div>
		</div>
	</div>

</asp:Content>

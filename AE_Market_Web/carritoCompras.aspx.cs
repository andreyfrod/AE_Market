using AE_Market_Entidades;
using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market_Web
{
    public partial class carritoCompras : System.Web.UI.Page
    {
        public List<CarritoEntidad> listaCarrito { get { return CarritoEntidad.listaCarrito; } }

        public static decimal totalcantidad;
        public decimal totalpago;
        public static decimal descuentoGlobal;
        public static decimal totalFinal;
        public String mensajeDescuento;

        protected void Page_Load(object sender, EventArgs e)
        {
            totalcantidad = 0;
            descuentoGlobal = 0;
            totalFinal = 0;
            mensajeDescuento = "";
            calculoDescuento();
            this.lblMensaje.Text = "";
        }

        protected ProductoEntidad obtenerProductoxId (int idProducto)
        {
            ProductoEntidad producto = new ProductoEntidad();
            producto = ProductoLN.Obtener(idProducto);
            return producto;
        }

        public List<CarritoEntidad> gvShoppingCart_GetData()
        {
            return listaCarrito;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            int idProducto = Convert.ToInt32(btn.CommandArgument);
            CompraLN.EliminarProductoLista(idProducto);
            Response.Redirect("carritoCompras.aspx");
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox row = (TextBox)(sender);
            GridViewRow grow = (GridViewRow)row.NamingContainer;
            row = (TextBox)grow.FindControl("txtQuantity");
            int idProducto = Convert.ToInt32(row.Attributes["CommandArgument"].ToString());
            CompraLN.actualizarCantidad(idProducto, Convert.ToInt32(row.Text));
            totalcantidad = 0;
            Response.Redirect("carritoCompras.aspx");
        }

       

        protected void btnPagar_Command(object sender, CommandEventArgs e)
        {
           

            if (Session["usuario"] == null)
            {
                Response.Redirect("inicioSesion.aspx");
            }
            else
            {
                //Usuario autentificado
                UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];

                
                CompraEntidad compra = new CompraEntidad();
                compra.fecha = DateTime.Now;
                compra.idUsuario = user.idUsuario;

                //Datos producto
                double descuento=0;
                double totalPagar=0; 
                foreach (var item in listaCarrito)
                {

                    compra.idProducto = item.idProducto;
                    compra.cantidadProductos = item.cantidadProductos;
                    totalPagar = Convert.ToDouble(item.total);

                }

                

                //Consultar cupon por usuario
                List<CuponEntidad> cupones = new List<CuponEntidad>();
                cupones=CuponLN.ObtenerCuponporUsuario(user.idUsuario);
                foreach (var item in cupones)
                {
                    if (item.idNivel==user.nivelEntidad.idNivel&&item.idProducto==compra.idProducto)
                    {
                        NivelEntidad nivel = NivelLN.Obtener(item.idNivel);
                        if (nivel.descripcion=="Bronce")
                        {
                            compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.02));
                            descuento = totalPagar * 0.02;
                        }
                        else
                        {
                            if (nivel.descripcion == "Plata")
                            {
                                compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.05));
                                descuento = totalPagar * 0.05;
                            }
                            else
                            {
                                if (nivel.descripcion == "Oro")
                                {
                                    compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.07));
                                    descuento = totalPagar * 0.07;
                                }
                                else
                                {

                                
                                    if (nivel.descripcion == "Diamante")
                                    {
                                    
                                        compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.10));
                                        descuento = totalPagar * 0.10;
                                    
                                    }
                                    else
                                    {
                                        compra.total = Convert.ToDecimal(totalPagar);
                                    }

                                }
                            }
                        }
                    }
                    
                }

                
                if (compra!=null)
                {
                    if (compra.total==0)
                    {
                        compra.total = Convert.ToDecimal(totalPagar);
                    }
                    
                    CompraLN.Nuevo(compra);
                    CompraLN.limpiarLista();
                    descuentoGlobal = 0;
                    totalFinal = 0;
                    Response.Redirect("carritoCompras.aspx");
                    this.lblMensaje.Text = "Compra realizada con exito";
                }
                
                
                

            }

        }

        protected void calculoDescuento() {

            if (Session["usuario"] == null)
            {
                mensajeDescuento = "Ingrese sesion para ver sus cupones y obtener descuentos!";
            }
            else
            {

                //Usuario autentificado
                UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];


                CompraEntidad compra = new CompraEntidad();


                //Datos producto
                double descuento = 0;
                double totalPagar = 0;
                foreach (var item in listaCarrito)
                {
                    compra.idProducto = item.idProducto;
                    totalPagar = Convert.ToDouble(item.total);

                }



                //Consultar cupon por usuario
                List<CuponEntidad> cupones = new List<CuponEntidad>();
                cupones = CuponLN.ObtenerCuponporUsuario(user.idUsuario);
                foreach (var item in cupones)
                {
                    if (item.idNivel == user.nivelEntidad.idNivel && item.idProducto == compra.idProducto)
                    {
                        NivelEntidad nivel = NivelLN.Obtener(item.idNivel);
                        if (nivel.descripcion == "Bronce")
                        {
                            compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.02));
                            descuento = totalPagar * 0.02;
                        }
                        else
                        {
                            if (nivel.descripcion == "Plata")
                            {
                                compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.05));
                                descuento = totalPagar * 0.05;
                            }
                            else
                            {
                                if (nivel.descripcion == "Oro")
                                {
                                    compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.07));
                                    descuento = totalPagar * 0.07;
                                }
                                else
                                {
                                    compra.total = Convert.ToDecimal(totalPagar - (totalPagar * 0.10));
                                    descuento = totalPagar * 0.10;
                                }
                            }
                        }
                    }
                }

                descuentoGlobal = Convert.ToDecimal(descuento);
                totalFinal = Convert.ToDecimal(totalPagar - descuento);
            }
        }

    }
}
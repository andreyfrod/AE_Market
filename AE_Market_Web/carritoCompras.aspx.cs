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

        protected void Page_Load(object sender, EventArgs e)
        {
            totalcantidad = 0; 
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
                
                
                double descuento;
                double totalPagar = Convert.ToDouble(totalcantidad);

                //Consultar cupon por usuario
                List<CuponEntidad> cupones = new List<CuponEntidad>();
                cupones=CuponLN.ObtenerCuponporUsuario(user.idUsuario);
                foreach (var item in cupones)
                {
                    if (item.idUsuario==user.idUsuario)
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
                                if (nivel.descripcion == "Plata")
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

                //Datos producto
                foreach (var item in listaCarrito)
                {

                    compra.idProducto = item.idProducto;
                    compra.cantidadProductos = item.cantidadProductos;
                }

                CompraLN.Nuevo(compra);
                
                

            }

        }
    }
}
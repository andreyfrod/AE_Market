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

        public int cantProd;
        public decimal totalcantidad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                
                int test = 1;
            }
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
            Response.Redirect("carritoCompras.aspx");
        }
    }
}
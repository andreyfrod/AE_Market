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
    public partial class listaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregar_Command(object sender, CommandEventArgs e)
        {
            ShoppingCart.Instance.AddItem(Convert.ToInt32(e.CommandArgument.ToString()));

            ProductoEntidad producto = ProductoLN.Obtener(Convert.ToInt32(e.CommandArgument.ToString()));
            CompraLN.AgregarProductoLista(producto);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<Entidades.ProductoEntidad> listaProducto_GetData()
        {
            return ProductoLN.ObtenerTodos();
        }

    }
}
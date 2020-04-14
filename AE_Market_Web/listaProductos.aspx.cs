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
            ddlProducto.DataSource = ProductoLN.ObtenerTodos();
            ddlProducto.DataTextField = "tipoProducto";
            ddlProducto.DataValueField = "tipoProducto";
            ddlProducto.DataBind();
        }
        protected void btnAgregar_Command(object sender, CommandEventArgs e)
        {
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

        protected void ddlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lista= ProductoLN.ObtenerTipo(this.ddlProducto.SelectedValue.ToString());
            listaProducto.DataSource = ProductoLN.ObtenerTipo(this.ddlProducto.SelectedValue.ToString());

            listaProducto.DataBind();
        }
    }
}
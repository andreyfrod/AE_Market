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
    public partial class listaProductosHogar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Command(object sender, CommandEventArgs e)
        {
            ProductoEntidad producto = ProductoLN.Obtener(Convert.ToInt32(e.CommandArgument.ToString()));
            CompraLN.AgregarProductoLista(producto);
        }

        public List<Entidades.ProductoEntidad> listaProductoHogar_GetData()
        {
            return ProductoLN.ObtenerTipo("Hogar");
        }
    }
}
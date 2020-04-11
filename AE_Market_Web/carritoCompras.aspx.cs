using Entidades;
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
        public List<ProductoEntidad> listaCarrito { get { return CompraEntidad.listaCarrito; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
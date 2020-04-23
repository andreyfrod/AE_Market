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
    public partial class listaCupones : System.Web.UI.Page
    {
        public List<CuponEntidad> Cupones { get { return CuponEntidad.listaCupon; } }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<CuponEntidad> gvCupones_GetData()
        {
            UsuarioEntidad user = (UsuarioEntidad)Session["usuario"];
            return CuponLN.ObtenerCuponporUsuario(user.idUsuario);
        }
    }
}
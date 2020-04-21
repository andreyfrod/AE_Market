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
    public partial class registroCupones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            //PostBack
            //Carga inicial de la página
            if (!IsPostBack)
            {
                //Cargar lista de niveles
                ddlNivel.DataSource = NivelLN.ObtenerTodos();
                ddlNivel.DataTextField = "descripcion";
                ddlNivel.DataValueField = "idNivel";
                ddlNivel.DataBind();

                //Cargar lista de usuarios
                ddlUsuario.DataSource = UsuarioLN.ObtenerTodos();
                ddlUsuario.DataTextField = "nombre";
                ddlUsuario.DataValueField = "idUsuario";
                ddlUsuario.DataBind();

                //Cargar lista de productos
                ddlProducto.DataSource = ProductoLN.ObtenerTodos();
                ddlProducto.DataTextField = "nombre";
                ddlProducto.DataValueField = "idProducto";
                ddlProducto.DataBind();

        
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            //Datos cupon
            CuponEntidad cupon = new CuponEntidad();
            cupon.nombre = txtNombre.Text;
            cupon.descripcion = txtDescripcion.Text;
            cupon.tipoCupon = Convert.ToString(ddlTipoCupon.SelectedValue);
            cupon.idNivel = Convert.ToInt32(ddlNivel.SelectedValue);
            cupon.idUsuario = Convert.ToInt32(ddlUsuario.SelectedValue);
            cupon.idProducto = Convert.ToInt32(ddlProducto.SelectedValue);

            if (cupon!=null)
            {
                CuponLN.Nuevo(cupon);
                this.lblMensaje.Text = "Cupon agregado con exito";

                //Limpiar campos
                this.txtNombre.Text = "";
                this.txtDescripcion.Text = "";
                this.ddlTipoCupon.ClearSelection();
                this.ddlNivel.ClearSelection();
                this.ddlUsuario.ClearSelection();
                this.ddlProducto.ClearSelection();
            }
            
        }
    }
}
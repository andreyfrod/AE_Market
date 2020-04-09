using AE_Market_Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AE_Market_Web
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                this.ddlTipoUsuario.Visible = false;
                this.lblTipoUsuario.Visible = false;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioEntidad usuario = new UsuarioEntidad();
            //Tipo de usuario
            if (Session["usuario"] == null)
            {
                usuario.tipoUsuario = "Cliente";
            }
            else
            {
                usuario.tipoUsuario = this.ddlTipoUsuario.SelectedValue;
            }
            
            usuario.nombre = this.txtNombre.Text;
            usuario.nivelEntidad = NivelLN.Obtener(1);
            usuario.direccion = this.txtDireccion.Text;
            usuario.telefono = this.txtTelefono.Text;
            usuario.email = this.txtCorreo.Text;
            usuario.password = this.txtContrasenna.Text;

            UsuarioLN.Nuevo(usuario);

        }
    }
}
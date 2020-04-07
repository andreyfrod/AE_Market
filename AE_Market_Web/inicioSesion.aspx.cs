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
    public partial class inicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                UsuarioEntidad user = new UsuarioEntidad();
                user.email = txtEmail.Text;
                user.password = txtContrasenna.Text;
                user = UsuarioLN.verificarCredenciales(user);
                if (user != null)
                {
                    Session["usuario"] = user;
                    ClientScript.RegisterStartupScript(
                   this.GetType(),
                   "Login",
                    "mensajeRedirect('Login','Credenciales correctas','success','listaProductos.aspx')",
                   true
                   );
                }
                else
                {
                    ClientScript.RegisterStartupScript(
                   this.GetType(),
                   "Login",
                    "mensajeRedirect('Login','Verifique las credenciales','error','inicioSesion.aspx')",
                   true
                   );
                }
            }
        }

        protected void btnCompras_Click(object sender, EventArgs e)
        {
            Response.Redirect("listaProductos.aspx");
        }
    }
}